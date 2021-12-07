
namespace QR_code
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
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtVatNo = new System.Windows.Forms.TextBox();
            this.txtTimeDate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadSample = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(126, 61);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(245, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // txtVatNo
            // 
            this.txtVatNo.Location = new System.Drawing.Point(126, 102);
            this.txtVatNo.Name = "txtVatNo";
            this.txtVatNo.Size = new System.Drawing.Size(245, 20);
            this.txtVatNo.TabIndex = 0;
            // 
            // txtTimeDate
            // 
            this.txtTimeDate.Location = new System.Drawing.Point(126, 138);
            this.txtTimeDate.Name = "txtTimeDate";
            this.txtTimeDate.Size = new System.Drawing.Size(245, 20);
            this.txtTimeDate.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(126, 174);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(245, 20);
            this.txtAmount.TabIndex = 0;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(126, 210);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(245, 20);
            this.txtVat.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encode ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBase64
            // 
            this.txtBase64.Enabled = false;
            this.txtBase64.Location = new System.Drawing.Point(126, 260);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.Size = new System.Drawing.Size(499, 44);
            this.txtBase64.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(292, 330);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Compnay Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vat Reg No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date & Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vat Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "QR Code";
            // 
            // btnLoadSample
            // 
            this.btnLoadSample.Location = new System.Drawing.Point(433, 57);
            this.btnLoadSample.Name = "btnLoadSample";
            this.btnLoadSample.Size = new System.Drawing.Size(192, 78);
            this.btnLoadSample.TabIndex = 7;
            this.btnLoadSample.Text = "Load Sample";
            this.btnLoadSample.UseVisualStyleBackColor = true;
            this.btnLoadSample.Click += new System.EventHandler(this.btnLoadSample_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(640, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 172);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 809);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLoadSample);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBase64);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtTimeDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtVatNo);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "Form1";
            this.Text = "QRCODE genaration for E-invoice By Hussain Sheriff";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtVatNo;
        private System.Windows.Forms.TextBox txtTimeDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadSample;
        private System.Windows.Forms.Button button2;
    }
}

