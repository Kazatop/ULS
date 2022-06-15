using System;
using System.Windows.Forms;

namespace ULS
{
    public class ExportMicrosoftOffice
    {
        public static void ExportExcel(DataGridView dataGrid, DataGridView dataGrid2)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            //worksheet.Select();

            worksheet.Name = "Накладные";
            for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.Sheets.Add();
            worksheet = workbook.Sheets["Лист2"];
            worksheet.Name = "Позиции накладной";

            for (int i = 1; i < dataGrid2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGrid2.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGrid2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid2.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGrid2.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        public static void ExportExcel(DataGridView dataGrid)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            //worksheet.Select();

            worksheet.Name = "Склад";
            for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}
