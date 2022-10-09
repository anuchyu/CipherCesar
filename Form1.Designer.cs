namespace CipherCesar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.encoded = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.textIn = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encoded
            // 
            this.encoded.Location = new System.Drawing.Point(12, 33);
            this.encoded.Name = "encoded";
            this.encoded.Size = new System.Drawing.Size(109, 23);
            this.encoded.TabIndex = 0;
            this.encoded.Text = "шифровать";
            this.encoded.UseVisualStyleBackColor = true;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(247, 33);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(132, 23);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "дешифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.button4_Click);
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(12, 62);
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(176, 20);
            this.textIn.TabIndex = 2;
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(194, 62);
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(185, 20);
            this.textOut.TabIndex = 3;
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(127, 33);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(114, 20);
            this.step.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(389, 148);
            this.Controls.Add(this.step);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encoded);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encoded;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox textInCode;
        private System.Windows.Forms.TextBox textOutCode;
        private System.Windows.Forms.TextBox stepCode;
    }
}

