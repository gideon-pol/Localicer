using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Localicer
{
    public partial class Editor : MetroForm
    {
        public delegate void ClosingHandler(string editedText);
        public event ClosingHandler ClosingEditor;

        public Editor(string text)
        {
            InitializeComponent();
            Text.Text = text;
            Text.SelectionStart = Text.Text.Length;
            Text.SelectionLength = 0;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            ClosingEditor?.Invoke(Text.Text);
            this.Close();
        }
    }
}
