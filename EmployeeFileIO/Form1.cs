using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Employee.dat";

                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(textID.Text));
                binaryWriter.Write(textName.Text);
                binaryWriter.Write(Convert.ToDouble(textSalary.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Employee.dat";

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                textID.Text = binaryReader.ReadInt32().ToString();
                textName.Text = binaryReader.ReadString();
                textSalary.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();
                //  MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
