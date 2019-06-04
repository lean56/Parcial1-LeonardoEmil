namespace Parcial1_LeonardoEmil
{
    partial class Principal
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BarraPanel = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.IconoMax = new System.Windows.Forms.PictureBox();
            this.IconoRest = new System.Windows.Forms.PictureBox();
            this.IconoMin = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.HideButton = new System.Windows.Forms.PictureBox();
            this.Productosbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.BarraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.Productosbutton);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(146, 450);
            this.MenuVertical.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Parcial1_LeonardoEmil.Properties.Resources.pagos;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inventario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BarraPanel
            // 
            this.BarraPanel.Controls.Add(this.IconoMax);
            this.BarraPanel.Controls.Add(this.IconoRest);
            this.BarraPanel.Controls.Add(this.IconoMin);
            this.BarraPanel.Controls.Add(this.IconoCerrar);
            this.BarraPanel.Controls.Add(this.HideButton);
            this.BarraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraPanel.Location = new System.Drawing.Point(146, 0);
            this.BarraPanel.Name = "BarraPanel";
            this.BarraPanel.Size = new System.Drawing.Size(654, 50);
            this.BarraPanel.TabIndex = 1;
            this.BarraPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraPanel_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(146, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(654, 400);
            this.panelContenedor.TabIndex = 2;
            // 
            // IconoMax
            // 
            this.IconoMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMax.Image = global::Parcial1_LeonardoEmil.Properties.Resources.icon_maximizar;
            this.IconoMax.Location = new System.Drawing.Point(584, 12);
            this.IconoMax.Name = "IconoMax";
            this.IconoMax.Size = new System.Drawing.Size(20, 20);
            this.IconoMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMax.TabIndex = 0;
            this.IconoMax.TabStop = false;
            this.IconoMax.Click += new System.EventHandler(this.IconoMax_Click);
            // 
            // IconoRest
            // 
            this.IconoRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoRest.Image = global::Parcial1_LeonardoEmil.Properties.Resources.icon_restaurar;
            this.IconoRest.Location = new System.Drawing.Point(584, 12);
            this.IconoRest.Name = "IconoRest";
            this.IconoRest.Size = new System.Drawing.Size(20, 20);
            this.IconoRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoRest.TabIndex = 3;
            this.IconoRest.TabStop = false;
            this.IconoRest.Click += new System.EventHandler(this.IconoRest_Click);
            // 
            // IconoMin
            // 
            this.IconoMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMin.Image = global::Parcial1_LeonardoEmil.Properties.Resources.icon_minimizar;
            this.IconoMin.Location = new System.Drawing.Point(558, 12);
            this.IconoMin.Name = "IconoMin";
            this.IconoMin.Size = new System.Drawing.Size(20, 20);
            this.IconoMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMin.TabIndex = 2;
            this.IconoMin.TabStop = false;
            this.IconoMin.Click += new System.EventHandler(this.IconoMin_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoCerrar.Image = global::Parcial1_LeonardoEmil.Properties.Resources.icon_cerrar2;
            this.IconoCerrar.Location = new System.Drawing.Point(610, 12);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 1;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // HideButton
            // 
            this.HideButton.Image = global::Parcial1_LeonardoEmil.Properties.Resources.Mobile_Menu_Icon;
            this.HideButton.Location = new System.Drawing.Point(6, 3);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(35, 35);
            this.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HideButton.TabIndex = 0;
            this.HideButton.TabStop = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // Productosbutton
            // 
            this.Productosbutton.FlatAppearance.BorderSize = 0;
            this.Productosbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Productosbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productosbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Productosbutton.Image = global::Parcial1_LeonardoEmil.Properties.Resources.producto;
            this.Productosbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productosbutton.Location = new System.Drawing.Point(0, 112);
            this.Productosbutton.Name = "Productosbutton";
            this.Productosbutton.Size = new System.Drawing.Size(146, 40);
            this.Productosbutton.TabIndex = 1;
            this.Productosbutton.Text = "Productos";
            this.Productosbutton.UseVisualStyleBackColor = true;
            this.Productosbutton.Click += new System.EventHandler(this.Productosbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraPanel);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.MenuVertical.ResumeLayout(false);
            this.BarraPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraPanel;
        private System.Windows.Forms.PictureBox HideButton;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox IconoRest;
        private System.Windows.Forms.PictureBox IconoMin;
        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.PictureBox IconoMax;
        private System.Windows.Forms.Button Productosbutton;
        private System.Windows.Forms.Button button2;
    }
}