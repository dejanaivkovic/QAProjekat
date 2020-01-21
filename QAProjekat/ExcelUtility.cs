using System;
using System.Collections.Generic;
using System.Text;
using IronXL;

namespace QAProjekat
{
    public class ExcelUtility
    {
        private WorkBook wb = null;
        private WorkSheet ws = null;

        public ExcelUtility(string path)
        {
            try
            {
                wb = WorkBook.Load(path);
            }
            catch (Exception e)

            {
                Console.WriteLine(e.ToString());
                // ako konstruktor baci exception onda objekat nece biti napravljen, 
                // zato throw exception inace ce ga napraviti iako ne moze da se otvori fajl
                throw e;
            }
        }

        //destruktor i konstruktor, kontruktor pravi destruktor unistava
        //koristi se u bas u ovim slucajevima kada hoces nesto da pocistis za njima kada vise nisu potrebni (clean up)
        //oznacavaju se sa ~ImeKlase
        ~ExcelUtility()
        {
            try //nisam sigurna da li je uopste potrebno bacanje exception jer ce sam sistem da zatvori
            {
                wb.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Doslo je do greske prilikom zatvaranja!");
            }
        }
        public bool LoadWorkSheet(int index)
        {
            try
            {
                ws = wb.WorkSheets[index];
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Nije ucitan WorkSheet!");
                ws = null;
                return false;
            }
        }
        public string GetDataAt(int row, int column)
        //ovde se bas koriste exception jer ERROR moze da stoji i u excel fajlu, 
        //onda onaj ko poziva ne zna da li je doslo do greske ili je ERROR pisalo u fajlu
        {
            if (ws == null)
            {
                Console.WriteLine("WorkSheet nije ucitan!");
                throw new Exception();
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
                        throw new Exception();
                    }
                }
                else
                {
                    Console.WriteLine("Ne postoji kolona!");
                    throw new Exception();
                }
            }
            else
            {
                Console.WriteLine("Ne postoji red!");
                throw new Exception();
            }
        }

        //Upisuje u excel tabelu podatak
        public  bool SetData(int row, string data)
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
        public  int GetRowCount()
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
