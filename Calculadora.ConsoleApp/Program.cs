int continuar = 1;
int a, b;
int resultado;
int posicao = 0;
string calculoCompleto = "";
string[] verHistorico = new string[100];

while (continuar == 1)
{

    Console.WriteLine("----------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("----------------------------");

    Console.WriteLine("1 Para Somar");
    Console.WriteLine("2 Para Diminuir");
    Console.WriteLine("3 Para Multiplicar");
    Console.WriteLine("4 Para Dividir");
    Console.WriteLine("5 Para Tabuada");
    Console.WriteLine("6 Para Historico");

    Console.WriteLine("----------------------------");

    Console.Write("Qual opcão deseja escolher? ");
    int qualCalculo = int.Parse(Console.ReadLine());




    if (qualCalculo != 1 && qualCalculo != 2 && qualCalculo != 3 && qualCalculo != 4 && qualCalculo != 5 && qualCalculo != 6)
    {
        Console.WriteLine("Você digitou uma opcão invalida!");
    }

    if (qualCalculo == 1)
    {
        Console.WriteLine("----------------------------");
        Console.Write("Digite um numero: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Numero: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------");

        resultado = a + b;
        Console.WriteLine("Você escolheu somar.");
        Console.WriteLine("Primeiro numero: " + a);
        Console.WriteLine("Segundo numero: " + b);
        Console.WriteLine(a + " + " + b + " = " + resultado);
        calculoCompleto = a + " + " + b + " = " + resultado;

    }
    else if (qualCalculo == 2)
    {
        Console.WriteLine("----------------------------");
        Console.Write("Digite um numero: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Numero: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------");
        resultado = a - b;
        Console.WriteLine("Você escolheu diminuir.");
        Console.WriteLine("Primeiro numero: " + a);
        Console.WriteLine("Segundo numero: " + b);
        Console.WriteLine(a + " - " + b + " = " + resultado);
        calculoCompleto = a + " - " + b + " = " + resultado;
    }
    else if (qualCalculo == 3)
    {
        Console.WriteLine("----------------------------");
        Console.Write("Digite um numero: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Numero: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------");

        resultado = a * b;
        Console.WriteLine("Você escolheu multiplicar.");
        Console.WriteLine("Primeiro numero: " + a);
        Console.WriteLine("Segundo numero: " + b);
        Console.WriteLine(a + " X " + b + " = " + resultado);
        calculoCompleto = a + " X " + b + " = " + resultado;
    }
    else if (qualCalculo == 4)
    {
        Console.WriteLine("----------------------------");
        Console.Write("Digite um numero: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Numero: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------");

        resultado = a / b;
        Console.WriteLine("Você escolheu dividir.");
        Console.WriteLine("Primeiro numero: " + a);
        Console.WriteLine("Segundo numero: " + b);
        Console.WriteLine(a + " / " + b + " = " + resultado);
        calculoCompleto = a + " / " + b + " = " + resultado;
    }
    else if (qualCalculo == 5)
    {
        Console.WriteLine("----------------------------");
        Console.Write("Qual numero você deseja saber a tabuada? ");
        int qualNumero = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(qualNumero + " X " + i + " = " + qualNumero * i);
        }
    }
    else if (qualCalculo == 6)
    {
        for (int i = 0; i < posicao; i++)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Historico de Operacões");
            Console.WriteLine("Operacão " + i + ": " + verHistorico[i]);

        }
    }


    if (posicao <= verHistorico.Length)
    {
        verHistorico[posicao] = calculoCompleto;
        posicao++;

    }
    else
    {
        verHistorico = new string[100];
        posicao = 0;

        verHistorico[posicao] = calculoCompleto;
        posicao++;
    }

    #region Switch
    /*
        Console.Write("Digite um numero: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Numero: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("----------------------------");

        Console.Write("Qual calculo deseja fazer? ");
        string calculo = Console.ReadLine();
        Console.WriteLine("----------------------------");
    */

    /*
        switch (calculo)
        {
            case "+":
                resultado = a + b;
                Console.WriteLine("Você escolheu somar.");
                Console.WriteLine("Primeiro numero: " + a);
                Console.WriteLine("Segundo numero: " + b);
                Console.WriteLine(a + " + " + b + " = " + resultado);

                break;

            case "-":

                resultado = a - b;
                Console.WriteLine("Você escolheu diminuir.");
                Console.WriteLine("Primeiro numero: " + a);
                Console.WriteLine("Segundo numero: " + b);
                Console.WriteLine(a + " + " + b + " = " + resultado);

                break;

            case "*":
                resultado = a * b;
                Console.WriteLine("Você escolheu multiplicar.");
                Console.WriteLine("Primeiro numero: " + a);
                Console.WriteLine("Segundo numero: " + b);
                Console.WriteLine(a + " + " + b + " = " + resultado);

                break;


            case "/":
                resultado = a / b;
                Console.WriteLine("Você escolheu dividir.");
                Console.WriteLine("Primeiro numero: " + a);
                Console.WriteLine("Segundo numero: " + b);
                Console.WriteLine(a + " + " + b + " = " + resultado);

                break;

            default:

                break;


        }
    */

    #endregion

    Console.WriteLine("----------------------------");
    Console.WriteLine("Digite 1 para continuar ou 2 para sair");
    Console.Write("Deseja Continuar a Calcular? ");
    continuar = int.Parse(Console.ReadLine());

    Console.Clear();
}


Console.ReadKey();