using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadWrite
{
    internal class MyFileHandler
    {
        public void ReadAllContent()
        {
            string fileContent = File.ReadAllText("testfile1.txt");
            Console.WriteLine(fileContent);
        }
        public void WriteContentToFile(string input)
        {
            File.WriteAllText( "testfile2.txt", input);

        }
        public void UpperCaseContent(string from,string to)
        {
            string fileContent=File.ReadAllText(from);
            File.WriteAllText(to, fileContent.ToUpper());
            string filecontent = File.ReadAllText(to);
            Console.WriteLine(filecontent);
        }
        ////public void ReadLatinEncodedContent()
        ////{
        ////    string fileContent = File.ReadAllText("latin1.txt");
        ////    Console.WriteLine(fileContent);
        ////}
    }
}
