using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UploaderModule
{
    public partial class Uploader : Form
    {
        public Uploader()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = o.FileName;
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                File.Move(txtFilePath.Text, @"C:\"+Path.GetFileName(txtFilePath.Text));
                MessageBox.Show("SAKUSESU!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
