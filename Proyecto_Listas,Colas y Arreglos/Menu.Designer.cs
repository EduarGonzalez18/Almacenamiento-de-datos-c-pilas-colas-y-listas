namespace Proyecto_Listas_Colas_y_Arreglos
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.Cola = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft JhengHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(413, 37);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(457, 60);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Menu De Opciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnPila);
            this.panel1.Controls.Add(this.Cola);
            this.panel1.Controls.Add(this.Lista);
            this.panel1.Location = new System.Drawing.Point(186, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 655);
            this.panel1.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(422, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 67);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPila
            // 
            this.btnPila.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPila.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPila.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPila.ForeColor = System.Drawing.Color.Transparent;
            this.btnPila.Location = new System.Drawing.Point(136, 209);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(162, 67);
            this.btnPila.TabIndex = 9;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = false;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // Cola
            // 
            this.Cola.BackColor = System.Drawing.Color.DarkGreen;
            this.Cola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cola.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cola.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cola.ForeColor = System.Drawing.Color.Transparent;
            this.Cola.Location = new System.Drawing.Point(422, 209);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(162, 67);
            this.Cola.TabIndex = 8;
            this.Cola.Text = "cola";
            this.Cola.UseVisualStyleBackColor = false;
            this.Cola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.Color.DarkGreen;
            this.Lista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Lista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Lista.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.ForeColor = System.Drawing.Color.Transparent;
            this.Lista.Location = new System.Drawing.Point(744, 209);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(162, 67);
            this.Lista.TabIndex = 7;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = false;
            this.Lista.Click += new System.EventHandler(this.Lista_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Location = new System.Drawing.Point(-7, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 131);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1217, 734);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnPila;
        public System.Windows.Forms.Button Cola;
        public System.Windows.Forms.Button Lista;
        private System.Windows.Forms.Panel panel2;
    }
}