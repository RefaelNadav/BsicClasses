using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicClasses
{
    internal class LibraryItem
    {
        protected internal string Title;
        public string GetTitle() 
        {
            return Title; 
        }
    }
    internal class Book : LibraryItem
    {
        public void SetTitle(string title)
        {
            Title = title;
        }
    }
}
