using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118265_ENT
{
   public  class Retiro
    {
        public int RetiroId { get; set; }

      


        //Cuenta
        public ICollection<Cuenta> Cuentas { get; set; }
        public Retiro()
        {
            Cuentas = new HashSet<Cuenta>();
        }

    }
}
