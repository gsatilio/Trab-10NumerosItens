/*
2 - faça um programa que leia 10 numeros inteiros e faça os seguintes itens:
a - imprima o vetor lido
b - imprima o vetor de tras pra frente
c - imprima ate a metade do vetor
d - guarde os valores impares em um novo vetor, sem os valores zero e imprima
e - guarde os valores pares em um novo vetor, sem os valores zero e imprima 
*/

int[] numeros = new int[10];
int[] impares = new int[10];
int[] pares = new int[10];

//int[] impareslixo = new int[10];
//int[] pareslixo = new int[10];

int contador;
while (true)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Por favor, informe o {i + 1}o número inteiro a ser armazenado:");
        numeros[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Imprimindo o vetor:");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{numeros[i]} ");
    }

    Console.WriteLine("\nImprimindo o vetor de trás pra frente:");
    for (int i = 9; i >= 0; i--)
    {
        Console.Write($"{numeros[i]} ");
    }

    Console.WriteLine("\nImprimindo até a metade do vetor:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{numeros[i]} ");
    }

    ////////////////// Impares
    contador = 0;
    for (int i = 0; i < 10; i++)
    {
        if ((numeros[i] % 2) != 0)
        {
            impares[contador] = numeros[i];
            contador++;
        }

    }
    Console.WriteLine("\nImprimindo Impares:");
    for (int i = 0; i < contador; i++)
    {
        Console.Write($"{impares[i]} ");
    }
    //////////////

    ////////////////// Pares
    contador = 0;
    for (int i = 0; i < 10; i++)
    {
        if ((numeros[i] % 2) == 0 && (numeros[i] > 0))
        {
            pares[contador] = numeros[i];
            contador++;
        }

    }
    Console.WriteLine("\nImprimindo Pares:");
    for (int i = 0; i < contador; i++)
    {
        Console.Write($"{pares[i]} ");
    }
    //////////////

    Console.ReadKey();
    Console.Clear();
}
