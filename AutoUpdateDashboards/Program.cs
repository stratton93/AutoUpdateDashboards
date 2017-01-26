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
            string date = DateTime.Today.ToString();
            //The dest var won't be constant because this needs to happen everday.
            string dest = Path.Combine(@"C:\Users\Stratton\Desktop\Dashboards\", date);
            removeInvalidChars(dest);
            moveFiles(addListValues(getFilesFromDownloads(source)), dest);
        }

        //Needed to scrub out unwanted input. Credit of stackoverflow user Tim Schmelter.
        static string removeInvalidChars(string d)
        {
            string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            foreach (char c in invalidChars)
            {
                d = d.Replace(c.ToString(), ""); // or with "."
            }
            return d;
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
                //Create or re-create the new dir.
                if (!Directory.Exists(dirName))
                {
                    Directory.CreateDirectory(dirName);
                }
                else
                {
                    //If the Directory already exists, then delete it.
                    Directory.Delete(dirName);
                }
            }
            catch(Exception e)
            {
                String s = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            }
            finally
            {
                //Going to rename the files before moving them.
                renameFiles(x); //this is going to be doing some wizarding shit right here.

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
