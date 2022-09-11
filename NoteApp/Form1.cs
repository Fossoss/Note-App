using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace NoteApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void File_Click(object sender, EventArgs e)
        {
            if (DropDownFile.Visible == true)
            {
                DropDownFile.Visible = false;
            }
            if (DropDownFile.Visible == false) 
            {
                DropDownFile.Visible = true;
            }
            if(EditBox.Visible == true)
            {
                EditBox.Visible = false;
            }
            if(SettingsPanel.Visible == true)
            {
                SettingsPanel.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sButton2_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (EditBox.Visible == false)
            {
                EditBox.Visible = true;
            }
            
            else if (EditBox.Visible == true)
            {
                EditBox.Visible = false;
            }

            if (DropDownFile.Visible == true)
            {
                DropDownFile.Visible = false;
            }
            if (SettingsPanel.Visible == true)
            {
                SettingsPanel.Visible = false;
            }
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            if(SettingsPanel.Visible == false)
            {
                SettingsPanel.Visible = true;
            }
            else if(SettingsPanel.Visible == true)
            {
                SettingsPanel.Visible=false;
            }

            if (DropDownFile.Visible == true)
            {
                DropDownFile.Visible = false;
            }
            if (EditBox.Visible == true)
            {
                EditBox.Visible = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DropDownFile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sButton3_Click(object sender, EventArgs e)
        {

        }

        private void sButton2_Click_1(object sender, EventArgs e)
        {
            TextBox.SelectAll();
            TextBox.Focus();
            EditBox.Visible=false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DropDownFile_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sButton3_Click_1(object sender, EventArgs e)
        {
            TextBox.SelectAll();
            TextBox.Focus();
            TextBox.Copy();
            EditBox.Visible=false;
            
        }

        private void sButton4_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "")
            {
                DropDownFile.Visible = false;
            }
            else if(TextBox.Text != "")
            {
                DropDownFile.Visible = false;
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DropDownFile.Visible = false;
                    Stream myStream;
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.DefaultExt = ".txt";
                    saveFileDialog1.FileName = "*";
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        if ((myStream = saveFileDialog1.OpenFile()) != null)
                        {
                            myStream.Close();
                            using (StreamWriter wr = new StreamWriter(saveFileDialog1.FileName))
                            {
                                wr.WriteLine(this.TextBox.Text);
                            }
                        }
                    }

                    TextBox.Text = "";
                    DropDownFile.Visible = false;
                }
                else if (result == DialogResult.No)
                {
                    TextBox.Text = "";
                }
                else if (result == DialogResult.Cancel)
                {
                    // do nothing
                }
            }
        }

        private void sButton2_Click_2(object sender, EventArgs e)
        {
            DropDownFile.Visible=false;
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.FileName = "*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Close();
                        using (StreamWriter wr = new StreamWriter(saveFileDialog1.FileName))
                        {
                            wr.WriteLine(this.TextBox.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file to disk. Original error: " + ex.Message);
                }


            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sButton3_Click_2(object sender, EventArgs e)
        {
            DropDownFile.Visible = false;
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "Text Documents|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            TextBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
