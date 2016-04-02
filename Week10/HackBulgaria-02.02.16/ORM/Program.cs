using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    class Program
    {
        static void Main ( string[] args )
        {
            LibraryORMDataContext libDB = new LibraryORMDataContext();
            //libDB.Books.InsertOnSubmit(new Book() { Title="Vatman forever", DatePublished = new DateTime(2015,11,15), Description ="A book with a powerfull message!", ISBN = "887-64851-444-12", Pages=128});
            //libDB.Authors.InsertOnSubmit(new Author() { FirstName = "Angel" , LastName = "Borchakov" , YearBorn = new DateTime(1957 , 11 , 07) });
            //libDB.SubmitChanges();
            var allBooksSortedByTitle =
                from item in libDB.Books
                orderby item.Title
                select item;
            foreach(var item in allBooksSortedByTitle)
            {
                Console.WriteLine($"{item.BookID} - {item.Title}");
            }
            var allBooksSortedByAuthors =
               from item in libDB.Books
               join authorID in libDB.BookAuthors on item.BookID equals authorID.BookID
               join author in libDB.Authors on authorID.AuthorID equals author.AuthorID
               orderby author.FirstName
               select new { FirstName = author.FirstName , Book = item };
            foreach(var item in allBooksSortedByAuthors)
            {
                Console.WriteLine($"{item.FirstName} - {item.Book.Title}");
            }

            var allBooksSortedByGenre =
                from item in libDB.Books
                join genre in libDB.Genres on item.BookID equals genre.GenreID
                orderby genre.Name
                select new { Genre = genre.Name , Book = item };
            foreach(var item in allBooksSortedByGenre)
            {
                Console.WriteLine($"{item.Genre} - {item.Book.Title}");
            }
            Console.WriteLine();
            var authorsWithGenre =
                from author in libDB.Authors
                join bookAuthor in libDB.BookAuthors on author.AuthorID equals bookAuthor.AuthorID
                join book in libDB.Books on bookAuthor.BookID equals book.BookID
                join bookGenre in libDB.BookGenres on book.BookID equals bookGenre.BookID
                join genre in libDB.Genres on bookGenre.GenreID equals genre.GenreID
                group genre by author into grouped
                select grouped;
            foreach(var item in authorsWithGenre)
            {
                Console.WriteLine($"{item.Key.FirstName} {item.Key.LastName}");
                foreach(var genre in item)
                {
                    Console.Write(genre.Name+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
