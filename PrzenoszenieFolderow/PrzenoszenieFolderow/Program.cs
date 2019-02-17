using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrzenoszenieFolderow
{
    class Program
    {
        static void Main(string[] args)
        {
            string FolderPrzenoszony = @"C:\dane";
            string gdzie = @"C:\dane2";

            try
            {
                Directory.Move(FolderPrzenoszony, gdzie);
            }
            catch (DirectoryNotFoundException e)
            {
                Directory.CreateDirectory(gdzie);
                Directory.Move(FolderPrzenoszony, gdzie);
            }
        }
    }
}