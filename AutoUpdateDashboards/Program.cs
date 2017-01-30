using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AutoUpdateDashboards
{
    class Program
    {

        static void Main(string[] args)
        {
            //The source stays the same no matter what. Unless dir is changed this needs to change.
            const string source = @"C:\Users\Stratton\Downloads\";
            string date = DateTime.Today.ToString("MM-dd-yyyy");
            //The dest var won't be constant because this needs to happen everday.
            string dest = Path.Combine(@"C:\Users\Stratton\Desktop\Dashboards\", date + @"\");
            getFiles(source, dest);
        }

        static void getFiles(string source, string dest)
        {
            DirectoryInfo di = new DirectoryInfo(source);
            FileInfo[] fi = di.GetFiles();
            try
            {
                if (Directory.Exists(dest))
                {
                    Directory.Delete(dest);
                }
                Directory.CreateDirectory(dest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            { FileRenaming(fi, dest); }  
           
        }

        static void FileRenaming (FileInfo[] x, string dest)
        {
            string date = DateTime.Today.ToString("MM-dd-yyyy") + ".jpg";
            foreach(FileInfo f in x)
            {
                if (f.Name.Equals("MTD Report-100.jpg"))
                {
                    File.Move(f.FullName, dest + "MTD Report-Bedford " + date);
                }
                else if (f.Name.Equals("MTD Report-100 (1).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Blacksburg ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (2).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Botetourt ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (3).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Cave Spring ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (4).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Christiansburg ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (5).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Fairlawn ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (6).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Galax ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (7).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Goldsboro ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (8).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Hillsville ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (9).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Peters Creek ") + date);
                }
                else if (f.Name.Equals("MTD Report-100 (10).jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-Rocky Mount ") + date);
                }
                else if (f.Name.Equals("QTD Report-100.jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Bedford ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (1).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Blacksburg ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (2).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Botetourt ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (3).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Cave Spring ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (4).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Christiansburg ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (5).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Fairlawn ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (6).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Galax ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (7).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Goldsboro ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (8).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Hillsville ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (9).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Peters Creek ") + date);
                }
                else if (f.Name.Equals("QTD Report-100 (10).jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-Rocky Mount ") + date);
                }
                else if (f.Name.Equals("MTD Report - Company-100.jpg"))
                {
                    File.Move(f.FullName, (dest + "MTD Report-All Company") + date);
                }
                else if (f.Name.Equals("QTD Report - Company-100.jpg"))
                {
                    File.Move(f.FullName, (dest + "QTD Report-All Company ") + date);
                }
            }
        }

    }
}
