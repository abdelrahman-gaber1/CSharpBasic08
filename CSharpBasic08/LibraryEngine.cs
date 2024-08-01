using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic08
{
    public delegate T GetBookFunction<T>(Book B); 
    
    public class LibraryEngine
    {
        public static void processBooks<T>(List<Book> bList ,GetBookFunction<T> fptr )
        {
            foreach (Book B in bList ) 
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
}
