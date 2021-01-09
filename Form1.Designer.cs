namespace Lab5b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorGroupBox = new System.Windows.Forms.GroupBox();
            this.EpisodeTextBox = new System.Windows.Forms.TextBox();
            this.EpisodeLabel = new System.Windows.Forms.Label();
            this.DoctorPictureBox = new System.Windows.Forms.PictureBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.SeriesLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.ActorTextBox = new System.Windows.Forms.TextBox();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompanionListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QueryGroupBox = new System.Windows.Forms.GroupBox();
            this.LinqRadioButton = new System.Windows.Forms.RadioButton();
            this.SqlRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.DoctorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.QueryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1356, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DoctorGroupBox
            // 
            this.DoctorGroupBox.Controls.Add(this.EpisodeTextBox);
            this.DoctorGroupBox.Controls.Add(this.EpisodeLabel);
            this.DoctorGroupBox.Controls.Add(this.DoctorPictureBox);
            this.DoctorGroupBox.Controls.Add(this.AgeTextBox);
            this.DoctorGroupBox.Controls.Add(this.AgeLabel);
            this.DoctorGroupBox.Controls.Add(this.SeriesTextBox);
            this.DoctorGroupBox.Controls.Add(this.SeriesLabel);
            this.DoctorGroupBox.Controls.Add(this.YearTextBox);
            this.DoctorGroupBox.Controls.Add(this.YearLabel);
            this.DoctorGroupBox.Controls.Add(this.ActorTextBox);
            this.DoctorGroupBox.Controls.Add(this.PlayLabel);
            this.DoctorGroupBox.Controls.Add(this.DoctorComboBox);
            this.DoctorGroupBox.Controls.Add(this.DoctorLabel);
            this.DoctorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorGroupBox.Location = new System.Drawing.Point(22, 47);
            this.DoctorGroupBox.Name = "DoctorGroupBox";
            this.DoctorGroupBox.Size = new System.Drawing.Size(604, 554);
            this.DoctorGroupBox.TabIndex = 1;
            this.DoctorGroupBox.TabStop = false;
            this.DoctorGroupBox.Text = "The Doctor";
            // 
            // EpisodeTextBox
            // 
            this.EpisodeTextBox.Location = new System.Drawing.Point(19, 514);
            this.EpisodeTextBox.Name = "EpisodeTextBox";
            this.EpisodeTextBox.Size = new System.Drawing.Size(419, 30);
            this.EpisodeTextBox.TabIndex = 12;
            // 
            // EpisodeLabel
            // 
            this.EpisodeLabel.AutoSize = true;
            this.EpisodeLabel.Location = new System.Drawing.Point(15, 482);
            this.EpisodeLabel.Name = "EpisodeLabel";
            this.EpisodeLabel.Size = new System.Drawing.Size(167, 25);
            this.EpisodeLabel.TabIndex = 11;
            this.EpisodeLabel.Text = "First Full Episode:";
            // 
            // DoctorPictureBox
            // 
            this.DoctorPictureBox.Location = new System.Drawing.Point(266, 182);
            this.DoctorPictureBox.Name = "DoctorPictureBox";
            this.DoctorPictureBox.Size = new System.Drawing.Size(312, 320);
            this.DoctorPictureBox.TabIndex = 10;
            this.DoctorPictureBox.TabStop = false;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(157, 302);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(69, 30);
            this.AgeTextBox.TabIndex = 9;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(15, 305);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(121, 25);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Age at Start:";
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Location = new System.Drawing.Point(157, 245);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.Size = new System.Drawing.Size(69, 30);
            this.SeriesTextBox.TabIndex = 7;
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.AutoSize = true;
            this.SeriesLabel.Location = new System.Drawing.Point(15, 248);
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Size = new System.Drawing.Size(74, 25);
            this.SeriesLabel.TabIndex = 6;
            this.SeriesLabel.Text = "Series:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(157, 182);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(69, 30);
            this.YearTextBox.TabIndex = 5;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(15, 182);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(59, 25);
            this.YearLabel.TabIndex = 4;
            this.YearLabel.Text = "Year:";
            // 
            // ActorTextBox
            // 
            this.ActorTextBox.Location = new System.Drawing.Point(157, 120);
            this.ActorTextBox.Name = "ActorTextBox";
            this.ActorTextBox.Size = new System.Drawing.Size(421, 30);
            this.ActorTextBox.TabIndex = 3;
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.Location = new System.Drawing.Point(15, 120);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(104, 25);
            this.PlayLabel.TabIndex = 2;
            this.PlayLabel.Text = "Played by:";
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(157, 57);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(421, 33);
            this.DoctorComboBox.TabIndex = 1;
            this.DoctorComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorComboBox_SelectedIndexChanged);
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.AutoSize = true;
            this.DoctorLabel.Location = new System.Drawing.Point(15, 60);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(75, 25);
            this.DoctorLabel.TabIndex = 0;
            this.DoctorLabel.Text = "Doctor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompanionListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(632, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 554);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Companions and Their first episode with this Doctor:";
            // 
            // CompanionListBox
            // 
            this.CompanionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanionListBox.FormattingEnabled = true;
            this.CompanionListBox.ItemHeight = 25;
            this.CompanionListBox.Location = new System.Drawing.Point(7, 57);
            this.CompanionListBox.Name = "CompanionListBox";
            this.CompanionListBox.Size = new System.Drawing.Size(486, 479);
            this.CompanionListBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1149, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 335);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // QueryGroupBox
            // 
            this.QueryGroupBox.Controls.Add(this.LinqRadioButton);
            this.QueryGroupBox.Controls.Add(this.SqlRadioButton);
            this.QueryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryGroupBox.Location = new System.Drawing.Point(1137, 412);
            this.QueryGroupBox.Name = "QueryGroupBox";
            this.QueryGroupBox.Size = new System.Drawing.Size(207, 107);
            this.QueryGroupBox.TabIndex = 4;
            this.QueryGroupBox.TabStop = false;
            this.QueryGroupBox.Text = "Query:";
            // 
            // LinqRadioButton
            // 
            this.LinqRadioButton.AutoSize = true;
            this.LinqRadioButton.Location = new System.Drawing.Point(6, 56);
            this.LinqRadioButton.Name = "LinqRadioButton";
            this.LinqRadioButton.Size = new System.Drawing.Size(189, 29);
            this.LinqRadioButton.TabIndex = 1;
            this.LinqRadioButton.TabStop = true;
            this.LinqRadioButton.Text = "Solve Using LINQ";
            this.LinqRadioButton.UseVisualStyleBackColor = true;
            // 
            // SqlRadioButton
            // 
            this.SqlRadioButton.AutoSize = true;
            this.SqlRadioButton.Location = new System.Drawing.Point(6, 26);
            this.SqlRadioButton.Name = "SqlRadioButton";
            this.SqlRadioButton.Size = new System.Drawing.Size(184, 29);
            this.SqlRadioButton.TabIndex = 0;
            this.SqlRadioButton.TabStop = true;
            this.SqlRadioButton.Text = "Solve Using SQL";
            this.SqlRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DoctorGroupBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.DoctorGroupBox.ResumeLayout(false);
            this.DoctorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.QueryGroupBox.ResumeLayout(false);
            this.QueryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox DoctorGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox CompanionListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox QueryGroupBox;
        private System.Windows.Forms.RadioButton LinqRadioButton;
        private System.Windows.Forms.RadioButton SqlRadioButton;
        private System.Windows.Forms.TextBox EpisodeTextBox;
        private System.Windows.Forms.Label EpisodeLabel;
        private System.Windows.Forms.PictureBox DoctorPictureBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.Label SeriesLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox ActorTextBox;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label DoctorLabel;
        private System.Windows.Forms.Label label1;
    }
}

