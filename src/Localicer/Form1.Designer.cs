using MetroFramework.Controls;

namespace Localicer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ToBeReplaced = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToBeReplacedWith = new System.Windows.Forms.TextBox();
            this.IgnoreCaseReplace = new MetroFramework.Controls.MetroCheckBox();
            this.ApplyReplacedCase = new MetroFramework.Controls.MetroCheckBox();
            this.Message = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.Hash = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Value = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.IgnoreCaseSearch = new MetroFramework.Controls.MetroCheckBox();
            this.Search = new Localicer.CustomButton();
            this.Replace = new Localicer.CustomButton();
            this.Save = new Localicer.CustomButton();
            this.Open = new Localicer.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToBeReplaced
            // 
            this.ToBeReplaced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToBeReplaced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ToBeReplaced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToBeReplaced.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.ToBeReplaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ToBeReplaced.Location = new System.Drawing.Point(710, 17);
            this.ToBeReplaced.Name = "ToBeReplaced";
            this.ToBeReplaced.Size = new System.Drawing.Size(100, 23);
            this.ToBeReplaced.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(658, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "replace:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(816, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "with:";
            // 
            // ToBeReplacedWith
            // 
            this.ToBeReplacedWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToBeReplacedWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ToBeReplacedWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToBeReplacedWith.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.ToBeReplacedWith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ToBeReplacedWith.Location = new System.Drawing.Point(852, 17);
            this.ToBeReplacedWith.Name = "ToBeReplacedWith";
            this.ToBeReplacedWith.Size = new System.Drawing.Size(100, 23);
            this.ToBeReplacedWith.TabIndex = 5;
            // 
            // IgnoreCaseReplace
            // 
            this.IgnoreCaseReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IgnoreCaseReplace.AutoSize = true;
            this.IgnoreCaseReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IgnoreCaseReplace.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.IgnoreCaseReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.IgnoreCaseReplace.Location = new System.Drawing.Point(710, 46);
            this.IgnoreCaseReplace.Name = "IgnoreCaseReplace";
            this.IgnoreCaseReplace.Size = new System.Drawing.Size(83, 15);
            this.IgnoreCaseReplace.TabIndex = 7;
            this.IgnoreCaseReplace.Text = "Ignore case";
            this.IgnoreCaseReplace.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IgnoreCaseReplace.UseVisualStyleBackColor = true;
            this.IgnoreCaseReplace.CheckedChanged += new System.EventHandler(this.IgnoreCase_CheckedChanged);
            // 
            // ApplyReplacedCase
            // 
            this.ApplyReplacedCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyReplacedCase.AutoSize = true;
            this.ApplyReplacedCase.Enabled = false;
            this.ApplyReplacedCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyReplacedCase.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.ApplyReplacedCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ApplyReplacedCase.Location = new System.Drawing.Point(710, 67);
            this.ApplyReplacedCase.Name = "ApplyReplacedCase";
            this.ApplyReplacedCase.Size = new System.Drawing.Size(159, 15);
            this.ApplyReplacedCase.TabIndex = 8;
            this.ApplyReplacedCase.Text = "Apply replaced text\'s case";
            this.ApplyReplacedCase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ApplyReplacedCase.UseVisualStyleBackColor = true;
            // 
            // Message
            // 
            this.Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Message.Location = new System.Drawing.Point(5, 624);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 11;
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.SearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SearchText.Location = new System.Drawing.Point(185, 17);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(376, 23);
            this.SearchText.TabIndex = 12;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.Hash);
            this.fastObjectListView1.AllColumns.Add(this.Value);
            this.fastObjectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.fastObjectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastObjectListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.fastObjectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fastObjectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hash,
            this.Value});
            this.fastObjectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastObjectListView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.fastObjectListView1.HideSelection = false;
            this.fastObjectListView1.Location = new System.Drawing.Point(10, 90);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.RowHeight = 40;
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(1110, 529);
            this.fastObjectListView1.TabIndex = 14;
            this.fastObjectListView1.UseAlternatingBackColors = true;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            this.fastObjectListView1.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.fastObjectListView1_CellEditStarting);
            // 
            // Hash
            // 
            this.Hash.AspectName = "Hash";
            this.Hash.AspectToStringFormat = "0x{0:X8}";
            this.Hash.HeaderFont = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Hash.HeaderForeColor = System.Drawing.Color.LightGray;
            this.Hash.Text = "Hash";
            this.Hash.Width = 100;
            // 
            // Value
            // 
            this.Value.AspectName = "Value";
            this.Value.CellEditUseWholeCell = true;
            this.Value.FillsFreeSpace = true;
            this.Value.Sortable = false;
            this.Value.Text = "Value";
            this.Value.Width = 1000;
            this.Value.WordWrap = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IgnoreCaseSearch
            // 
            this.IgnoreCaseSearch.AutoSize = true;
            this.IgnoreCaseSearch.Checked = true;
            this.IgnoreCaseSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IgnoreCaseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IgnoreCaseSearch.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.IgnoreCaseSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.IgnoreCaseSearch.Location = new System.Drawing.Point(185, 46);
            this.IgnoreCaseSearch.Name = "IgnoreCaseSearch";
            this.IgnoreCaseSearch.Size = new System.Drawing.Size(83, 15);
            this.IgnoreCaseSearch.TabIndex = 15;
            this.IgnoreCaseSearch.Text = "Ignore case";
            this.IgnoreCaseSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IgnoreCaseSearch.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Search.Location = new System.Drawing.Point(567, 17);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Replace
            // 
            this.Replace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Replace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replace.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.Replace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Replace.Location = new System.Drawing.Point(960, 17);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 2;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = false;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Save.Location = new System.Drawing.Point(91, 17);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Open.Location = new System.Drawing.Point(10, 17);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 642);
            this.Controls.Add(this.IgnoreCaseSearch);
            this.Controls.Add(this.fastObjectListView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ApplyReplacedCase);
            this.Controls.Add(this.IgnoreCaseReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToBeReplacedWith);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToBeReplaced);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Localicer.CustomButton Open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private CustomButton Save;
        private CustomButton Replace;
        private System.Windows.Forms.TextBox ToBeReplaced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ToBeReplacedWith;
        private MetroCheckBox IgnoreCaseReplace;
        private MetroCheckBox ApplyReplacedCase;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox SearchText;
        private CustomButton Search;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private BrightIdeasSoftware.OLVColumn Hash;
        private BrightIdeasSoftware.OLVColumn Value;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroCheckBox IgnoreCaseSearch;
    }
}

