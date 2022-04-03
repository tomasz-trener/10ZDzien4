
namespace P04AplikacjaOkienkowa
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
            this.btnNacisnijMnie = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNacisnijMnie
            // 
            this.btnNacisnijMnie.Location = new System.Drawing.Point(129, 29);
            this.btnNacisnijMnie.Name = "btnNacisnijMnie";
            this.btnNacisnijMnie.Size = new System.Drawing.Size(109, 66);
            this.btnNacisnijMnie.TabIndex = 0;
            this.btnNacisnijMnie.Text = "Naciśnij mnie";
            this.btnNacisnijMnie.UseVisualStyleBackColor = true;
            this.btnNacisnijMnie.Click += new System.EventHandler(this.btnNacisnijMnie_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(296, 53);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(158, 20);
            this.txtImie.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.btnNacisnijMnie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNacisnijMnie;
        private System.Windows.Forms.TextBox txtImie;
    }
}

