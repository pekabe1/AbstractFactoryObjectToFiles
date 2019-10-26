using AbstractFactoryObjectToFiles.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryObjectToFiles.FileInterfaces
{
  public  interface IBookToFile
    {
        void Add(Book item);
        void Read();
        void Remove(int id);
        void Update(Book id);

    }
}
