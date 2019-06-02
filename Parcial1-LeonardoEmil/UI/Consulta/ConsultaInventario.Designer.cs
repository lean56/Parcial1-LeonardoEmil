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
            this.ValorInventariodataGridView = new System.Windows.Forms.DataGridView();
            this.ValorInventariotextBox = new System.Windows.Forms.TextBox();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValorInventariodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Inventario:";
            // 
            // ValorInventariodataGridView
            // 
            this.ValorInventariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ValorInventariodataGridView.Location = new System.Drawing.Point(322, 266);
            this.ValorInventariodataGridView.Name = "ValorInventariodataGridView";
            this.ValorInventariodataGridView.Size = new System.Drawing.Size(10, 10);
            this.ValorInventariodataGridView.TabIndex = 3;
            this.ValorInventariodataGridView.Visible = false;
            // 
            // ValorInventariotextBox
            // 
            this.ValorInventariotextBox.Enabled = false;
            this.ValorInventariotextBox.Location = new System.Drawing.Point(103, 84);
            this.ValorInventariotextBox.Name = "ValorInventariotextBox";
            this.ValorInventariotextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorInventariotextBox.TabIndex = 4;
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Image = global::Parcial1_LeonardoEmil.Properties.Resources.system_software_update_22485;
            this.Actualizarbutton.Location = new System.Drawing.Point(119, 123);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(73, 69);
            this.Actualizarbutton.TabIndex = 2;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // ConsultaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 271);
            this.Controls.Add(this.ValorInventariotextBox);
            this.Controls.Add(this.ValorInventariodataGridView);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaInventario";
            this.Text = "Consulta Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.ValorInventariodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ValorInventariodataGridView;
        public System.Windows.Forms.Button Actualizarbutton;
        public System.Windows.Forms.TextBox ValorInventariotextBox;
    }
}