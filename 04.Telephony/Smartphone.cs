namespace _04.Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Smartphone : ICalling, IBrowsing
    {
        private List<string> callNumbers;
        private List<string> sites;

        public Smartphone()
        {
            this.CallNumbers = new List<string>();
            this.Sites = new List<string>();
        }

        public List<string> CallNumbers
        {
            get { return callNumbers; }
            private set { callNumbers = value; }
        }

        public List<string> Sites
        {
            get { return sites; }
            private set { sites = value; }
        }


        public void Brows(string site)
        {
            if (site.Any(Char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }

            else
            {
                Console.WriteLine("Browsing: "+site);
            }
        }

        public void Call(string number)
        {
            Console.WriteLine("Calling... "+number);
        }
    }
}