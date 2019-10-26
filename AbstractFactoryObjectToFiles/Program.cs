using System;
using AbstractFactoryObjectToFiles.GetFile;
using AbstractFactoryObjectToFiles.FileExtensions;
using AbstractFactoryObjectToFiles.FileInterfaces;
using AbstractFactoryObjectToFiles.Library;
using AbstractFactoryObjectToFiles.Library;



namespace AbstractFactoryObjectToFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            var file = File.GetFile("Book.xml");
            file.Add(new Book
            {
                Name = "Fajne",
                BookState = "Zły",
                ID = 1,
                 BookCategory = "Fajne"
                
            }); ;
        }
    }
}

//Zadanie 4:
//Utwórz aplikację konsolową która umożliwia zapis odczyt i edycję zamówień na książki w bibliotece.

//Książka może mieć statusy:
//- dostępna
//- wypożyczona
//- zarezerwowana
//oprócz statusu ma id, nazwę i kategorię.
//Można wypożyczyć książkę jeśli jest dostępna lub zarezerwowana dla nas.
//Status ma:
//- stan
//- userName

//Napisz aplikację która trzyma dane w pliku txt, xml i json.Każdy rodzaj pliku obsługiwany jest przez inną klasę. Każda z tych klas musi mieć takie same metody.
//Każda klasa ma implementować IDisposable
//Każda książka ma kategorię która zaczyna się od nazwy i 4 cyfr.Np.DlaDzieci2345, lub Horrory0987 - ogranicz możliwość wprowadzania kategorii do takiej maski.
//Dobrze jeśli operacje CRUD będą dostępne w klasie generycznej (niekoniecznie).