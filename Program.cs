using System; // é como se fosse o "include" da linguagem C  // faz parte do dotnet fremework

namespace Aulao1Variaveis  // nome da pasta
{
     class Program // onde os dados ficam contidos (class)  // orientação a objeto
    {
        static void Main(string[] args) // principal (main)
        {
            //DetalharData();  // isso se chama método
            CalcularDescontoINSS();

             //Exeplos da Aula !!!
            /*Console.WriteLine("Digite o seu nome:?"); // printf se fosse em C
            string nome = Console.ReadLine(); // aviso que pode vim nulo (por isso fica amarelo)

            Console.WriteLine($"Seu nome tem {nome.Length} caracteres.");
            Console.ReadKey(); */

            /*Console.WriteLine("Digite a data do seu nascimento: ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            int qtdDiasVividos =DateTime.Now.Subtract(dtNascimento).Days;
            Console.WriteLine("Os dias vividos até hoje são: " + qtdDiasVividos);

            Console.ReadKey(); */

            /*Console.WriteLine(" Observe o menu abaixo e digite o número referente a opção desejada:  ");
            Console.WriteLine("1 - concatenar palavras");
            Console.WriteLine("2 -Verificar Dia da Semana");
            Console.WriteLine("3 - Calcular Média");
            Console.WriteLine("4 - Calcular Tabuada "); */

           /* int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                  ConcatenarPalavras();
                  break;
                case 2:
                  VerificarAulaEtec();
                  break;
                case 3:
                  CalcularMedia();
                  break;
                case 4:
                  CalcularTabuada();
                  break;
                default:
                  Console.WriteLine("Opção inválida");
                  break;      
            } */

           // ConcatenarPalavras();
           // VerificarAulaEtec();
           // CalcularMedia(); // e aqui é chamado o procedimento
          //  CalcularTabuada();

        }  
        public static void ConcatenarPalavras(){
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine(" "); 

            Console.WriteLine("Quanto custa um dolár em reais? ");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dddd}, o dolár está custando {1:c2}", DateTime.Now, valorDolarReais);
            Console.WriteLine(frase2);

