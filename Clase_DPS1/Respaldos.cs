/**
 * @file Respaldos.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Respaldos.
 * @brief Archivo que se encarga de la interfaz de usuario y los eventos que realizan respaldos a Microsoft Excel.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_DPS1
{
    /**
     * @title Respaldos
     * @brief Clase que maneja la creación de respaldos de la base de datos.
     */
    public partial class Respaldos : Form
    {
        public Respaldos()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=localhost;" +
                                               "Initial Catalog = ControlMamaGallina;" +
                                               "User ID = sa;" +
                                               "Password = controlmamagallina");

        private void btn_respaldo_Click(object sender, EventArgs e)
        {
            //ExportarDataGridViewExcel(dataGridView1);
            Exportar_Excel_v2(dataGridView1);
            MessageBox.Show("Excel respaldado");
        }

        

        private void copyAlltoClipboard(DataGridView grd)
        {
            grd.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grd.MultiSelect = true;
            grd.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);


        }

        /// <summary>
        /// Metodo que exporta informacion de los cortes diarios a excel.
        /// </summary>
        /// <param name="grd">El data grid view de la informacion de cortes diarios</param>
        
        /**
         * @title Exportar_Excel_v2
         * @brief Método que exporta información de los cortes diarios a Microsoft Excel.
         * @param grd El data grid view de la información de cortes diarios.
         */
        private void Exportar_Excel_v2(DataGridView grd)
        {
            copyAlltoClipboard(grd);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true
            };
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Respaldos_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Corte", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
