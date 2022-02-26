namespace Clase_DPS1
{
    partial class central_user
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
            this.dgv_tareas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tareas
            // 
            this.dgv_tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tareas.Location = new System.Drawing.Point(28, 99);
            this.dgv_tareas.Name = "dgv_tareas";
            this.dgv_tareas.Size = new System.Drawing.Size(874, 415);
            this.dgv_tareas.TabIndex = 14;
            this.dgv_tareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tareas_CellContentClick);
            // 
            // central_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 622);
            this.Controls.Add(this.dgv_tareas);
            this.Name = "central_user";
            this.Text = "Panel de control";
            this.Load += new System.EventHandler(this.central_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_tareas;
    }
}