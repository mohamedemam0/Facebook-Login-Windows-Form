namespace Facebook_Log_in
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
            this.webFacebook = new System.Windows.Forms.WebBrowser();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webFacebook
            // 
            this.webFacebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webFacebook.Location = new System.Drawing.Point(0, 0);
            this.webFacebook.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFacebook.Name = "webFacebook";
            this.webFacebook.Size = new System.Drawing.Size(793, 435);
            this.webFacebook.TabIndex = 0;
            this.webFacebook.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webFacebook_DocumentCompleted);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(366, 357);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sing In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 435);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.webFacebook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webFacebook;
        private System.Windows.Forms.Button btnSignIn;
    }
}

