
namespace P07ZadaniePogoda
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
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.pcObrazek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(12, 12);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(146, 21);
            this.cbMiasta.TabIndex = 0;
            this.cbMiasta.SelectedIndexChanged += new System.EventHandler(this.cbMiasta_SelectedIndexChanged);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(164, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(26, 53);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(35, 13);
            this.lblTemperatura.TabIndex = 2;
            this.lblTemperatura.Text = "label1";
            // 
            // pcObrazek
            // 
            this.pcObrazek.Image = global::P07ZadaniePogoda.Properties.Resources.cloud;
            this.pcObrazek.Location = new System.Drawing.Point(12, 79);
            this.pcObrazek.Name = "pcObrazek";
            this.pcObrazek.Size = new System.Drawing.Size(88, 58);
            this.pcObrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcObrazek.TabIndex = 3;
            this.pcObrazek.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 161);
            this.Controls.Add(this.pcObrazek);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.cbMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcObrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.PictureBox pcObrazek;
    }
}

