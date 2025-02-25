using System;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Detalhardata();
            CalcularDescontoINSS();
        }

        public static void Detalhardata()
        {
             Console.WriteLine("Digite uma data no formato DD/MM/AAAA: ");
         string? dataStr = Console.ReadLine();
         if (string.IsNullOrEmpty(dataStr))
         {
            Console.WriteLine("Data inválida. Por favor, digite no formato DD/MM/AAAA.");
            return;
         }
            if (!DateTime.TryParseExact(dataStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
            {
                Console.WriteLine("Data inválida. Por favor, digite no formato DD/MM/AAAA.");
            }
            else
            {
                string[] diasDaSemana = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };
                string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

                string diaDaSemana = diasDaSemana[(int)data.DayOfWeek];
                string mes = meses[data.Month - 1];

                Console.WriteLine($"Dia da Semana: {diaDaSemana}");
                Console.WriteLine($"Mês: {mes}");

                if (diaDaSemana == "Domingo")
                {
                    string horaAtual = DateTime.Now.ToString("HH:mm");
                    Console.WriteLine($"Hora atual: {horaAtual}");
                }
            }
        }

        public static void CalcularDescontoINSS()
        {
              Console.WriteLine("Digite o valor do salário:");
             decimal salario = decimal.Parse(Console.ReadLine());
    
             decimal inss = 0m;
    
              if (salario <= 1212.00m)
            {
                 inss = salario * 0.075m;
   }  
             else if (salario <= 2427.35m)
             {
                 inss = 1212.00m * 0.075m + (salario - 1212.00m) * 0.09m;
             }
             else if (salario <= 3641.03m)
             {
              inss = 1212.00m * 0.075m + (2427.35m - 1212.00m) * 0.09m + (salario - 2427.35m) * 0.12m;
             }
              else if (salario <= 7087.22m)
             {
               inss = 1212.00m * 0.075m + (2427.35m - 1212.00m) * 0.09m + (3641.03m - 2427.35m) * 0.12m + (salario - 3641.03m) * 0.14m;
             }
              else
             {
               inss = 1212.00m * 0.075m + (2427.35m - 1212.00m) * 0.09m + (3641.03m - 2427.35m) * 0.12m + (7087.22m - 3641.03m) * 0.14m;
             }
    
             decimal salarioComDesconto = salario - inss;
    
             Console.WriteLine($"Valor do INSS a pagar: R$ {inss:F2}");
             Console.WriteLine($"Salário após desconto do INSS: R$ {salarioComDesconto:F2}");
        }

        
    }
}
