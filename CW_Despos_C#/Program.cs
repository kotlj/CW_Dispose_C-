using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Despos_C_
{
    class Play
    {
        private string _Name;
        private string _Author;
        private string _Genre;
        private DateTime _Date;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Author
        {
            get
            {
                return _Author;
            }
            set
            {
                _Author = value;
            }
        }
        public string Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                _Genre = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
            }
        }

        public Play(string name, string author, string genre, DateTime date)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Date = date;
        }
        ~Play()
        {
            Console.WriteLine("Object was deleted");
        }
    }
    class Shop : IDisposable
    {
        private string _Name;
        private string _Adress;
        private string _Type;
        
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Adress
        {
            get
            {
                return _Adress;
            }
            set
            {
                _Adress = value;
            }
        }
        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        public Shop(string name, string adress, string type)
        {
            _Name = name;
            _Adress = adress;
            _Type = type;
        }
        public void Dispose()
        {
            Console.WriteLine("Object was disposed");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1603);
            Play play = new Play("Macbeth", "William Shakespeare", "War, drama, history", date);
            GC.Collect();
            Shop shop = new Shop("Shop", "Somewhere", "Electronic");
            try
            {
                shop = new Shop("Shop", "Somewhere", "Electronic");
            }
            finally
            {
                shop.Dispose();
            }
        }
    }
}
