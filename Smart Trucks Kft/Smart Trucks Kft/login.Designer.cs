namespace Smart_Trucks_Kft
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.NevLabel = new System.Windows.Forms.Label();
            this.jelszolabel = new System.Windows.Forms.Label();
            this.errorProviderNev = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderJelszo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJelszo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(124, 114);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(88, 23);
            this.buttonlogin.TabIndex = 2;
            this.buttonlogin.Text = "Bejelentkezés";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // NevLabel
            // 
            this.NevLabel.AutoSize = true;
            this.NevLabel.Location = new System.Drawing.Point(25, 51);
            this.NevLabel.Name = "NevLabel";
            this.NevLabel.Size = new System.Drawing.Size(81, 13);
            this.NevLabel.TabIndex = 3;
            this.NevLabel.Text = "Felhasznalónév";
            this.NevLabel.Click += new System.EventHandler(this.NevLabel_Click);
            // 
            // jelszolabel
            // 
            this.jelszolabel.AutoSize = true;
            this.jelszolabel.Location = new System.Drawing.Point(25, 87);
            this.jelszolabel.Name = "jelszolabel";
            this.jelszolabel.Size = new System.Drawing.Size(36, 13);
            this.jelszolabel.TabIndex = 4;
            this.jelszolabel.Text = "Jelszó";
            // 
            // errorProviderNev
            // 
            this.errorProviderNev.ContainerControl = this;
            // 
            // errorProviderJelszo
            // 
            this.errorProviderJelszo.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 189);
            this.Controls.Add(this.jelszolabel);
            this.Controls.Add(this.NevLabel);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJelszo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Label NevLabel;
        private System.Windows.Forms.Label jelszolabel;
        private System.Windows.Forms.ErrorProvider errorProviderNev;
        private System.Windows.Forms.ErrorProvider errorProviderJelszo;
    }
}