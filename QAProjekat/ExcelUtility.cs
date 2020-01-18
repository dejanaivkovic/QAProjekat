using System;
using System.Collections.Generic;
using System.Text;
using IronXL;

namespace QAProjekat
{
    public class ExcelUtility
    {
        private static WorkBook wb = null;
        private static WorkSheet ws = null;
        public static bool OpenFile(string path)
        { 
             try
            {
                if (wb == null)
                {
                    wb = WorkBook.Load(path);
                }
                else
                {
                    Console.WriteLine("Neki fajl je vec ucitan!");
                }
                return true;

            }catch(Exception e)
            
            {
                Console.WriteLine(e.ToString());
                wb = null;
                return false;
            }
        }
        public static bool CloseFile()
        {
            try
            {
                if (wb != null)
                {
                    
                    wb.Close();
                    wb = null;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Doslo je do greske prilikom zatvaranja!");
                return false;
            }
        }
        public static bool LoadWorkSheet(int index)
        {
            try
            {
                if (wb != null)
                {
                    ws = wb.WorkSheets[index];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Nije ucitan WorkSheet!");
                ws = null;
                return false;
            }
        }
        public static string GetDataAt(int row, int column)
        {
            if (ws == null)
            {
                Console.WriteLine("WorkSheet nije ucitan!");
                return "ERROR";
            }
            if (row < ws.Rows.Count)
            {
                RangeRow rangeRow = ws.Rows[row];
                if (column < rangeRow.Columns.Count)
                {
                    RangeColumn rangeColumn = rangeRow.Columns[column];
                    if (rangeColumn != null)
                    {
                        return rangeColumn.StringValue;
                    }
                    else
                    {
                        Console.WriteLine("Ne postoji celija!");
                        return "ERROR";
                    }
                }
                else
                {
                    Console.WriteLine("Ne postoji kolona!");
                    return "ERROR";
                }
            }
            else
            {
                Console.WriteLine("Ne postoji red!");
                return "ERROR";
            }
        }

        //Upisuje u excel tabelu podatak
        public static bool SetData(int row, string data)
        {
            if (ws == null)
            {
                Console.WriteLine("Greska u postavljanju podataka");
                return false;
            }

            ws.SetCellValue(row, ws.Rows[row].Columns.Count, data);
           // wb.SaveAs(Constants.LOGIN_EXCEL_PATH);
            return true;
        }
        //Vraca broj redova
        public static int GetRowCount()
        {
            if (ws == null)
            {
                Console.WriteLine("WorkSheet not loaded!");
                return 0;
            }
            else
            {
                return ws.Rows.Count;
            }
        }


    }
}
