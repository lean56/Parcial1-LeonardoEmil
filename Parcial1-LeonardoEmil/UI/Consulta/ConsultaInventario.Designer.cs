namespace Parcial1_LeonardoEmil.UI.Consulta
{
    partial class ConsultaInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TotalInventarionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TotalInventarionumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Inventario";
            // 
            // TotalInventarionumericUpDown
            // 
            this.TotalInventarionumericUpDown.Location = new System.Drawing.Point(125, 54);
            this.TotalInventarionumericUpDown.Name = "TotalInventarionumericUpDown";
            this.TotalInventarionumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.TotalInventarionumericUpDown.TabIndex = 1;
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Location = new System.Drawing.Point(128, 128);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(75, 23);
            this.Actualizarbutton.TabIndex = 2;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            // 
            // ConsultaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 271);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.TotalInventarionumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaInventario";
            this.Text = "ConsultaInventario";
            ((System.ComponentModel.ISupportInitialize)(this.TotalInventarionumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TotalInventarionumericUpDown;
        private System.Windows.Forms.Button Actualizarbutton;
    }
}