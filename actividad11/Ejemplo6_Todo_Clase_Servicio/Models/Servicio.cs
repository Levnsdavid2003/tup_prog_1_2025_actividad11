using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo6_Todo_Clase_Servicio.Models
{
    internal class Servicio
    {
        int contador = 0;
        double[] valores = new double[100];


        public void RegistrarValor(double valor)
        {
            valores[contador] = valor;
            contador++;
        }

        public double CalcularPromedio()
        {
            double acumulador = 0;
            double promedio = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }

            promedio = acumulador / contador;
            return promedio;
        }

        public double CalcularMaximo()
        {
            double maximo = valores[0];

            for (int i = 1; i < contador; i++)
            {
                if (valores[i] > maximo)
                {
                    maximo = valores[i];
                }
            }
            return maximo;
        }

        public double CalcularMinimo()
        {
            double minimo = valores[0];

            for (int i = 1; i < contador; i++)
            {
                if (valores[i] < minimo)
                {
                    minimo = valores[i];
                }
            }
            return minimo;
        }

        public int BuscarNumero(double deseado)
        {
            int indice = -1;

            for (int i = 0; i < contador && indice == -1; i++)
            {
                if (deseado == valores[i])
                {
                    indice = i;
                }
            }
            return indice;
        }

        void ReordenarNumeros(double[] vector, int pivote, int consecutivo)
        {
            double auxiliar = vector[pivote];
            vector[pivote] = vector[consecutivo];
            vector[consecutivo] = auxiliar;
        }

    }
}