            Console.WriteLine(" ");
            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho.ToUpper());
            
        }
        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine());
            
            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei Exercícios.");
            }
            else
            {
                Console.WriteLine("Dia de semana! Bora pra Etec!");
            }

        }
        public static void CalcularMedia() // aqui é o procedimento 
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) /2;
            Console.WriteLine($"A média é {media}"); // É como se fosse o: printf("A média eh: %f\n", media); no C

            if(media >= 7)
            {
              Console.WriteLine("Aprovado");
            }
            else if(media < 7 && media >= 4)
            {
             Console.WriteLine("Recuperação");
            }
            else{
             Console.WriteLine("Reprovado");
            } 
        }
        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calacular");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while(contador <= 10)
            {
                string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador,tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }
        }
        public static void DetalharData()
        {
            /*var data = new DateTime(2024,10,15,11,57,30); 
            Console.WriteLine(data);  // Dessa forma será exibida o dia/mês/ano a h/min/seg escolhidos pelo programador*/

            /*var data = new DateTime(2023,12,25,10,40,00);
            Console. WriteLine(data);
            Console. WriteLine(data.Year);
            Console. WriteLine(data.Month);
            Console. WriteLine(data.Day);
            Console. WriteLine(data.Hour);
            Console. WriteLine(data.Minute);
            Console. WriteLine(data.Second);*/

            /*var data = new DateTime(2024,02,25,12,11,00);
            Console.WriteLine(data.DayOfWeek); //Exibe o dia da semana especificado no DateTime*/

            /*var data = DateTime.Now;
            var formatada = String.Format("{0: MM}", data );
            Console.WriteLine(formatada); // Exibe o Mês em forma de números */

            /*var data = DateTime.Now;
            var formatada = String.Format("{0:t}", data );// quando se coloca o "t" é endendido como um 'short dateTime', ou seja uma datacompactada(horas e minutos)
            Console.WriteLine(formatada); // Exibe a hora e os minitos atuais */

            /*var data = DateTime.Now;
            var formatada = String.Format("{0:d}", data );
            Console.WriteLine(formatada); //Exibe a data  dia/mes/ano*/

            /*var data = DateTime.Now;
            var formatada = String.Format("{0:D}", data );
            Console.WriteLine(formatada); //Exibe a data por extenso Ex: domingo, 25 fervereiro de 2024 */

            /*var data = DateTime.Now;
            var formatada = String.Format("{0:r}", data );
            Console.WriteLine(formatada); // Exibe Sun, 25 Feb 2024 12:35:43 GMT*/

            /*var data = DateTime.Now;
            var formatada = String.Format("{0:s}", data );
            Console.WriteLine(formatada); // Exibe 2024-02-25T12:37:14*/

            /*var data = DateTime.Now;
            var formatada = String.Format("{0:u}", data );
            Console.WriteLine(formatada); // Exibe 2024-02-25 12:38:17Z */

            //var data = DateTime.Now;
            //Console.WriteLine(data);

            /*Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1)); 
              Exibe e o mesmo serve para hora
            25/02/2024 12:56:03
            08/03/2024 12:56:03
            25/03/2024 12:56:03
            25/02/2025 12:56:03
            var formatada = String.Format("{0:D}", data );*/

            //Console.WriteLine("Digite uma data: ");
            //String dataEntrada = Console.ReadLine();
            //Console.WriteLine(dataEntrada);*/

            Console.WriteLine("Digite uma data : "); // 1. Esta linha exibe uma mensagem no console solicitando ao usuário que digite uma data.
            string inputData = Console.ReadLine(); // 2. Esta linha lê a entrada do usuário a partir do console e armazena-a na variável inputData.
            if(DateTime.TryParse(inputData, out DateTime data)) // 3. Esta linha tenta analisar a entrada do usuário como uma data e hora válidas. Se a análise for bem-sucedida, o valor convertido é armazenado na variável data.
            {
              DateTime dataAtual = DateTime.Now; // 4. Esta linha obtém a data e hora atuais do sistema e armazena-as na variável dataAtual.

              string dataFormatada = $"{data:dddd, dd 'de' MMMM 'de' yyyy},{dataAtual:HH:mm:ss}";// 5. Esta linha formata a data inserida pelo usuário (data) com o dia da semana, o dia do mês, o mês por extenso e o ano. Em seguida, acrescenta a hora atual (dataAtual) no formato de horas, minutos e segundos.
              Console.WriteLine("A data e hora são: " + dataFormatada); //6. Esta linha exibe a data e hora formatadas no console.
            }
            else{ // 6. Esta parte do código é executada se a tentativa de analisar a entrada do usuário como uma data falhar.
              Console.WriteLine("Formato de data inválido. Por favor, insira no formato coreto!!!"); //7. Esta linha exibe uma mensagem de erro informando ao usuário que a entrada fornecida não está em um formato de data válido.
            }
        }
         public static void CalcularDescontoINSS()
            {
              Console.WriteLine("Digite o valor do salário:");
        double salario = Convert.ToDouble(Console.ReadLine());

        double inss = 0;
        double salarioDescontado = 0;

        if (salario <= 1212)
        {
            inss = salario * 0.075;
        }
        else if (salario > 1212 && salario <= 2467)
        {
            inss = salario * 0.09;
        }
        else if (salario > 2467 && salario <= 3641)
        {
            inss = salario * 0.12;
        }
        else if (salario > 3641 && salario <= 7084)
        {
            inss = salario * 0.14;
        }
        else
        {
            inss = salario * 0.14; // O máximo é 14% para salários maiores que 3641
        }

        salarioDescontado = salario - inss;

        Console.WriteLine($"Valor do INSS a ser pago: {inss:C}");
        Console.WriteLine($"Salário descontado o INSS: {salarioDescontado:C}");
              
              
              /*float sal;
              Console.WriteLine("Digite o seu salário: ");
              decimal sal = decimal.Parse(Console.ReadLine());

              //Console.WriteLine("Digite o valor do INSS: ");
              //decimal Inss =decimal.Parse(Console.ReadLine());
              
              if(sal <= 1212)
              {
                decimal sal = sal*(7.5/100);
                Console.WriteLine($"O valor do seu salário é:{sal}"); 
              }
              else if( 1.213 <=sal <= 2.427 )
              {
                 decimal sal= sal*(9/100);
                Console.WriteLine($"O valor do seu salário é:{sal}"); 
              }
              else if(2.428 <= sal <= 3.641)
              {
                 decimal SalFinal = sal*(12/100);
                Console.WriteLine($"O valor do seu salário  é:{SalFinal}"); 
              }
              else if(3.642 <= sal <= 7.087)
              {
                 decimal sal = sal*(14/100);
                Console.WriteLine($"O valor do seu salário é:{sal}"); 
              }
              Console.WriteLine(sal); */

            }
            /* public static void CalcularMedia() // aqui é o procedimento 
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) /2;
            Console.WriteLine($"A média é {media}"); // É como se fosse o: printf("A média eh: %f\n", media); no C

            if(media >= 7)
            {
              Console.WriteLine("Aprovado");
            }
            else if(media < 7 && media >= 4)
            {
             Console.WriteLine("Recuperação");
            }
            else{
             Console.WriteLine("Reprovado");
            } 
        } */

    }
}
/*Criar um método chamado DetalharData  1- que apresente a mensagem para o usuário digitar uma data e 
armazene em uma variável compatível . 2- Você deverá usar formatação para imprimir na tela qual o dia da 
Semana (Segunda, Terça...etc) e qual o nome do mês por extenso (Janeiro, Fevereiro etc) . 3- Comparar o 
dia da semana da data, se ela for um domingo, imprimir na tela a hora atual com os minutos (Ex: 14:35) */

/*Criar um método chamado CalcularDescontoINSS  1- que apresente a mensagem que solicite para o 
usuário digitar o valor do salário  2- e armazene em uma variável compatível. 3-Você deverá observar a tabela 
em anexo e apresentar ao usuário o valor de INSS que ele terá que pagar 4- e qual o valor do salário 
descontado o INSS. 5- Você pode declarar a quantidade de variáveis que quiser para fazer os cálculos. */