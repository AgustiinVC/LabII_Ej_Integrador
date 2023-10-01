using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numeracion
    {
        private double valorNumerico;
        private ESistema sistema;

        public Numeracion(string valorInicial, ESistema sistemaInicial)
        {
            InicializarValores(valorInicial, sistemaInicial);
        }

        public string Valor => ConvertirA(sistema);

        private void InicializarValores(string valorInicial, ESistema sistemaInicial)
        {
            if (sistemaInicial == ESistema.Binario && EsBinario(valorInicial))
            {
                valorNumerico = BinarioADecimal(valorInicial);
                sistema = sistemaInicial;
            }
            else if (double.TryParse(valorInicial, out double valorDecimal))
            {
                valorNumerico = valorDecimal;
                sistema = ESistema.Decimal;
            }
            else
            {
                valorNumerico = double.MinValue;
                sistema = ESistema.Decimal;
            }
        }

        public string ConvertirA(ESistema sistemaDestino)
        {
            switch (sistemaDestino)
            {
                case ESistema.Decimal:
                    return valorNumerico.ToString();
                case ESistema.Binario:
                        return DecimalABinario(((int)valorNumerico));
                default:
                    return "Numero inválido";
            }
        }

        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private int BinarioADecimal(string valor)
        {
            if (EsBinario(valor))
            {
                int valorDecimal = 0;
                int baseBinaria = 1;

                for (int i = valor.Length - 1; i >= 0; i--)
                {
                    if (valor[i] == '1')
                    {
                        valorDecimal += baseBinaria;
                    }
                    baseBinaria *= 2;
                }
                return valorDecimal;
            }
            else
            {
                return 0;
            }
        }

        private string DecimalABinario(int valor)
        {
            if (valor == 0)
            {
                return "0";
            }
            else if (valor >=0)
            {
                string numeroBinario = "";

                while (valor > 0)
                {
                    int resto = valor % 2;
                    numeroBinario = resto.ToString() + numeroBinario;
                    valor = valor / 2;
                }
                return numeroBinario;
            }
            else
            {
                return "Numero inválido";
            }
        }

        private string DecimalABinario(string valor)
        {
            if (int.TryParse(valor, out int num))
            {
                return DecimalABinario(Math.Abs(num));
            }
            return "Número inválido";
        }

        public static bool operator ==(Numeracion num1, Numeracion num2)
        {
            return num1.sistema == num2.sistema;
        }

        public static bool operator !=(Numeracion num1, Numeracion num2)
        {
            return num1.sistema != num2.sistema;
        }

        public static Numeracion operator +(Numeracion num1, Numeracion num2)
        {
            if (num1.sistema == num2.sistema)
            {
                return new Numeracion((num1.valorNumerico + num2.valorNumerico).ToString(), num1.sistema);
            }
            else
            {
                return new Numeracion("0", ESistema.Decimal);
            }
        }

        public static Numeracion operator -(Numeracion num1, Numeracion num2)
        {
            if (num1.sistema == num2.sistema)
            {
                return new Numeracion((num1.valorNumerico - num2.valorNumerico).ToString(), num1.sistema);
            }
            else
            {
                return new Numeracion("0", ESistema.Decimal);
            }
        }

        public static Numeracion operator *(Numeracion num1, Numeracion num2)
        {
            if (num1.sistema == num2.sistema)
            {
                return new Numeracion((num1.valorNumerico * num2.valorNumerico).ToString(), num1.sistema);
            }
            else
            {
                return new Numeracion("0", ESistema.Decimal);
            }
        }

        public static Numeracion operator /(Numeracion num1, Numeracion num2)
        {
            if (num1.sistema == num2.sistema && num2.valorNumerico != 0)
            {
                return new Numeracion((num1.valorNumerico / num2.valorNumerico).ToString(), num1.sistema);
            }
            else
            {
                return new Numeracion("0", ESistema.Decimal);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Numeracion otherNum)
            {
                return sistema == otherNum.sistema;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return sistema.GetHashCode();
        }

        public override string ToString()
        {
            return Valor;
        }

        public enum ESistema
        {
            Decimal,
            Binario
        }
    }
}
