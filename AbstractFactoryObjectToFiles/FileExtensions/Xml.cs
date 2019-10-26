
using AbstractFactoryObjectToFiles.FileInterfaces;
using AbstractFactoryObjectToFiles.Library;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AbstractFactoryObjectToFiles.FileExtensions
{
    internal class Xml : IBookToFile
    {
        private string path { get; } = "Book.xml";
        public void Add(Book item)
        {
            XDocument document = XDocument.Load(path);
            XElement element = new XElement("Book",
                new XAttribute(nameof(Book.Name), item.Name),
                new XAttribute(nameof(Book.ID), item.ID),
                new XAttribute(nameof(Book.BookState), item.BookState),
                new XAttribute(nameof(Book.BookCategory),item.BookCategory));
                 document.Element("root").Add(element);
                 document.Save(path);   
        }
        public void Read()
        {
            throw new NotImplementedException();
        }
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Book id)
        {
            throw new NotImplementedException();
        }
    }
}
