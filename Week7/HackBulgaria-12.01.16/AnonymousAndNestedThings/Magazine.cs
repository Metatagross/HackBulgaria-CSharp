using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAndNestedThings
{
    public class Magazine
    {
        private string title;
        private int isbn;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public int Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }
    }
}
