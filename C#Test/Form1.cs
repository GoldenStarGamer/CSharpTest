using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;

namespace C_Test
{
    
    public partial class Form1 : Form
    {
        static string ComputeMD5(string s) {
            StringBuilder sb = new StringBuilder();

            // Initialize a MD5 hash object
            using (MD5 md5 = MD5.Create()) {
                // Compute the hash of the given string
                byte[] hashValue = md5.ComputeHash(Encoding.UTF8.GetBytes(s));

                // Convert the byte array to string format
                foreach (byte b in hashValue) {
                    sb.Append($"{b:X2}");
                }
            }

            return sb.ToString();
        }
        string algorithm;
        string tth;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            algorithm = comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            tth = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            switch(algorithm) {
                case "MD5":
                    hashr.Text = ComputeMD5(tth);
                    break;

                case "RIPEMD160":
                    break;

                case "SHA1":
                    break;

                case "SHA256":
                    break;

                case "SHA384":
                    break;

                case "SHA512":
                    break;

            }
        }
    }
}
