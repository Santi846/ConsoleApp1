using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //internal class Book
    //{
    //}

    public class Book
    {
        string _name;
        string _author;
        string _description;
        int _amount_pages;

        //contructor that instances each attribute
        public Book( string name, string author, string description, int amount_pages)
        {
            _name = name;
            _author = author;
            _description = description;
            _amount_pages = amount_pages;
        }

        //methor for returning that constructor built
        public string GetDescription()
        {
            return $"The book is {_name} by {_author}, it's about {_description} and it has {_amount_pages}";
        }
    }
}
