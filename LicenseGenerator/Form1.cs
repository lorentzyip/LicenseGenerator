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
using System.Security.Cryptography;

namespace LicenseGenerator
{
    public partial class Form1 : Form
    {
        bool regen;

        public Form1()
        {
            InitializeComponent();
            cipherText.Text = "";
            cipherText.ReadOnly = true;
            regen = true;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (macAddress.Text.Length != 12)
            {
                MessageBox.Show("Invalid MAC Address.");
                return;
            }

            Crypto cryto = new Crypto();

            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(macAddress.Text.ToLower() + "+" + expiryDate.Value.ToString("ddMMyyyy"));
            byte[] passwordBytes = Encoding.UTF8.GetBytes("Lorentz@QWESTRO");

            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
            byte[] bytesEncrypted = cryto.AES_Encrypt(bytesToBeEncrypted, passwordBytes);
            cipherText.Text = Convert.ToBase64String(bytesEncrypted);
            regen = false;
        }

        private void macAddress_TextChanged(object sender, EventArgs e)
        {
            cipherText.Text = "";
            regen = true;
        }

        private void expiryDate_ValueChanged(object sender, EventArgs e)
        {
            cipherText.Text = "";
            regen = true;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (regen)
            {
                MessageBox.Show("Please press 'Generate' button.");
                return;
            }

            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;

            try {
                File.WriteAllText(fileName, cipherText.Text);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
