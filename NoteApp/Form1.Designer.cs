namespace NoteApp
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Edit = new Sipaa.Framework.SButton();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.File = new Sipaa.Framework.SButton();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.DropDownFile = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditBox = new System.Windows.Forms.Panel();
            this.CopyAll = new Sipaa.Framework.SButton();
            this.SelectAll = new Sipaa.Framework.SButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sButton4 = new Sipaa.Framework.SButton();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.sButton3 = new Sipaa.Framework.SButton();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.DropDownFile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EditBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Edit.BorderRadius = 6;
            this.Edit.BorderSize = 0;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(63, 13);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(45, 35);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(114, 13);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(75, 35);
            this.sButton1.TabIndex = 4;
            this.sButton1.Text = "Settings";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.File.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.File.BorderRadius = 6;
            this.File.BorderSize = 0;
            this.File.FlatAppearance.BorderSize = 0;
            this.File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.File.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File.ForeColor = System.Drawing.Color.White;
            this.File.Location = new System.Drawing.Point(9, 13);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(45, 35);
            this.File.TabIndex = 3;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = false;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.BulletIndent = 2;
            this.TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.White;
            this.TextBox.Location = new System.Drawing.Point(0, 51);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Name = "TextBox";
            this.TextBox.ShowSelectionMargin = true;
            this.TextBox.Size = new System.Drawing.Size(533, 253);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // DropDownFile
            // 
            this.DropDownFile.Controls.Add(this.sButton3);
            this.DropDownFile.Controls.Add(this.sButton2);
            this.DropDownFile.Controls.Add(this.sButton4);
            this.DropDownFile.Controls.Add(this.panel2);
            this.DropDownFile.Location = new System.Drawing.Point(0, 49);
            this.DropDownFile.Name = "DropDownFile";
            this.DropDownFile.Size = new System.Drawing.Size(116, 121);
            this.DropDownFile.TabIndex = 5;
            this.DropDownFile.Visible = false;
            this.DropDownFile.Paint += new System.Windows.Forms.PaintEventHandler(this.DropDownFile_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 250);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.SettingsPanel);
            this.panel1.Controls.Add(this.EditBox);
            this.panel1.Controls.Add(this.DropDownFile);
            this.panel1.Controls.Add(this.TextBox);
            this.panel1.Controls.Add(this.File);
            this.panel1.Controls.Add(this.sButton1);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 304);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EditBox
            // 
            this.EditBox.Controls.Add(this.CopyAll);
            this.EditBox.Controls.Add(this.SelectAll);
            this.EditBox.Location = new System.Drawing.Point(67, 49);
            this.EditBox.Name = "EditBox";
            this.EditBox.Size = new System.Drawing.Size(116, 82);
            this.EditBox.TabIndex = 5;
            this.EditBox.Visible = false;
            this.EditBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DropDownFile_Paint_1);
            // 
            // CopyAll
            // 
            this.CopyAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CopyAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CopyAll.BorderRadius = 6;
            this.CopyAll.BorderSize = 0;
            this.CopyAll.FlatAppearance.BorderSize = 0;
            this.CopyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyAll.ForeColor = System.Drawing.Color.White;
            this.CopyAll.Location = new System.Drawing.Point(9, 42);
            this.CopyAll.Name = "CopyAll";
            this.CopyAll.Size = new System.Drawing.Size(97, 37);
            this.CopyAll.TabIndex = 1;
            this.CopyAll.Text = "Copy All";
            this.CopyAll.UseVisualStyleBackColor = false;
            this.CopyAll.Click += new System.EventHandler(this.sButton3_Click_1);
            // 
            // SelectAll
            // 
            this.SelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.SelectAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SelectAll.BorderRadius = 6;
            this.SelectAll.BorderSize = 0;
            this.SelectAll.FlatAppearance.BorderSize = 0;
            this.SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAll.ForeColor = System.Drawing.Color.White;
            this.SelectAll.Location = new System.Drawing.Point(9, 3);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(97, 35);
            this.SelectAll.TabIndex = 2;
            this.SelectAll.Text = "Select All";
            this.SelectAll.UseVisualStyleBackColor = false;
            this.SelectAll.Click += new System.EventHandler(this.sButton2_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.BulletIndent = 2;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(1001, 463);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(520, 249);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // sButton4
            // 
            this.sButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton4.BorderRadius = 6;
            this.sButton4.BorderSize = 0;
            this.sButton4.FlatAppearance.BorderSize = 0;
            this.sButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton4.ForeColor = System.Drawing.Color.White;
            this.sButton4.Location = new System.Drawing.Point(9, 3);
            this.sButton4.Name = "sButton4";
            this.sButton4.Size = new System.Drawing.Size(93, 35);
            this.sButton4.TabIndex = 6;
            this.sButton4.Text = "New";
            this.sButton4.UseVisualStyleBackColor = false;
            this.sButton4.Click += new System.EventHandler(this.sButton4_Click);
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 6;
            this.sButton2.BorderSize = 0;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(9, 43);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(94, 35);
            this.sButton2.TabIndex = 7;
            this.sButton2.Text = "Save as";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click_2);
            // 
            // sButton3
            // 
            this.sButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton3.BorderRadius = 6;
            this.sButton3.BorderSize = 0;
            this.sButton3.FlatAppearance.BorderSize = 0;
            this.sButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton3.ForeColor = System.Drawing.Color.White;
            this.sButton3.Location = new System.Drawing.Point(9, 83);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(94, 35);
            this.sButton3.TabIndex = 8;
            this.sButton3.Text = "Open";
            this.sButton3.UseVisualStyleBackColor = false;
            this.sButton3.Click += new System.EventHandler(this.sButton3_Click_2);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Location = new System.Drawing.Point(115, 49);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(74, 82);
            this.SettingsPanel.TabIndex = 6;
            this.SettingsPanel.Visible = false;
            this.SettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(520, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DropDownFile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.EditBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Sipaa.Framework.SButton Edit;
        private Sipaa.Framework.SButton sButton1;
        private Sipaa.Framework.SButton File;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Panel DropDownFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel EditBox;
        private Sipaa.Framework.SButton CopyAll;
        private Sipaa.Framework.SButton SelectAll;
        private Sipaa.Framework.SButton sButton4;
        private Sipaa.Framework.SButton sButton2;
        private Sipaa.Framework.SButton sButton3;
        private System.Windows.Forms.Panel SettingsPanel;
    }
}

