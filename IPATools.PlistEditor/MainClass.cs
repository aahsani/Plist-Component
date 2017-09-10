using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IPATools.PlistEditor
{
    public partial class MainClass : Form
    {
        private System.Windows.Forms.OpenFileDialog DBOpenFileDialog;
        private string DBFilePath;
        //string[] args;
        private ErrorProvider error;

        public MainClass()
        {
            InitializeComponent();
            DBOpenFileDialog = new OpenFileDialog();
            //this.args = args;
            this.error = new ErrorProvider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                DBFilePath = DBOpenFileDialog.FileName;
                textBox1.Text = DBFilePath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBFilePath = textBox1.Text;
            error.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(DBFilePath))
            {
                FormMain plistBackupPage = null;
                try
                {
                    plistBackupPage = new FormMain(this, DBFilePath);
                    plistBackupPage.Show();
                    this.Hide();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("There is no siutable file in given path!!!( " + ex.FileName + " )", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                error.SetError(textBox1, "Empty Box !!");
            }
        }
    }
}
