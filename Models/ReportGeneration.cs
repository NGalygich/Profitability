using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Profitability.View
{
    public class RepoportGeneration
    {
        public static void DisplayInExcel(Account accounts)
        {
        

            var excelApp = new Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a particular template.
            // Because no argument is sent in this example, Add creates a new workbook.
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "ID Number";
            workSheet.Cells[1, "B"] = "Current Balance";

            var row = 1;
            //foreach (var acct in accounts)
            //{
            //    row++;
                workSheet.Cells[row, "A"] = accounts.ID;
                workSheet.Cells[row, "B"] = accounts.Balance;
            //}

            ((Excel.Range)workSheet.Columns[1]).AutoFit();
            ((Excel.Range)workSheet.Columns[2]).AutoFit();
        }
    }
}


