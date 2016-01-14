namespace LicenseGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.macAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.expiryDate = new System.Windows.Forms.DateTimePicker();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.exportText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAC Address:";
            // 
            // macAddress
            // 
            this.macAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.macAddress.Location = new System.Drawing.Point(96, 9);
            this.macAddress.MaxLength = 12;
            this.macAddress.Name = "macAddress";
            this.macAddress.Size = new System.Drawing.Size(368, 21);
            this.macAddress.TabIndex = 1;
            this.macAddress.TextChanged += new System.EventHandler(this.macAddress_TextChanged);
            this.macAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.macAddress_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expiry Date:";
            // 
            // expiryDate
            // 
            this.expiryDate.Location = new System.Drawing.Point(96, 36);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(200, 21);
            this.expiryDate.TabIndex = 3;
            this.expiryDate.ValueChanged += new System.EventHandler(this.expiryDate_ValueChanged);
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(96, 64);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(368, 21);
            this.cipherText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cipher: ";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(96, 91);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 6;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(177, 91);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 7;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "license.dat";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // exportText
            // 
            this.exportText.AutoSize = true;
            this.exportText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exportText.Location = new System.Drawing.Point(94, 117);
            this.exportText.Name = "exportText";
            this.exportText.Size = new System.Drawing.Size(41, 12);
            this.exportText.TabIndex = 8;
            this.exportText.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 272);
            this.Controls.Add(this.exportText);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.macAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "License Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox macAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker expiryDate;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label exportText;
    }
}

