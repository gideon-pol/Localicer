using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localicer
{
    public static class ChunkFileManipulation
    {
        private static Encoding enc = Encoding.Default;

        /*
         Base code for reading/writing was written by VNNCC for his localization editor, Github: https://github.com/VNNCC/FbLocalization    
         I heavily modified it to make it easier to understand and perform better
        */

        public static void WriteChunkFile(Stream stream, List<Entry> entries)
        {
            BinaryWriter writer = new BinaryWriter(stream, enc);
            writer.BaseStream.Position = 0;

            writer.Write(0x39000);

            // File size
            writer.Write(0);
            // Write list size
            writer.Write((uint)(entries.Count));

            writer.Write(0);

            // Write temp strings offset
            writer.Write(0);
            WriteCString(writer, "Global");

            // Write zero bytes
            writer.Write(new byte[113]);
            uint dataOffset = (uint)writer.BaseStream.Position;

            writer.BaseStream.Position = 12;
            writer.Write(dataOffset); // Write data offset
            writer.BaseStream.Position = dataOffset;

            writer.Write(new byte[8]);

            uint stringsOffsetStart = (uint)(entries.Count * 8 + writer.BaseStream.Position);
            uint currentStringPosition = stringsOffsetStart;

            uint currentHashOffsetPosition = (uint)writer.BaseStream.Position;

            foreach (Entry entry in entries)
            {
                writer.Write(entry.Hash);
                currentHashOffsetPosition = (uint)writer.BaseStream.Position;

                writer.BaseStream.Position = currentStringPosition;
                uint offset = (uint)writer.BaseStream.Position - stringsOffsetStart;
                WriteCString(writer, entry.Value);
                currentStringPosition = (uint)writer.BaseStream.Position;

                writer.BaseStream.Position = currentHashOffsetPosition;
                writer.Write(offset);
            }

            writer.BaseStream.Position = 4;
            writer.Write((uint)writer.BaseStream.Length - 8);

            writer.BaseStream.Position = 16;
            writer.Write((uint)stringsOffsetStart - 8);

            writer.Close();
        }

        private static void WriteCString(BinaryWriter writer, string text)
        {
            byte[] bytes = GetCBytes(text);
            writer.Write(bytes, 0, bytes.Length);
        }

        private static byte[] GetCBytes(string text)
        {
            List<byte> stringBytes = enc.GetBytes(text).ToList();
            stringBytes.Add((byte)0);
            return stringBytes.ToArray();
        }

        public static List<Entry> ReadChunkFile(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream, enc);
            List<Entry> entries = new List<Entry>();

            reader.BaseStream.Position = 0;

            if (reader.ReadUInt32() != 0x39000)
                throw new InvalidDataException();

            uint fileSize = reader.ReadUInt32();
            uint listSize = reader.ReadUInt32();
            uint dataOffset = reader.ReadUInt32() + 8;
            uint stringsOffset = reader.ReadUInt32() + 8;

            ReadCString(reader);

            var hashList = new List<uint>();
            var offsetList = new List<uint>();

            for(int i = 0; i <= listSize; i++)
            {
                reader.BaseStream.Position = dataOffset;
                uint hash = reader.ReadUInt32();
                uint offset = reader.ReadUInt32();
                dataOffset += 8;

                if (stringsOffset + offset > reader.BaseStream.Length) continue;

                reader.BaseStream.Position = stringsOffset + offset;
                string value = ReadCString(reader);
                entries.Add(new Entry(hash, value));
            }

            reader.Close();
            return entries;
        }

        private static string ReadCString(BinaryReader reader)
        {
            List<byte> bytes = new List<byte>();

            while (true)
            {
                byte c = reader.ReadByte();

                if (c == 0)
                {
                    break;
                }

                bytes.Add(c); 
            }

            return enc.GetString(bytes.ToArray());
        }   
    }

    public class Entry
    {
        public uint Hash;
        public string Value;

        public Entry(uint Hash, string Value)
        {
            this.Hash = Hash;
            this.Value = Value;
        }
    }
}
