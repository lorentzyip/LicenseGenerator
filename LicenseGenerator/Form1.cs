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
        public Form1()
        {
            InitializeComponent();
            cipherText.Text = "";
            exportText.Text = "";
            cipherText.ReadOnly = true;
            exportBtn.Enabled = false;
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
            exportBtn.Enabled = true;
        }

        private void macAddress_TextChanged(object sender, EventArgs e)
        {
            cipherText.Text = "";
            exportText.Text = "";
            exportBtn.Enabled = false;
        }

        private void expiryDate_ValueChanged(object sender, EventArgs e)
        {
            cipherText.Text = "";
            exportText.Text = "";
            exportBtn.Enabled = false;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;

            try {
                File.WriteAllText(fileName, cipherText.Text);
                exportText.Text = "File Exported";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void macAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
