using System;
using System.IO;
using System.Text;

namespace FilesReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler nyMyFileHandler = new MyFileHandler();
            //nyMyFileHandler.ReadAllContent();
            //nyMyFileHandler.WriteContentToFile("Hejsan!");
            //nyMyFileHandler.UpperCaseContent("testfile1.txt", "testfile3.txt");
            //nyMyFileHandler.ReadLatinEncodedContent();
            NoteBook noteBook = new NoteBook();

            while (true)
            {
                Console.Clear();
                string[] allnotes = noteBook.GetAllNotes();
                Console.WriteLine("persneter notes:");
                foreach (var item in allnotes)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("Write a note: ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Wrong input!!");
                }
                noteBook.TakeNote(input);
            }
        }
    }
}
