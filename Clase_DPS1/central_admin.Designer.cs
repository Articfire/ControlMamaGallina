namespace Clase_DPS1
{
    partial class central_admin
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
            this.btn_e = new System.Windows.Forms.Button();
            this.btn_a = new System.Windows.Forms.Button();
            this.dgv_tareas = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_e
            // 
            this.btn_e.BackColor = System.Drawing.Color.Orange;
            this.btn_e.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_e.Location = new System.Drawing.Point(346, 533);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(254, 59);
            this.btn_e.TabIndex = 5;
            this.btn_e.Text = "Editar";
            this.btn_e.UseVisualStyleBackColor = false;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btn_a
            // 
            this.btn_a.BackColor = System.Drawing.Color.Orange;
            this.btn_a.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_a.Location = new System.Drawing.Point(46, 533);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(254, 59);
            this.btn_a.TabIndex = 6;
            this.btn_a.Text = "Añadir";
            this.btn_a.UseVisualStyleBackColor = false;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // dgv_tareas
            // 
            this.dgv_tareas.AllowUserToAddRows = false;
            this.dgv_tareas.AllowUserToDeleteRows = false;
            this.dgv_tareas.AllowUserToResizeColumns = false;
            this.dgv_tareas.AllowUserToResizeRows = false;
            this.dgv_tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tareas.Location = new System.Drawing.Point(46, 47);
            this.dgv_tareas.Name = "dgv_tareas";
            this.dgv_tareas.ReadOnly = true;
            this.dgv_tareas.Size = new System.Drawing.Size(853, 429);
            this.dgv_tareas.TabIndex = 9;
            this.dgv_tareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tareas_CellClick);
            this.dgv_tareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tareas_CellContentClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Orange;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Location = new System.Drawing.Point(645, 533);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(254, 59);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refrescar";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // central_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 628);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgv_tareas);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.btn_e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "central_admin";
            this.Text = "Panel de control";
            this.Load += new System.EventHandler(this.central_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.DataGridView dgv_tareas;
        private System.Windows.Forms.Button btn_refresh;
    }
}

