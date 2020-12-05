using System;

namespace exercicio002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um valor numerico: ");
            var valorDigitadoEhInteiro = int.TryParse(Console.ReadLine(), out int valorDigitado);
            Console.WriteLine("O Valor Digitado está certo?:{0} foi: {1}", valorDigitadoEhInteiro, valorDigitado);

            if (valorDigitadoEhInteiro)
            {
                Console.WriteLine("Válido ", valorDigitadoEhInteiro);
            }
            else
            {
                Console.WriteLine("Inválido ", valorDigitadoEhInteiro);
            }

        }
    }
}
