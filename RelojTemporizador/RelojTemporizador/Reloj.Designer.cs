
namespace RelojTemporizador
{
    partial class Reloj
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
            this.lblHora = new System.Windows.Forms.Label();
            this.btnIniciarReloj = new System.Windows.Forms.Button();
            this.btnDetenerReloj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(196, 58);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // btnIniciarReloj
            // 
            this.btnIniciarReloj.Location = new System.Drawing.Point(328, 32);
            this.btnIniciarReloj.Name = "btnIniciarReloj";
            this.btnIniciarReloj.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarReloj.TabIndex = 1;
            this.btnIniciarReloj.Text = "Iniciar Reloj";
            this.btnIniciarReloj.UseVisualStyleBackColor = true;
            this.btnIniciarReloj.Click += new System.EventHandler(this.btnIniciarReloj_Click_1);
            // 
            // btnDetenerReloj
            // 
            this.btnDetenerReloj.Location = new System.Drawing.Point(328, 75);
            this.btnDetenerReloj.Name = "btnDetenerReloj";
            this.btnDetenerReloj.Size = new System.Drawing.Size(75, 23);
            this.btnDetenerReloj.TabIndex = 2;
            this.btnDetenerReloj.Text = "Detener Reloj";
            this.btnDetenerReloj.UseVisualStyleBackColor = true;
            this.btnDetenerReloj.Click += new System.EventHandler(this.btnDetenerReloj_Click_1);
            // 
            // Reloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 126);
            this.Controls.Add(this.btnDetenerReloj);
            this.Controls.Add(this.btnIniciarReloj);
            this.Controls.Add(this.lblHora);
            this.Name = "Reloj";
            this.Text = "Mi Reloj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnIniciarReloj;
        private System.Windows.Forms.Button btnDetenerReloj;
    }
}

