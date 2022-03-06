using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaApka
{
    class Class1 : Interface1
    {
        private int _myProperty;
        public int MyProperty
        {
            get { return (int)(_myProperty * 1.23);  }
            set { _myProperty = value; }
        }

        public double a { get; set; }

        public int Zmienna { get; set; }

        public virtual void fun()
        {

        }

        public void Metoda()
        {
            try
            {

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
