using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace AutoUpdateDashboards
{
    class Program
    {
        static void Main(string[] args)
        {
            //The source stays the same no matter what. Unless dir is changed this needs to change.
            const string source = @"C:\Users\Stratton\Downloads\";
            //The dest var won't be constant because this needs to happen everday.
            string dest = @"C:\Users\Stratton\Desktop\Dashboards\" + DateTime.Today.ToString();
            moveFiles(addListValues(getFilesFromDownloads(source)), dest);
        }

        static FileInfo[] getFilesFromDownloads(string source)
        {
            DirectoryInfo di = new DirectoryInfo(source);
            FileInfo[] fi = di.GetFiles();
            return fi;
        }

        static void moveFiles(List<FileInfo> x, string dirName) 
        {
            //Try to create the new dir for the new files.
            //Exampple: 01-25-2017 -> This will hold all the jpgs.
            try
            {
                //If the Directory already exists, then delete it.
                if(Directory.Exists(dirName))
                {
                    Directory.Delete(dirName);
                }
                //Create or re-create the new dir.
                Directory.CreateDirectory(dirName);
            }
            catch(Exception e)
            {
                Console.WriteLine("Whoops:" + e.StackTrace);
            }
            finally
            {
                //Going to rename the files before moving them.
                renameFiles(x) //this is going to be doing some wizarding shit right here.

            }
        }

        static void renameFiles(List<FileInfo> x)
        {
            printListValues(x);
        }

        static List<FileInfo> addListValues(FileInfo[] x)
        {
            List<FileInfo> t = new List<FileInfo>();
            foreach (FileInfo v in x)
            {
                t.Add(v);
            }
            return t;
        }
        static void printListValues(List<FileInfo> w)
        {
            foreach (FileInfo s in w)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
