namespace Crypt
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChose = new System.Windows.Forms.Button();
            this.buttonCrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.openFileDialogChose = new System.Windows.Forms.OpenFileDialog();
            this.textBoxInteractive = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChose
            // 
            this.buttonChose.Location = new System.Drawing.Point(169, 398);
            this.buttonChose.Name = "buttonChose";
            this.buttonChose.Size = new System.Drawing.Size(75, 23);
            this.buttonChose.TabIndex = 0;
            this.buttonChose.Text = "Chose file";
            this.buttonChose.UseVisualStyleBackColor = true;
            this.buttonChose.Click += new System.EventHandler(this.buttonChose_Click);
            // 
            // buttonCrypt
            // 
            this.buttonCrypt.Location = new System.Drawing.Point(303, 398);
            this.buttonCrypt.Name = "buttonCrypt";
            this.buttonCrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonCrypt.TabIndex = 1;
            this.buttonCrypt.Text = "Encrypt";
            this.buttonCrypt.UseVisualStyleBackColor = true;
            this.buttonCrypt.Click += new System.EventHandler(this.buttonCrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(456, 398);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 2;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // openFileDialogChose
            // 
            this.openFileDialogChose.FileName = "openFileDialogChose";
            this.openFileDialogChose.Filter = "\"Images (*.jpg; *.png; *.jpeg) |*.jpg; *.png; *.jpeg\"";
            // 
            // textBoxInteractive
            // 
            this.textBoxInteractive.Location = new System.Drawing.Point(126, 61);
            this.textBoxInteractive.Multiline = true;
            this.textBoxInteractive.Name = "textBoxInteractive";
            this.textBoxInteractive.ReadOnly = true;
            this.textBoxInteractive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInteractive.Size = new System.Drawing.Size(233, 297);
            this.textBoxInteractive.TabIndex = 3;
            this.textBoxInteractive.TextChanged += new System.EventHandler(this.textBoxInteractive_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(47, 398);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(404, 270);
            this.textBoxURL.Multiline = true;
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(251, 56);
            this.textBoxURL.TabIndex = 7;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(404, 239);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(120, 13);
            this.labelURL.TabIndex = 8;
            this.labelURL.Text = "Enter your URL-address";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(404, 343);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 9;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 457);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxInteractive);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonCrypt);
            this.Controls.Add(this.buttonChose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChose;
        private System.Windows.Forms.Button buttonCrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialogChose;
        private System.Windows.Forms.TextBox textBoxInteractive;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Button buttonDownload;
    }
}

