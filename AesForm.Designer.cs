namespace WindowsFormsApplication1
{
    partial class AesForm
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
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.KeyFile = new System.Windows.Forms.Label();
            this.InputFile = new System.Windows.Forms.Label();
            this.OutputFile = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonOpenKey = new System.Windows.Forms.Button();
            this.buttonOpenInput = new System.Windows.Forms.Button();
            this.buttonOpenOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(162, 70);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // KeyFile
            // 
            this.KeyFile.AutoSize = true;
            this.KeyFile.Location = new System.Drawing.Point(31, 27);
            this.KeyFile.Name = "KeyFile";
            this.KeyFile.Size = new System.Drawing.Size(47, 13);
            this.KeyFile.TabIndex = 1;
            this.KeyFile.Text = "Key File:";
            // 
            // InputFile
            // 
            this.InputFile.AutoSize = true;
            this.InputFile.Location = new System.Drawing.Point(31, 80);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(53, 13);
            this.InputFile.TabIndex = 3;
            this.InputFile.Text = "Input File:";
            // 
            // OutputFile
            // 
            this.OutputFile.AutoSize = true;
            this.OutputFile.Location = new System.Drawing.Point(31, 137);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(61, 13);
            this.OutputFile.TabIndex = 5;
            this.OutputFile.Text = "Output File:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(162, 126);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonOpenKey
            // 
            this.buttonOpenKey.Location = new System.Drawing.Point(34, 44);
            this.buttonOpenKey.Name = "buttonOpenKey";
            this.buttonOpenKey.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenKey.TabIndex = 8;
            this.buttonOpenKey.Text = "Open";
            this.buttonOpenKey.UseVisualStyleBackColor = true;
            this.buttonOpenKey.Click += new System.EventHandler(this.buttonOpenKey_Click);
            // 
            // buttonOpenInput
            // 
            this.buttonOpenInput.Location = new System.Drawing.Point(34, 97);
            this.buttonOpenInput.Name = "buttonOpenInput";
            this.buttonOpenInput.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenInput.TabIndex = 9;
            this.buttonOpenInput.Text = "Open";
            this.buttonOpenInput.UseVisualStyleBackColor = true;
            this.buttonOpenInput.Click += new System.EventHandler(this.buttonOpenInput_Click);
            // 
            // buttonOpenOutput
            // 
            this.buttonOpenOutput.Location = new System.Drawing.Point(34, 154);
            this.buttonOpenOutput.Name = "buttonOpenOutput";
            this.buttonOpenOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenOutput.TabIndex = 10;
            this.buttonOpenOutput.Text = "Open";
            this.buttonOpenOutput.UseVisualStyleBackColor = true;
            this.buttonOpenOutput.Click += new System.EventHandler(this.buttonOpenOutput_Click);
            // 
            // AesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 226);
            this.Controls.Add(this.buttonOpenOutput);
            this.Controls.Add(this.buttonOpenInput);
            this.Controls.Add(this.buttonOpenKey);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.OutputFile);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.KeyFile);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "AesForm";
            this.Text = "AES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label KeyFile;
        private System.Windows.Forms.Label InputFile;
        private System.Windows.Forms.Label OutputFile;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonOpenKey;
        private System.Windows.Forms.Button buttonOpenInput;
        private System.Windows.Forms.Button buttonOpenOutput;
    }
}

