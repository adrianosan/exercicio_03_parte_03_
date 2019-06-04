using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3_parte_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorAplicado = 0;
            int mesInvestir = 0;
            double rendimento = 0;
            double rendimentoTotal = 0;
            double rendimentoRendaFixa = 0;
            double RendaFixaTotal = 0;
            double rendaFixaComImposto = 0;


            Console.WriteLine("Digite  o valor a ser aplicador: ");
            valorAplicado = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de mes da aplicação: ");
            mesInvestir = int.Parse(Console.ReadLine());


            for (int i = 1; i < mesInvestir; i++)
            {
                if (i == 1)
                {
                    rendimento = (valorAplicado * 0.0066) + valorAplicado;
                    rendimentoRendaFixa = (valorAplicado * 0.0098) + valorAplicado;
                    rendaFixaComImposto = (valorAplicado * 0.0098);
                }

                else
                {
                    rendimentoTotal = (rendimento * 0.0066) + rendimento;
                    RendaFixaTotal = (rendimentoRendaFixa * 0.0098) + rendimentoRendaFixa;
                    rendaFixaComImposto = (rendimentoRendaFixa * 0.0098);
                }
            }

            if (mesInvestir <= 12)
            {
                double resultado = rendimentoRendaFixa * 0.25;
                rendimentoRendaFixa = RendaFixaTotal - resultado;
            }

            else if (mesInvestir <= 13 && mesInvestir >= 24)
            {
                double resultado = rendimentoRendaFixa * 0.15;
                rendimentoRendaFixa = RendaFixaTotal - resultado;
            }

            else if (mesInvestir <= 25 && mesInvestir >= 36)
            {

                double resultado = rendimentoRendaFixa * 0.05;
                rendimentoRendaFixa = RendaFixaTotal - resultado;
            }
            else
            {
                double resultado = rendimentoRendaFixa * 0.01;
                rendimentoRendaFixa = RendaFixaTotal - resultado;
            }                                                                                                                                                       

            Console.WriteLine("Valor total do investimento conta poupança e: {0}, e o rendimento na renda fixa e: {1}", rendimentoTotal.ToString("C"), RendaFixaTotal.ToString("c"));

            if (rendimentoTotal > RendaFixaTotal)
            {
                Console.WriteLine("a conta poupaça é melhor para ser investir. ");
            }
            
            else
            {
                Console.WriteLine("a renda fixa é melhor pra ser investir.");
            }

           
        }
    }
}










