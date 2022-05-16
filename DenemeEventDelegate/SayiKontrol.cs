using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeEventDelegate
{
    internal class SayiKontrol
    {
        private int _sayi;

        public delegate void SayiKontrolEt();
        public event SayiKontrolEt SayiDurumu;

        public int Sayi
        {
            get { return _sayi; }
            set
            {
                if (value < 10)
                {
                    if (SayiDurumu != null)
                    {
                        SayiDurumu();
                    }
                }
                else
                {
                    _sayi = value;
                }
            }
        }

    }
}
