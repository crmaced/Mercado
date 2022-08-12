using System;

namespace P1___Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Double total=0;
            Double produto1=0;
            Double produto2=0;
            Double produto3=0;
            Double valorNota=0;
            Console.WriteLine("Bem vindo ao mercadinho da Cris! Como você está no caixa rápido pode comprar até 3 produtos. Informe os valores dos produtos que você quer comprar.");

            Console.Write("Item 1: R$ ");
            produto1 = Convert.ToDouble(Console.ReadLine());
            if(produto1 <= 0)
            {
            while (produto1 <= 0)
            {
            Console.WriteLine("Por favor, insira um valor válido.");
            Console.WriteLine("Item 1: R$ ");
            produto1 = Convert.ToDouble(Console.ReadLine());
            }
            }
            Console.Write("Item 2: R$ ");
            produto2 = Convert.ToDouble(Console.ReadLine());
            if(produto2 <= 0)
            {
            while (produto2 <= 0)
            {
            Console.WriteLine("Por favor, insira um valor válido.");
            Console.WriteLine("Item 2: R$ ");
            produto2 = Convert.ToDouble(Console.ReadLine());
            }
            }
            Console.Write("Item 3: R$ ");
            produto3 = Convert.ToDouble(Console.ReadLine());
            if(produto3 <= 0)
            {
            while (produto3 <= 0)
            {
            Console.WriteLine("Por favor, insira um valor válido.");
            Console.WriteLine("Item 3: R$ ");
            produto3 = Convert.ToDouble(Console.ReadLine());
            }
            }
            total = (produto1 + produto2 + produto3);
            Console.WriteLine("Valor da compra é de R$ " + total);
            Console.Write("Precisa de Troco? Informe o valor do pagamento: R$ ");
            valorNota = Convert.ToDouble(Console.ReadLine());
            if(valorNota < total)
            {
            while (valorNota < total)
            {
            Console.WriteLine("Desculpe, saldo insuficiente. Informe um valor maior que R$ " + total + ". Novo valor: R$ ");
            valorNota = Convert.ToDouble(Console.ReadLine());
            }
            }

            Double troco = valorNota - total;

            if (troco > 0)
            {
                Console.WriteLine("Obrigada! Seu troco é de R$ " + troco + ". Volte sempre.");
            }
            else
            {
                Console.WriteLine("Obrigada! Volte sempre.");
            }
                                        
         
            Console.ReadKey();

        }
    }
}
