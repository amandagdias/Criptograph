namespace Criptografia
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
            this.btn_crip = new System.Windows.Forms.Button();
            this.btn_dec = new System.Windows.Forms.Button();
            this.txt_phrase = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_crip
            // 
            this.btn_crip.Location = new System.Drawing.Point(12, 98);
            this.btn_crip.Name = "btn_crip";
            this.btn_crip.Size = new System.Drawing.Size(127, 23);
            this.btn_crip.TabIndex = 0;
            this.btn_crip.Text = "Criptografar";
            this.btn_crip.UseVisualStyleBackColor = true;
            this.btn_crip.Click += new System.EventHandler(this.btn_crip_Click);
            // 
            // btn_dec
            // 
            this.btn_dec.Location = new System.Drawing.Point(145, 98);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(127, 23);
            this.btn_dec.TabIndex = 1;
            this.btn_dec.Text = "Decriptografar";
            this.btn_dec.UseMnemonic = false;
            this.btn_dec.UseVisualStyleBackColor = true;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // txt_phrase
            // 
            this.txt_phrase.Location = new System.Drawing.Point(12, 33);
            this.txt_phrase.Name = "txt_phrase";
            this.txt_phrase.Size = new System.Drawing.Size(260, 20);
            this.txt_phrase.TabIndex = 2;
            this.txt_phrase.Text = "dêqduxjhV#8#hgdglylwD";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txt_phrase);
            this.Controls.Add(this.btn_dec);
            this.Controls.Add(this.btn_crip);
            this.Name = "Form1";
            this.Text = "Criptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crip;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.TextBox txt_phrase;
        private System.Windows.Forms.Label label;
    }
}

