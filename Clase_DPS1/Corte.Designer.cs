/**
 * @file Corte.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Corte de caja.
 * @brief Realizar el corte de caja y registrarlo en la base de datos.
 */
namespace Clase_DPS1
{
    /**
     * @title Corte
     * @brief clase principal donde se realiza el corte de caja.
     */
    partial class Corte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        /**
         * @title Dispose
         * @brief Limpia cualquier recurso que está siendo usado
         * @param disposin Verdadero si los recursos manejados deben ser desechado; de lo contrario, falso.
         */
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
            this.label2 = new System.Windows.Forms.Label();
            this.bi1000 = new System.Windows.Forms.TextBox();
            this.bi500 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bi200 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bi100 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bi50 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bi20 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mo10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mo5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mo2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mo1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ce50 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.banco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Totalcaja = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ret = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ent = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_fecha = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tentradas = new System.Windows.Forms.Label();
            this.tfaltante = new System.Windows.Forms.Label();
            this.tsobrante = new System.Windows.Forms.Label();
            this.tcorte = new System.Windows.Forms.Label();
            this.tretiros = new System.Windows.Forms.Label();
            this.tcajas = new System.Windows.Forms.Label();
            this.tbancos = new System.Windows.Forms.Label();
            this.tefectivo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corte diario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "$1000";
            // 
            // bi1000
            // 
            this.bi1000.Location = new System.Drawing.Point(81, 31);
            this.bi1000.Name = "bi1000";
            this.bi1000.Size = new System.Drawing.Size(100, 20);
            this.bi1000.TabIndex = 2;
            this.bi1000.TextChanged += new System.EventHandler(this.bi1000_TextChanged);
            this.bi1000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bi1000_KeyPress);
            // 
            // bi500
            // 
            this.bi500.Location = new System.Drawing.Point(81, 57);
            this.bi500.Name = "bi500";
            this.bi500.Size = new System.Drawing.Size(100, 20);
            this.bi500.TabIndex = 4;
            this.bi500.TextChanged += new System.EventHandler(this.bi500_TextChanged);
            this.bi500.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bi500_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "$500";
            // 
            // bi200
            // 
            this.bi200.Location = new System.Drawing.Point(81, 83);
            this.bi200.Name = "bi200";
            this.bi200.Size = new System.Drawing.Size(100, 20);
            this.bi200.TabIndex = 6;
            this.bi200.TextChanged += new System.EventHandler(this.bi200_TextChanged);
            this.bi200.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bi200_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "$200";
            // 
            // bi100
            // 
            this.bi100.Location = new System.Drawing.Point(81, 109);
            this.bi100.Name = "bi100";
            this.bi100.Size = new System.Drawing.Size(100, 20);
            this.bi100.TabIndex = 8;
            this.bi100.TextChanged += new System.EventHandler(this.bi100_TextChanged);
            this.bi100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bi100_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "$100";
            // 
            // bi50
            // 
            this.bi50.Location = new System.Drawing.Point(81, 135);
            this.bi50.Name = "bi50";
            this.bi50.Size = new System.Drawing.Size(100, 20);
            this.bi50.TabIndex = 10;
            this.bi50.TextChanged += new System.EventHandler(this.bi50_TextChanged);
            this.bi50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bi50_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "$50";
            // 
            // bi20
            // 
            this.bi20.Location = new System.Drawing.Point(81, 161);
            this.bi20.Name = "bi20";
            this.bi20.Size = new System.Drawing.Size(100, 20);
            this.bi20.TabIndex = 12;
            this.bi20.TextChanged += new System.EventHandler(this.bi20_TextChanged);
            this.bi20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bi20_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "$20";
            // 
            // mo10
            // 
            this.mo10.Location = new System.Drawing.Point(81, 187);
            this.mo10.Name = "mo10";
            this.mo10.Size = new System.Drawing.Size(100, 20);
            this.mo10.TabIndex = 14;
            this.mo10.TextChanged += new System.EventHandler(this.mo10_TextChanged);
            this.mo10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mo10_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "$10";
            // 
            // mo5
            // 
            this.mo5.Location = new System.Drawing.Point(81, 213);
            this.mo5.Name = "mo5";
            this.mo5.Size = new System.Drawing.Size(100, 20);
            this.mo5.TabIndex = 16;
            this.mo5.TextChanged += new System.EventHandler(this.mo5_TextChanged);
            this.mo5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mo5_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "$05";
            // 
            // mo2
            // 
            this.mo2.Location = new System.Drawing.Point(81, 239);
            this.mo2.Name = "mo2";
            this.mo2.Size = new System.Drawing.Size(100, 20);
            this.mo2.TabIndex = 18;
            this.mo2.TextChanged += new System.EventHandler(this.mo2_TextChanged);
            this.mo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mo2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "$02";
            // 
            // mo1
            // 
            this.mo1.Location = new System.Drawing.Point(81, 265);
            this.mo1.Name = "mo1";
            this.mo1.Size = new System.Drawing.Size(100, 20);
            this.mo1.TabIndex = 20;
            this.mo1.TextChanged += new System.EventHandler(this.mo1_TextChanged);
            this.mo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mo1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "$01";
            // 
            // ce50
            // 
            this.ce50.Location = new System.Drawing.Point(81, 291);
            this.ce50.Name = "ce50";
            this.ce50.Size = new System.Drawing.Size(100, 20);
            this.ce50.TabIndex = 22;
            this.ce50.TextChanged += new System.EventHandler(this.ce50_TextChanged);
            this.ce50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ce50_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "$0.50";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total: $";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // banco
            // 
            this.banco.Location = new System.Drawing.Point(95, 33);
            this.banco.Name = "banco";
            this.banco.Size = new System.Drawing.Size(100, 20);
            this.banco.TabIndex = 25;
            this.banco.TextChanged += new System.EventHandler(this.total_tarjeta_TextChanged);
            this.banco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.banco_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Total bancos:";
            // 
            // Totalcaja
            // 
            this.Totalcaja.Location = new System.Drawing.Point(95, 38);
            this.Totalcaja.Name = "Totalcaja";
            this.Totalcaja.Size = new System.Drawing.Size(100, 20);
            this.Totalcaja.TabIndex = 27;
            this.Totalcaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Totalcaja_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Total (caja):";
            // 
            // ret
            // 
            this.ret.Location = new System.Drawing.Point(95, 68);
            this.ret.Name = "ret";
            this.ret.Size = new System.Drawing.Size(100, 20);
            this.ret.TabIndex = 29;
            this.ret.TextChanged += new System.EventHandler(this.Retiros_TextChanged);
            this.ret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ret_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Retiros:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ent);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.ret);
            this.groupBox1.Controls.Add(this.Totalcaja);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(391, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 151);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caja registradora";
            // 
            // ent
            // 
            this.ent.Location = new System.Drawing.Point(95, 99);
            this.ent.Name = "ent";
            this.ent.Size = new System.Drawing.Size(100, 20);
            this.ent.TabIndex = 31;
            this.ent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ent_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(37, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Entradas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ce50);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.bi1000);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.bi500);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bi200);
            this.groupBox2.Controls.Add(this.mo1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.bi100);
            this.groupBox2.Controls.Add(this.mo2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bi50);
            this.groupBox2.Controls.Add(this.mo5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bi20);
            this.groupBox2.Controls.Add(this.mo10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(124, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 373);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Efectivo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(658, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 373);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de corte";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(46, 167);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "Total retiros: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(63, 302);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Faltante: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(58, 272);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Sobrante: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 187);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Total Corte: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(49, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Total retiros: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 221);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Total (Segun caja): ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Total Bancos: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Total Efectivo: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.banco);
            this.groupBox4.Location = new System.Drawing.Point(391, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 76);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bancos";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(421, 119);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(172, 13);
            this.label_fecha.TabIndex = 36;
            this.label_fecha.Text = "Fecha: 03 /Diciembre  /2020";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tentradas);
            this.groupBox5.Controls.Add(this.tfaltante);
            this.groupBox5.Controls.Add(this.tsobrante);
            this.groupBox5.Controls.Add(this.tcorte);
            this.groupBox5.Controls.Add(this.tretiros);
            this.groupBox5.Controls.Add(this.tcajas);
            this.groupBox5.Controls.Add(this.tbancos);
            this.groupBox5.Controls.Add(this.tefectivo);
            this.groupBox5.Location = new System.Drawing.Point(658, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 383);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion de corte";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // tentradas
            // 
            this.tentradas.AutoSize = true;
            this.tentradas.Location = new System.Drawing.Point(32, 167);
            this.tentradas.Name = "tentradas";
            this.tentradas.Size = new System.Drawing.Size(82, 13);
            this.tentradas.TabIndex = 7;
            this.tentradas.Text = "Total Entradas: ";
            // 
            // tfaltante
            // 
            this.tfaltante.AutoSize = true;
            this.tfaltante.Location = new System.Drawing.Point(63, 302);
            this.tfaltante.Name = "tfaltante";
            this.tfaltante.Size = new System.Drawing.Size(51, 13);
            this.tfaltante.TabIndex = 6;
            this.tfaltante.Text = "Faltante: ";
            // 
            // tsobrante
            // 
            this.tsobrante.AutoSize = true;
            this.tsobrante.Location = new System.Drawing.Point(58, 272);
            this.tsobrante.Name = "tsobrante";
            this.tsobrante.Size = new System.Drawing.Size(56, 13);
            this.tsobrante.TabIndex = 5;
            this.tsobrante.Text = "Sobrante: ";
            // 
            // tcorte
            // 
            this.tcorte.AutoSize = true;
            this.tcorte.Location = new System.Drawing.Point(49, 187);
            this.tcorte.Name = "tcorte";
            this.tcorte.Size = new System.Drawing.Size(65, 13);
            this.tcorte.TabIndex = 4;
            this.tcorte.Text = "Total Corte: ";
            // 
            // tretiros
            // 
            this.tretiros.AutoSize = true;
            this.tretiros.Location = new System.Drawing.Point(49, 143);
            this.tretiros.Name = "tretiros";
            this.tretiros.Size = new System.Drawing.Size(68, 13);
            this.tretiros.TabIndex = 3;
            this.tretiros.Text = "Total retiros: ";
            // 
            // tcajas
            // 
            this.tcajas.AutoSize = true;
            this.tcajas.Location = new System.Drawing.Point(14, 221);
            this.tcajas.Name = "tcajas";
            this.tcajas.Size = new System.Drawing.Size(100, 13);
            this.tcajas.TabIndex = 2;
            this.tcajas.Text = "Total (Segun caja): ";
            // 
            // tbancos
            // 
            this.tbancos.AutoSize = true;
            this.tbancos.Location = new System.Drawing.Point(38, 68);
            this.tbancos.Name = "tbancos";
            this.tbancos.Size = new System.Drawing.Size(76, 13);
            this.tbancos.TabIndex = 1;
            this.tbancos.Text = "Total Bancos: ";
            // 
            // tefectivo
            // 
            this.tefectivo.AutoSize = true;
            this.tefectivo.Location = new System.Drawing.Point(38, 108);
            this.tefectivo.Name = "tefectivo";
            this.tefectivo.Size = new System.Drawing.Size(79, 13);
            this.tefectivo.TabIndex = 0;
            this.tefectivo.Text = "Total Efectivo: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(424, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 34);
            this.button3.TabIndex = 37;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Orange;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(424, 425);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(151, 34);
            this.btn_aceptar.TabIndex = 38;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 628);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Corte";
            this.Text = "Total Efectivo";
            this.Load += new System.EventHandler(this.Corte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bi1000;
        private System.Windows.Forms.TextBox bi500;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bi200;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bi100;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bi50;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bi20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mo10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mo5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ce50;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox banco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Totalcaja;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ret;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.TextBox ent;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label tentradas;
        private System.Windows.Forms.Label tfaltante;
        private System.Windows.Forms.Label tsobrante;
        private System.Windows.Forms.Label tcorte;
        private System.Windows.Forms.Label tretiros;
        private System.Windows.Forms.Label tcajas;
        private System.Windows.Forms.Label tbancos;
        private System.Windows.Forms.Label tefectivo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_aceptar;
    }
}