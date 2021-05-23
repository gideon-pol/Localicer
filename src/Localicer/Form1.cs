using BrightIdeasSoftware;
using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localicer
{
    public partial class Form1 : MetroForm
    {
        List<Entry> entries = new List<Entry>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();

            foreach (OLVColumn item in fastObjectListView1.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(Color.FromArgb(7,7,7));
                headerstyle.SetForeColor(Color.FromArgb(200, 200, 200));
                headerstyle.SetFont(new Font("Segoe UI Light", 12, FontStyle.Regular));
                headerstyle.Pressed.BackColor = Color.FromArgb(142, 188, 0);
                item.HeaderFormatStyle = headerstyle;
            }
        }

        //Clear all items from the listbox and add the new items
        //This function is slow for redrawing and should be substituted by for instance RedrawItem whenever possible
        private void UpdateListBox(List<Entry> entries = null)
        {
            fastObjectListView1.ClearObjects();

            if (entries == null) entries = this.entries;

            fastObjectListView1.AddObjects(entries);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary Chunk|*.chunk";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    Stream fileStream = openFileDialog1.OpenFile();

                    entries = ChunkFileManipulation.ReadChunkFile(fileStream);
                    Message.Text = "Succesfully read from file " + openFileDialog1.FileName;
                    UpdateListBox();
                }
                catch
                {
                    Message.Text = "Something went wrong reading file " + openFileDialog1.FileName;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Binary Chunk|*.chunk";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    Stream fileStream = saveFileDialog1.OpenFile();

                    ChunkFileManipulation.WriteChunkFile(fileStream, entries);

                    Message.Text = "Succesfully saved to file " + openFileDialog1.FileName;
                }
                catch
                {
                    Message.Text = "Something went wrong writing to file " + openFileDialog1.FileName;
                }
            }
        }

        //Make sure we disable replacement case if the case is not ignored
        private void IgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            if (IgnoreCaseReplace.Checked)
            {
                ApplyReplacedCase.Enabled = true;
            }
            else
            {
                ApplyReplacedCase.Enabled = false;
            }
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            MatchMode mode = IgnoreCaseReplace.Checked ? (ApplyReplacedCase.Checked ? MatchMode.UseReplacementCase : MatchMode.IgnoreCase) : MatchMode.MatchCase;
            int entriesChanged = 0;
            int occurrencesChanged = 0;

            for(int i = 0; i < entries.Count; i++)
            {
                int occurrences = 0;
                entries[i].Value = entries[i].Value.ReplaceWith(ToBeReplaced.Text, ToBeReplacedWith.Text, mode, ref occurrences);
                if (occurrences != 0)
                {
                    occurrencesChanged += occurrences;
                    entriesChanged++;
                }
            }

            fastObjectListView1.RedrawItems(0, fastObjectListView1.Items.Count-1, true);
            Message.Text = $"Replaced {occurrencesChanged} occurrences in {entriesChanged} entries";
        }

        //If the search button or enter key are pressed search the entries and display the items
        private void Search_Click(object sender, EventArgs e)
        {
            SearchAndUpdateList(SearchText.Text);
        }

        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchAndUpdateList(SearchText.Text);
                fastObjectListView1.Focus();
                e.SuppressKeyPress = true;
            }
        }

        //Iterate over all items and display the ones that match in the current mode
        private void SearchAndUpdateList(string query)
        {
            if (query == "")
            {
                UpdateListBox(entries);
                return;
            }

            List<Entry> foundEntries = new List<Entry>();
            MatchMode mode = IgnoreCaseSearch.Checked ? MatchMode.IgnoreCase : MatchMode.MatchCase;

            for (int i = 0; i < entries.Count; i++)
            {
                if (entries[i].Value.Search(query, mode))
                {
                    foundEntries.Add(entries[i]);
                }
            }

            Message.Text = $"Found {foundEntries.Count} entries";
            UpdateListBox(foundEntries);
        }

        //If a cell is double clicked an editor should be opened and the default editing of the objectlist should be cancelled
        private void fastObjectListView1_CellEditStarting(object sender, CellEditEventArgs e)
        {
            Editor editor = new Editor(((Entry)e.ListViewItem.RowObject).Value);
            editor.ClosingEditor += (s) => { ((Entry)e.ListViewItem.RowObject).Value = s; fastObjectListView1.RefreshItem(e.ListViewItem);};
            editor.ShowDialog();
            e.Cancel = true;
        }  
    }
}
