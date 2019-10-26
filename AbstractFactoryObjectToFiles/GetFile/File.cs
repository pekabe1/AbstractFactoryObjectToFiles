using AbstractFactoryObjectToFiles.FileExtensions;
using AbstractFactoryObjectToFiles.FileInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryObjectToFiles.GetFile
{
   public static class File
    {
        public static IBookToFile GetFile(string path)

        {

            IBookToFile bookFromFile = null;

            string[] array = path.Split('.');

            string extention = array[array.Length - 1];

            switch (extention)

            {

                case "txt":
                    bookFromFile = new txt();
                    break;
                case "json":
                    bookFromFile = new Json();
                    break;
                case "xml":
                    bookFromFile = new Xml();
                    break;
                default:
                    throw new Exception("Unknown file extension");

            }

            return bookFromFile;
        }
    }
}
