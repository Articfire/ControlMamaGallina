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

        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (.xls)|.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count - 1; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
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
