
namespace Clase_DPS1
{
    partial class LobbyB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyB));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cs = new System.Windows.Forms.Button();
            this.btn_cd = new System.Windows.Forms.Button();
            this.btn_hi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(23, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 39);
            this.button2.TabIndex = 23;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(23, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 70);
            this.button1.TabIndex = 22;
            this.button1.Text = "Tareas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(220, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 628);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_cs
            // 
            this.btn_cs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cs.Location = new System.Drawing.Point(23, 509);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(181, 36);
            this.btn_cs.TabIndex = 20;
            this.btn_cs.Text = "Cerrar sesión";
            this.btn_cs.UseVisualStyleBackColor = false;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // btn_cd
            // 
            this.btn_cd.BackColor = System.Drawing.Color.Orange;
            this.btn_cd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cd.Location = new System.Drawing.Point(23, 338);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(181, 70);
            this.btn_cd.TabIndex = 18;
            this.btn_cd.Text = "Corte diario";
            this.btn_cd.UseVisualStyleBackColor = false;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // btn_hi
            // 
            this.btn_hi.BackColor = System.Drawing.Color.Orange;
            this.btn_hi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hi.Location = new System.Drawing.Point(23, 253);
            this.btn_hi.Name = "btn_hi";
            this.btn_hi.Size = new System.Drawing.Size(181, 70);
            this.btn_hi.TabIndex = 17;
            this.btn_hi.Text = "Historial de compras";
            this.btn_hi.UseVisualStyleBackColor = false;
            this.btn_hi.Click += new System.EventHandler(this.btn_hi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 81);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Usuario: Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LobbyB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1216, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_cd);
            this.Controls.Add(this.btn_hi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LobbyB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Mama gallina";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cs;
        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.Button btn_hi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}