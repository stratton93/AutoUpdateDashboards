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
            {
                foreach(FileInfo f in fi)
                {
                    //File.Move(f.FullName, dest + newFileNames());
                    if (f.Name.Equals("MTD Report-100.jpg"))
                    {
                        File.Move(f.FullName, dest + "MTD Report-Bedford " + DateTime.Today.ToString("MM-dd-yyy") + ".jpg");
                    }
                }
            }   
            newFileNames(dest);
            Console.Read();
        }

        static void newFileNames(string dest)
        { 
            string z = "";
            const string prefix = "MTD Report-";
            const string suffix = ".jpg";
            string[] clinicNames = { "Bedford", "Blacksburg", "Botetourt", "Cave Spring", "Christiansburg", "Fairlawn",
                "Galax", "Goldsboro", "Hillsville", "Peters Creek", "Rocky Mount", "All Company"};
            string date = DateTime.Today.ToString("MM-dd-yyy");
            foreach(string s in clinicNames)
            {
                z = (prefix + s +" "+ date + suffix);
                Console.WriteLine(z);
            }
            ;
        }

        static void printListValues(FileInfo[] w)
        {
            foreach (FileInfo s in w)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }

        
    }
}
