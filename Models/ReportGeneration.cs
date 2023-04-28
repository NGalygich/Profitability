using System;
using System.IO;
using System.Windows;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

public class RepoportGeneration
{
    public static void Generation()
    {
        try
        {
            //using(new ExcelUILanguageHelper())
            //{
                string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "ExcelReport.xlsx";

                Excel.Application xlsApp;
                Excel.Workbook xlsWorkbook;
                Excel.Worksheet xlsWorksheet;
                object misValue = System.Reflection.Missing.Value;

                // Remove the old excel report file
                try
                {
                    FileInfo oldFile = new FileInfo(fileName);
                    if(oldFile.Exists)
                    {
                        File.SetAttributes(oldFile.FullName, FileAttributes.Normal);
                        oldFile.Delete();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }

                try
                {
                    xlsApp = new Excel.Application();
                    xlsWorkbook = xlsApp.Workbooks.Add(misValue);
                    xlsWorksheet = (Excel.Worksheet)xlsWorkbook.Sheets[1];

                    // Create the header for Excel file
                    xlsWorksheet.Cells[1, 1] = "Example of Excel report. Get data from pubs database, table authors";
                    Excel.Range range = xlsWorksheet.get_Range("A1", "E1");
                    range.Merge(1);
                    range.Borders.Color = Color.Black.ToArgb();
                    range.Interior.Color = Color.Yellow.ToArgb();

                    int i = 3;

                    //using SqlConnection conn = new SqlConnection(connectionString);
                    //conn.Open();
                    //using SqlCommand cmd = new SqlCommand(sqlselect, conn);
                    //using SqlDataReader dr = cmd.ExecuteReader();
                    // if(dr.HasRows)
                    // {
                    //     for(int j = 0; j < dr.FieldCount; ++j)
                    //     {
                    //         xlsWorksheet.Cells[i, j + 1] = dr.GetName(j);
                    //     }
                    //     ++i;
                    // }

                    // while(dr.Read())
                    // {
                    //     for(int j = 1; j <= dr.FieldCount; ++j)
                    //         xlsWorksheet.Cells[i, j] = dr.GetValue(j - 1);
                    //     ++i;
                    // }

                    range = xlsWorksheet.get_Range("A2", "I" + (i + 2).ToString());
                    range.Columns.AutoFit();

                    xlsWorkbook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue,
                        Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, misValue, misValue, misValue, misValue);
                    xlsWorkbook.Close(true, misValue, misValue);
                    xlsApp.Quit();

                    // ReleaseObject(xlsWorksheet);
                    // ReleaseObject(xlsWorkbook);
                    // ReleaseObject(xlsApp);

                    // if(MessageBox.Show("Excel report has been created on your desktop\nWould you like to open it?", "Created Excel report",
                    //     MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    // {
                    //     Process.Start(fileName);
                    // }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            //}
            MessageBox.Show("Объект успешно сохранен");

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        }
        
    }
   
}

