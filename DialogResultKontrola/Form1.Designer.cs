namespace DialogResultKontrola
{
    partial class FormDialogResult
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
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(289, 63);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(157, 31);
            this.buttonOtvori.TabIndex = 0;
            this.buttonOtvori.Text = "Otvori MessageBox";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(78, 158);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(628, 234);
            this.textBoxRezultat.TabIndex = 1;
            this.textBoxRezultat.Text = "";
            this.textBoxRezultat.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FormDialogResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonOtvori);
            this.Name = "FormDialogResult";
            this.Text = "Upotreba DialogResult enumeracije";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOtvori;
        private System.Windows.Forms.RichTextBox textBoxRezultat;
    }
}

