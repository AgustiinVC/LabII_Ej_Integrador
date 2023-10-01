using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperador;
        private Numeracion segundoOperador;

        public Numeracion PrimerOperador
        {
            get 
            { 
                return primerOperador; 
            }
            set 
            {
                primerOperador = value; 
            }
        }

        public Numeracion SegundoOperador
        {
            get 
            { 
                return segundoOperador; 
            }
            set 
            {
                segundoOperador = value; 
            }
        }

        public Operacion()
        {
            primerOperador = new Numeracion("0", Numeracion.ESistema.Decimal);
            segundoOperador = new Numeracion("0", Numeracion.ESistema.Decimal);
        }

        public Numeracion Operar(char operador)
        {
            
            switch (operador)
            {
                case '+':
                    PrimerOperador += SegundoOperador;
                    break;
                case '-':
                    PrimerOperador -= SegundoOperador;
                    break;
                case '*':
                    PrimerOperador *= SegundoOperador;
                    break;
                case '/':
                    if (SegundoOperador.Valor != "0")
                    {
                        PrimerOperador /= SegundoOperador;
                    }
                    else
                    {
                        PrimerOperador -= PrimerOperador ;
                    }
                    break;
                default:
                    PrimerOperador = PrimerOperador + SegundoOperador; // Por defecto, realizar una suma.
                    break;
            }
            return PrimerOperador;
        }
    }
}