
namespace Clase_DPS1
{
    partial class Lobby1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cs = new System.Windows.Forms.Button();
            this.btn_hc = new System.Windows.Forms.Button();
            this.btn_cd = new System.Windows.Forms.Button();
            this.btn_hi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 81);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cs
            // 
            this.btn_cs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cs.Location = new System.Drawing.Point(22, 543);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(181, 41);
            this.btn_cs.TabIndex = 12;
            this.btn_cs.Text = "Cerrar sesión";
            this.btn_cs.UseVisualStyleBackColor = false;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // btn_hc
            // 
            this.btn_hc.BackColor = System.Drawing.Color.Orange;
            this.btn_hc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hc.Location = new System.Drawing.Point(22, 425);
            this.btn_hc.Name = "btn_hc";
            this.btn_hc.Size = new System.Drawing.Size(181, 70);
            this.btn_hc.TabIndex = 11;
            this.btn_hc.Text = "Historial de corte";
            this.btn_hc.UseVisualStyleBackColor = false;
            this.btn_hc.Click += new System.EventHandler(this.btn_hc_Click);
            // 
            // btn_cd
            // 
            this.btn_cd.BackColor = System.Drawing.Color.Orange;
            this.btn_cd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cd.Location = new System.Drawing.Point(22, 337);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(181, 70);
            this.btn_cd.TabIndex = 10;
            this.btn_cd.Text = "Corte diario";
            this.btn_cd.UseVisualStyleBackColor = false;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // btn_hi
            // 
            this.btn_hi.BackColor = System.Drawing.Color.Orange;
            this.btn_hi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hi.Location = new System.Drawing.Point(22, 252);
            this.btn_hi.Name = "btn_hi";
            this.btn_hi.Size = new System.Drawing.Size(181, 70);
            this.btn_hi.TabIndex = 9;
            this.btn_hi.Text = "Historial de compras";
            this.btn_hi.UseVisualStyleBackColor = false;
            this.btn_hi.Click += new System.EventHandler(this.btn_hi_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(220, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 628);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(22, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 70);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tareas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(22, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario: Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lobby1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1216, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_hc);
            this.Controls.Add(this.btn_cd);
            this.Controls.Add(this.btn_hi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lobby1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control mama gallina";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cs;
        private System.Windows.Forms.Button btn_hc;
        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.Button btn_hi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}