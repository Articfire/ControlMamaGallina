namespace Clase_DPS1
{
    partial class Registro_Inventario
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
            this.txtbox_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_surtidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de compras";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox_total
            // 
            this.txtbox_total.Location = new System.Drawing.Point(139, 291);
            this.txtbox_total.Name = "txtbox_total";
            this.txtbox_total.Size = new System.Drawing.Size(210, 20);
            this.txtbox_total.TabIndex = 14;
            this.txtbox_total.TextChanged += new System.EventHandler(this.txtbox_total_TextChanged_1);
            this.txtbox_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_total_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surtidor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox_surtidor
            // 
            this.txtbox_surtidor.Location = new System.Drawing.Point(139, 244);
            this.txtbox_surtidor.Name = "txtbox_surtidor";
            this.txtbox_surtidor.Size = new System.Drawing.Size(210, 20);
            this.txtbox_surtidor.TabIndex = 3;
            this.txtbox_surtidor.TextChanged += new System.EventHandler(this.txtbox_surtidor_TextChanged);
            this.txtbox_surtidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_surtidor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtp_fecha.Location = new System.Drawing.Point(139, 136);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(210, 20);
            this.dtp_fecha.TabIndex = 5;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Area:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmb_area
            // 
            this.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Items.AddRange(new object[] {
            "Area1",
            "Area2",
            "Area3"});
            this.cmb_area.Location = new System.Drawing.Point(139, 187);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(210, 21);
            this.cmb_area.TabIndex = 7;
            this.cmb_area.SelectedIndexChanged += new System.EventHandler(this.cmb_area_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Orange;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_aceptar.Location = new System.Drawing.Point(161, 362);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(136, 23);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Text = "Agregar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 517);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Registro_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 628);
            this.Controls.Add(this.txtbox_total);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_area);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_surtidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Inventario";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Registro_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_surtidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}