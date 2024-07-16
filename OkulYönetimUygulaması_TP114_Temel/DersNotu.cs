using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimUygulaması_TP114_Temel
{
    internal class DersNotu
    {
        public string DersAdi;
        public int Not;

        public DersNotu(string dersAdi, int not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }
    }
}
