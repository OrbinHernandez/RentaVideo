namespace Capa_Presentacion
{
    partial class Menu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.BtnRentas = new System.Windows.Forms.Button();
            this.BtnPeliculas = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.BtnRentas);
            this.pnlMenu.Controls.Add(this.BtnPeliculas);
            this.pnlMenu.Controls.Add(this.BtnClientes);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 493);
            this.pnlMenu.TabIndex = 0;
            // 
            // BtnRentas
            // 
            this.BtnRentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRentas.FlatAppearance.BorderSize = 0;
            this.BtnRentas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRentas.Image = global::Capa_Presentacion.Properties.Resources.Documentary;
            this.BtnRentas.Location = new System.Drawing.Point(0, 243);
            this.BtnRentas.Name = "BtnRentas";
            this.BtnRentas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnRentas.Size = new System.Drawing.Size(200, 52);
            this.BtnRentas.TabIndex = 3;
            this.BtnRentas.Text = "Rentas";
            this.BtnRentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRentas.UseVisualStyleBackColor = true;
            this.BtnRentas.Click += new System.EventHandler(this.BtnRentas_Click);
            // 
            // BtnPeliculas
            // 
            this.BtnPeliculas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPeliculas.FlatAppearance.BorderSize = 0;
            this.BtnPeliculas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPeliculas.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeliculas.Image = global::Capa_Presentacion.Properties.Resources.Cinema;
            this.BtnPeliculas.Location = new System.Drawing.Point(0, 191);
            this.BtnPeliculas.Name = "BtnPeliculas";
            this.BtnPeliculas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnPeliculas.Size = new System.Drawing.Size(200, 52);
            this.BtnPeliculas.TabIndex = 2;
            this.BtnPeliculas.Text = "Peliculas";
            this.BtnPeliculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPeliculas.UseVisualStyleBackColor = true;
            this.BtnPeliculas.Click += new System.EventHandler(this.BtnPeliculas_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.Image = global::Capa_Presentacion.Properties.Resources.People1;
            this.BtnClientes.Location = new System.Drawing.Point(0, 139);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnClientes.Size = new System.Drawing.Size(200, 52);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PtbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 139);
            this.panel1.TabIndex = 1;
            // 
            // PtbLogo
            // 
            this.PtbLogo.Image = global::Capa_Presentacion.Properties.Resources.GitHub;
            this.PtbLogo.Location = new System.Drawing.Point(49, 14);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(100, 100);
            this.PtbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLogo.TabIndex = 2;
            this.PtbLogo.TabStop = false;
            this.PtbLogo.Click += new System.EventHandler(this.PtbLogo_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(719, 493);
            this.pnlContenedor.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(919, 493);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.PictureBox PtbLogo;
        private System.Windows.Forms.Button BtnRentas;
        private System.Windows.Forms.Button BtnPeliculas;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}