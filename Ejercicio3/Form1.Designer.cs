namespace Ejercicio3
{
    partial class Form1
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGrande = new System.Windows.Forms.TextBox();
            this.txtPequeño = new System.Windows.Forms.TextBox();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.btnMatar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblerrores = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtGrande
            // 
            this.txtGrande.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrande.Location = new System.Drawing.Point(39, 42);
            this.txtGrande.Multiline = true;
            this.txtGrande.Name = "txtGrande";
            this.txtGrande.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGrande.Size = new System.Drawing.Size(595, 299);
            this.txtGrande.TabIndex = 0;
            this.txtGrande.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPequeño
            // 
            this.txtPequeño.Location = new System.Drawing.Point(39, 368);
            this.txtPequeño.Name = "txtPequeño";
            this.txtPequeño.Size = new System.Drawing.Size(100, 20);
            this.txtPequeño.TabIndex = 1;
            // 
            // btnProcesos
            // 
            this.btnProcesos.Location = new System.Drawing.Point(161, 366);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(75, 23);
            this.btnProcesos.TabIndex = 2;
            this.btnProcesos.Text = "ViewProcess";
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.procesos);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(242, 366);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Procces info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.info);
            // 
            // btnCierre
            // 
            this.btnCierre.Location = new System.Drawing.Point(323, 365);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(86, 23);
            this.btnCierre.TabIndex = 4;
            this.btnCierre.Text = "Close process";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.cerrar);
            // 
            // btnMatar
            // 
            this.btnMatar.Location = new System.Drawing.Point(415, 365);
            this.btnMatar.Name = "btnMatar";
            this.btnMatar.Size = new System.Drawing.Size(75, 23);
            this.btnMatar.TabIndex = 5;
            this.btnMatar.Text = "Kill process";
            this.btnMatar.UseVisualStyleBackColor = true;
            this.btnMatar.Click += new System.EventHandler(this.matar);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(496, 365);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Run App";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.iniciar);
            // 
            // lblerrores
            // 
            this.lblerrores.AutoSize = true;
            this.lblerrores.Location = new System.Drawing.Point(39, 413);
            this.lblerrores.Name = "lblerrores";
            this.lblerrores.Size = new System.Drawing.Size(0, 13);
            this.lblerrores.TabIndex = 7;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(578, 365);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "Stars With…";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.busqueda);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lblerrores);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnMatar);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnProcesos);
            this.Controls.Add(this.txtPequeño);
            this.Controls.Add(this.txtGrande);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrande;
        private System.Windows.Forms.TextBox txtPequeño;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Button btnMatar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblerrores;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

