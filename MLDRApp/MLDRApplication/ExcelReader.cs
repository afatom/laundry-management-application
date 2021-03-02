using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace MLDRApplication
{
    public class ExcelReader
    {
        public static List<Customer> ExcelReadergetCustomers(string path)
        {

            List<Customer> customersList = new List<Customer>();
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(@"C:\Users\fares\OneDrive\Documents\customersInitValues.xlsx");
            Excel.Worksheet customersWorksheet = excelWorkbook.Sheets[1];
            Excel.Worksheet laundryUnitsWorksheet = excelWorkbook.Sheets[2];


            Excel.Range customersRange = customersWorksheet.UsedRange;
            Excel.Range laundryUnitsRange = laundryUnitsWorksheet.UsedRange;

            int customersSheetRowCount = customersRange.Rows.Count;
            int customersSheetColCount = customersRange.Columns.Count;
            int laundryUnitsSheetRowCount = laundryUnitsRange.Rows.Count;
            int laundryUnitsSheetColCount = laundryUnitsRange.Columns.Count;


            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 1; i <= customersSheetRowCount; i++)
            {
                for (int j = 1; j <= customersSheetColCount; j++)
                {
                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    //Console.OutputEncoding = System.Text.Encoding.GetEncoding("Windows-1255");
                    if (customersRange.Cells[i, j] != null && customersRange.Cells[i, j].Value2 != null)
                    {
                        //customersList.Add()
                        Console.Write(customersRange.Cells[i, j].Value2.ToString() + "\t");
                           
                    }
                }

            }

            for (int i = 1; i <= laundryUnitsSheetRowCount; ++i)
            {
                for (int j = 1; j <= laundryUnitsSheetColCount; ++j)
                {
                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    //Console.OutputEncoding = System.Text.Encoding.GetEncoding("Windows-1255");
                    if (laundryUnitsRange.Cells[i, j] != null && laundryUnitsRange.Cells[i, j].Value2 != null)
                    {
                        //customersList.Add()
                        
                        Console.Write(laundryUnitsRange.Cells[i, j].Value2.ToString() + "\t");
                    }
                }

            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(customersRange);
            Marshal.ReleaseComObject(customersWorksheet);
            Marshal.ReleaseComObject(laundryUnitsRange);
            Marshal.ReleaseComObject(laundryUnitsWorksheet);


            //close and release
            excelWorkbook.Close();
            Marshal.ReleaseComObject(excelWorkbook);

            //quit and release
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);

            return customersList;



        }
    }
}
