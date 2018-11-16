namespace Prueba2
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
            this.lbresspuesta = new System.Windows.Forms.Label();
            this.dgCanciones = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbresspuesta
            // 
            this.lbresspuesta.AutoSize = true;
            this.lbresspuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresspuesta.Location = new System.Drawing.Point(167, 241);
            this.lbresspuesta.Name = "lbresspuesta";
            this.lbresspuesta.Size = new System.Drawing.Size(0, 31);
            this.lbresspuesta.TabIndex = 3;
            // 
            // dgCanciones
            // 
            this.dgCanciones.AllowUserToAddRows = false;
            this.dgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3});
            this.dgCanciones.Location = new System.Drawing.Point(42, 39);
            this.dgCanciones.Name = "dgCanciones";
            this.dgCanciones.ReadOnly = true;
            this.dgCanciones.Size = new System.Drawing.Size(350, 150);
            this.dgCanciones.TabIndex = 2;
            this.dgCanciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCanciones_CellDoubleClick);
            // 
            // C1
            // 
            this.C1.HeaderText = "CANCION 1";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            // 
            // C2
            // 
            this.C2.HeaderText = "CANCION 2";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            // 
            // C3
            // 
            this.C3.HeaderText = "CANCION 3";
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jean Piloso ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba2.Properties.Resources._73955_1;
            this.ClientSize = new System.Drawing.Size(821, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbresspuesta);
            this.Controls.Add(this.dgCanciones);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbresspuesta;
        private System.Windows.Forms.DataGridView dgCanciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Label label1;
    }
}

