namespace CAPA_PRESENTACION {
    partial class INICIO {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MENU_USUARIO = new FontAwesome.Sharp.IconMenuItem();
            this.MENU_MANTENEDOR = new FontAwesome.Sharp.IconMenuItem();
            this.MENU_VENTAS = new FontAwesome.Sharp.IconMenuItem();
            this.MENU_COMPRAS = new FontAwesome.Sharp.IconMenuItem();
            this.MENU_CLIENTE = new FontAwesome.Sharp.IconMenuItem();
            this.MENU_PROVEEDOR = new FontAwesome.Sharp.IconMenuItem();
            this.MENU_REPORTE = new FontAwesome.Sharp.IconMenuItem();
            this.MENU_ACERCADE = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            this.CONTENEDOR = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1154, 64);
            this.menuTitulo.TabIndex = 0;
            this.menuTitulo.Text = "menuStrip1";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTitulo_ItemClicked);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_USUARIO,
            this.MENU_MANTENEDOR,
            this.MENU_VENTAS,
            this.MENU_COMPRAS,
            this.MENU_CLIENTE,
            this.MENU_PROVEEDOR,
            this.MENU_REPORTE,
            this.MENU_ACERCADE});
            this.menu.Location = new System.Drawing.Point(0, 64);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1154, 78);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // MENU_USUARIO
            // 
            this.MENU_USUARIO.AutoSize = false;
            this.MENU_USUARIO.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.MENU_USUARIO.IconColor = System.Drawing.Color.Black;
            this.MENU_USUARIO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_USUARIO.IconSize = 50;
            this.MENU_USUARIO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_USUARIO.Name = "MENU_USUARIO";
            this.MENU_USUARIO.Size = new System.Drawing.Size(80, 74);
            this.MENU_USUARIO.Text = "USUARIO";
            this.MENU_USUARIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MENU_MANTENEDOR
            // 
            this.MENU_MANTENEDOR.AutoSize = false;
            this.MENU_MANTENEDOR.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MENU_MANTENEDOR.IconColor = System.Drawing.Color.Black;
            this.MENU_MANTENEDOR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_MANTENEDOR.IconSize = 50;
            this.MENU_MANTENEDOR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_MANTENEDOR.Name = "MENU_MANTENEDOR";
            this.MENU_MANTENEDOR.Size = new System.Drawing.Size(152, 74);
            this.MENU_MANTENEDOR.Text = "MANTENEDOR";
            this.MENU_MANTENEDOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MENU_VENTAS
            // 
            this.MENU_VENTAS.AutoSize = false;
            this.MENU_VENTAS.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.MENU_VENTAS.IconColor = System.Drawing.Color.Black;
            this.MENU_VENTAS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_VENTAS.IconSize = 50;
            this.MENU_VENTAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_VENTAS.Name = "MENU_VENTAS";
            this.MENU_VENTAS.Size = new System.Drawing.Size(152, 74);
            this.MENU_VENTAS.Text = "VENTAS";
            this.MENU_VENTAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MENU_COMPRAS
            // 
            this.MENU_COMPRAS.AutoSize = false;
            this.MENU_COMPRAS.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.MENU_COMPRAS.IconColor = System.Drawing.Color.Black;
            this.MENU_COMPRAS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_COMPRAS.IconSize = 50;
            this.MENU_COMPRAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_COMPRAS.Name = "MENU_COMPRAS";
            this.MENU_COMPRAS.Size = new System.Drawing.Size(152, 74);
            this.MENU_COMPRAS.Text = "COMPRAS";
            this.MENU_COMPRAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MENU_CLIENTE
            // 
            this.MENU_CLIENTE.AutoSize = false;
            this.MENU_CLIENTE.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MENU_CLIENTE.IconColor = System.Drawing.Color.Black;
            this.MENU_CLIENTE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_CLIENTE.IconSize = 50;
            this.MENU_CLIENTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_CLIENTE.Name = "MENU_CLIENTE";
            this.MENU_CLIENTE.Size = new System.Drawing.Size(152, 74);
            this.MENU_CLIENTE.Text = "CLIENTE";
            this.MENU_CLIENTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MENU_PROVEEDOR
            // 
            this.MENU_PROVEEDOR.AutoSize = false;
            this.MENU_PROVEEDOR.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MENU_PROVEEDOR.IconColor = System.Drawing.Color.Black;
            this.MENU_PROVEEDOR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_PROVEEDOR.IconSize = 50;
            this.MENU_PROVEEDOR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_PROVEEDOR.Name = "MENU_PROVEEDOR";
            this.MENU_PROVEEDOR.Size = new System.Drawing.Size(152, 74);
            this.MENU_PROVEEDOR.Text = "PROVEEDOR";
            this.MENU_PROVEEDOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MENU_REPORTE
            // 
            this.MENU_REPORTE.AutoSize = false;
            this.MENU_REPORTE.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.MENU_REPORTE.IconColor = System.Drawing.Color.Black;
            this.MENU_REPORTE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_REPORTE.IconSize = 50;
            this.MENU_REPORTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_REPORTE.Name = "MENU_REPORTE";
            this.MENU_REPORTE.Size = new System.Drawing.Size(152, 74);
            this.MENU_REPORTE.Text = "REPORTE";
            this.MENU_REPORTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MENU_ACERCADE
            // 
            this.MENU_ACERCADE.AutoSize = false;
            this.MENU_ACERCADE.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MENU_ACERCADE.IconColor = System.Drawing.Color.Black;
            this.MENU_ACERCADE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENU_ACERCADE.IconSize = 50;
            this.MENU_ACERCADE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENU_ACERCADE.Name = "MENU_ACERCADE";
            this.MENU_ACERCADE.Size = new System.Drawing.Size(152, 74);
            this.MENU_ACERCADE.Text = "ACERCA DE...";
            this.MENU_ACERCADE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEMA DE VENTAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // iconToolStripButton2
            // 
            this.iconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconToolStripButton2.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton2.Name = "iconToolStripButton2";
            this.iconToolStripButton2.Size = new System.Drawing.Size(23, 23);
            this.iconToolStripButton2.Text = "iconToolStripButton2";
            // 
            // CONTENEDOR
            // 
            this.CONTENEDOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CONTENEDOR.Location = new System.Drawing.Point(0, 142);
            this.CONTENEDOR.Name = "CONTENEDOR";
            this.CONTENEDOR.Size = new System.Drawing.Size(1154, 453);
            this.CONTENEDOR.TabIndex = 4;
            this.CONTENEDOR.Paint += new System.Windows.Forms.PaintEventHandler(this.CONTENEDOR_Paint);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 595);
            this.Controls.Add(this.CONTENEDOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "INICIO";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem MENU_USUARIO;
        private FontAwesome.Sharp.IconMenuItem MENU_VENTAS;
        private FontAwesome.Sharp.IconMenuItem MENU_MANTENEDOR;
        private FontAwesome.Sharp.IconMenuItem MENU_COMPRAS;
        private FontAwesome.Sharp.IconMenuItem MENU_CLIENTE;
        private FontAwesome.Sharp.IconMenuItem MENU_PROVEEDOR;
        private FontAwesome.Sharp.IconMenuItem MENU_REPORTE;
        private FontAwesome.Sharp.IconMenuItem MENU_ACERCADE;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton2;
        private System.Windows.Forms.Panel CONTENEDOR;
    }
}

