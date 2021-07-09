
namespace Divisas_Pesos_A_Dolares
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.TextBoxPesos = new System.Windows.Forms.TextBox();
            this.TextBoxDolares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Conversor = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(171, 87);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(471, 55);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Convertidor de Divisas";
            // 
            // TextBoxPesos
            // 
            this.TextBoxPesos.Location = new System.Drawing.Point(325, 242);
            this.TextBoxPesos.Name = "TextBoxPesos";
            this.TextBoxPesos.Size = new System.Drawing.Size(168, 23);
            this.TextBoxPesos.TabIndex = 1;
            this.TextBoxPesos.TextChanged += new System.EventHandler(this.TextBoxPesos_TextChanged);
            // 
            // TextBoxDolares
            // 
            this.TextBoxDolares.Location = new System.Drawing.Point(325, 185);
            this.TextBoxDolares.Name = "TextBoxDolares";
            this.TextBoxDolares.Size = new System.Drawing.Size(165, 23);
            this.TextBoxDolares.TabIndex = 2;
            this.TextBoxDolares.TextChanged += new System.EventHandler(this.TextBoxDolares_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesos Mexicanos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dolares";
            // 
            // Conversor
            // 
            this.Conversor.Location = new System.Drawing.Point(312, 310);
            this.Conversor.Name = "Conversor";
            this.Conversor.Size = new System.Drawing.Size(87, 42);
            this.Conversor.TabIndex = 5;
            this.Conversor.Text = "Convertir";
            this.Conversor.UseVisualStyleBackColor = true;
            this.Conversor.Click += new System.EventHandler(this.Conversor_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(438, 310);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(78, 42);
            this.Clean.TabIndex = 6;
            this.Clean.Text = "Limpiar";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Conversor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxDolares);
            this.Controls.Add(this.TextBoxPesos);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TextBoxPesos;
        private System.Windows.Forms.TextBox TextBoxDolares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Conversor;
        private System.Windows.Forms.Button Clean;
    }
}

