namespace NoteApp
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNotesFromDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectCategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noteListTextBox = new System.Windows.Forms.TextBox();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modifiactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noteTextTextBox = new System.Windows.Forms.TextBox();
            this.noteCategoryLabel = new System.Windows.Forms.Label();
            this.saveToDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fielToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(880, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fielToolStripMenuItem
            // 
            this.fielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.loadNotesFromDiskToolStripMenuItem,
            this.saveToDiskToolStripMenuItem});
            this.fielToolStripMenuItem.Name = "fielToolStripMenuItem";
            this.fielToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fielToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadNotesFromDiskToolStripMenuItem
            // 
            this.loadNotesFromDiskToolStripMenuItem.Name = "loadNotesFromDiskToolStripMenuItem";
            this.loadNotesFromDiskToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loadNotesFromDiskToolStripMenuItem.Text = "LoadNotesFromDisk";
            this.loadNotesFromDiskToolStripMenuItem.Click += new System.EventHandler(this.loadNotesFromDiskToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SelectCategoryComboBox1
            // 
            this.SelectCategoryComboBox1.FormattingEnabled = true;
            this.SelectCategoryComboBox1.Location = new System.Drawing.Point(122, 60);
            this.SelectCategoryComboBox1.Name = "SelectCategoryComboBox1";
            this.SelectCategoryComboBox1.Size = new System.Drawing.Size(174, 21);
            this.SelectCategoryComboBox1.TabIndex = 1;
            this.SelectCategoryComboBox1.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select category";
            // 
            // noteListTextBox
            // 
            this.noteListTextBox.Location = new System.Drawing.Point(38, 87);
            this.noteListTextBox.Multiline = true;
            this.noteListTextBox.Name = "noteListTextBox";
            this.noteListTextBox.Size = new System.Drawing.Size(258, 517);
            this.noteListTextBox.TabIndex = 3;
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Location = new System.Drawing.Point(333, 63);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(61, 13);
            this.NoteNameLabel.TabIndex = 4;
            this.NoteNameLabel.Text = "Заголовок";
            // 
            // creationDateTimePicker
            // 
            this.creationDateTimePicker.Location = new System.Drawing.Point(431, 95);
            this.creationDateTimePicker.Name = "creationDateTimePicker";
            this.creationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationDateTimePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата создания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата изменения";
            // 
            // modifiactionDateTimePicker
            // 
            this.modifiactionDateTimePicker.Location = new System.Drawing.Point(431, 130);
            this.modifiactionDateTimePicker.Name = "modifiactionDateTimePicker";
            this.modifiactionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.modifiactionDateTimePicker.TabIndex = 8;
            // 
            // noteTextTextBox
            // 
            this.noteTextTextBox.Location = new System.Drawing.Point(325, 203);
            this.noteTextTextBox.Multiline = true;
            this.noteTextTextBox.Name = "noteTextTextBox";
            this.noteTextTextBox.Size = new System.Drawing.Size(543, 401);
            this.noteTextTextBox.TabIndex = 9;
            this.noteTextTextBox.Text = "Текст заметки";
            // 
            // noteCategoryLabel
            // 
            this.noteCategoryLabel.AutoSize = true;
            this.noteCategoryLabel.Location = new System.Drawing.Point(333, 171);
            this.noteCategoryLabel.Name = "noteCategoryLabel";
            this.noteCategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.noteCategoryLabel.TabIndex = 10;
            this.noteCategoryLabel.Text = "Категория";
            // 
            // saveToDiskToolStripMenuItem
            // 
            this.saveToDiskToolStripMenuItem.Name = "saveToDiskToolStripMenuItem";
            this.saveToDiskToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveToDiskToolStripMenuItem.Text = "SaveToDisk";
            this.saveToDiskToolStripMenuItem.Click += new System.EventHandler(this.saveToDiskToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 616);
            this.Controls.Add(this.noteCategoryLabel);
            this.Controls.Add(this.noteTextTextBox);
            this.Controls.Add(this.modifiactionDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creationDateTimePicker);
            this.Controls.Add(this.NoteNameLabel);
            this.Controls.Add(this.noteListTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectCategoryComboBox1);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ComboBox SelectCategoryComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noteListTextBox;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.DateTimePicker creationDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker modifiactionDateTimePicker;
        private System.Windows.Forms.TextBox noteTextTextBox;
        private System.Windows.Forms.Label noteCategoryLabel;
        private System.Windows.Forms.ToolStripMenuItem loadNotesFromDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToDiskToolStripMenuItem;
    }
}

