using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic08
{
    public class Book
    {
        public string ISBN { get; set; }

        public string Title { get; set; }   

        public string[] Authors { get; set; }

        public DateTime publicationDate { get; set; }

        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _publicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            publicationDate = _publicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            return $"ISBN : {ISBN} , Title : {Title} , Authors : {Authors} , Publication Date : {publicationDate} , Price : {Price}";
        }
    }

    public class BookFunctions 
    {
        public static string GetTitle (Book B) 
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            if(B.Authors != null)
            {
                List<string> authors = new List<string>();
                authors = B.Authors.ToList();
                foreach (string author in authors)
                {
                    return author;
                }
            }
                return null;
        }
        public static string GetPrice (Book B)
        {
            string price = B.Price.ToString();
            return price;
        }
    }
}
