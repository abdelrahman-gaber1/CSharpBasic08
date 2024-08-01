namespace CSharpBasic08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> Blist = new List<Book>();
            LibraryEngine.processBooks(Blist, BookFunctions.GetTitle);
            Book book = new Book("ABCD","Hello", ["Abdo"] , DateTime.Now, 105.5m);
            Func<Book, string> func = BookFunctions.GetTitle;
            func.Invoke(book) ;
            LibraryEngine.processBooks(Blist, delegate (Book book)
            {
                return book.ISBN;
            });
            LibraryEngine.processBooks(Blist, Blist => Blist.publicationDate );            
            
        }
    }
}
