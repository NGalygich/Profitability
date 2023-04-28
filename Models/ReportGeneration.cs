using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;


public class RepoportGeneration
{
     _Application excelapp = new _excel.Application();
    Workbook wb;
    Worksheet ws;
    public void CreateFile() {
        this.wb = excelapp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        this.ws = this.wb.Worksheets[1];
    }
    public void CreateSheet() {
        Worksheet worksheet1 = excelapp.Worksheets.Add(After: this.ws);
    }

    public void SaveAs(string filepath) {
        wb.SaveAs(filepath);
    }
    public static void Generation()
    {
        
        try
        {
            Excel Excelfile = new Excel();
            Excelfile.CreateFile();
            Excelfile.CreateSheet();
            Excelfile.SaveAs(@"C:/Users/galyga_na/Desktop/ExcelfilebyZeeshan.xlsx");
            Excelfile.wb.Close();
            MessageBox.Show("Объект успешно сохранен");

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        }
        
    }
   
}

