namespace CAPA_PRESENTACION {
    partial class LOGIN {
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
            this.btn_INGRESAR = new FontAwesome.Sharp.IconButton();
            this.btn_CANCELAR = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_USUARIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CONTRASENIA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_INGRESAR
            // 
            this.btn_INGRESAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_INGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_INGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INGRESAR.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_INGRESAR.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_INGRESAR.IconColor = System.Drawing.Color.White;
            this.btn_INGRESAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_INGRESAR.IconSize = 21;
            this.btn_INGRESAR.Location = new System.Drawing.Point(356, 262);
            this.btn_INGRESAR.Name = "btn_INGRESAR";
            this.btn_INGRESAR.Size = new System.Drawing.Size(149, 44);
            this.btn_INGRESAR.TabIndex = 8;
            this.btn_INGRESAR.Text = "INGRESAR";
            this.btn_INGRESAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_INGRESAR.UseVisualStyleBackColor = false;
            this.btn_INGRESAR.Click += new System.EventHandler(this.btn_INGRESAR_Click);
            // 
            // btn_CANCELAR
            // 
            this.btn_CANCELAR.BackColor = System.Drawing.Color.Firebrick;
            this.btn_CANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CANCELAR.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_CANCELAR.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_CANCELAR.IconColor = System.Drawing.Color.White;
            this.btn_CANCELAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CANCELAR.IconSize = 21;
            this.btn_CANCELAR.Location = new System.Drawing.Point(546, 262);
            this.btn_CANCELAR.Name = "btn_CANCELAR";
            this.btn_CANCELAR.Size = new System.Drawing.Size(144, 44);
            this.btn_CANCELAR.TabIndex = 9;
            this.btn_CANCELAR.Text = "CANCELAR";
            this.btn_CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CANCELAR.UseVisualStyleBackColor = false;
            this.btn_CANCELAR.Click += new System.EventHandler(this.btn_CANCELAR_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 450);
            this.label1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(383, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "INGRESE EL NOMBRE";
            // 
            // txt_USUARIO
            // 
            this.txt_USUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_USUARIO.Location = new System.Drawing.Point(387, 103);
            this.txt_USUARIO.Name = "txt_USUARIO";
            this.txt_USUARIO.Size = new System.Drawing.Size(303, 27);
            this.txt_USUARIO.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(383, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "CONTRASEÑA";
            // 
            // txt_CONTRASENIA
            // 
            this.txt_CONTRASENIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CONTRASENIA.Location = new System.Drawing.Point(387, 187);
            this.txt_CONTRASENIA.Name = "txt_CONTRASENIA";
            this.txt_CONTRASENIA.PasswordChar = '*';
            this.txt_CONTRASENIA.Size = new System.Drawing.Size(303, 27);
            this.txt_CONTRASENIA.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "SISTEMA DE VENTAS";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 151;
            this.iconPictureBox1.Location = new System.Drawing.Point(63, 89);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(161, 151);
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CONTRASENIA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_USUARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CANCELAR);
            this.Controls.Add(this.btn_INGRESAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_INGRESAR;
        private FontAwesome.Sharp.IconButton btn_CANCELAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_USUARIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CONTRASENIA;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}