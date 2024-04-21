using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2E2
{
    internal class Padre
    {

        public int vida;
        public int daño;
        public Padre() { }


        public virtual void recibirDaño(int daño)
        {
            vida -= daño;
        }

        public virtual int dañoQueInflinge()
        {
            return daño;
        }

        public virtual bool seEncuentraConVida() 
        { 
            if(vida > 0) 
            {
                Console.WriteLine("Se encuentra con vida");
                return true;
            }
            else 
            {
                Console.WriteLine("Se encuentra muerto");
                return false;
            }
       
        }
    }
}
