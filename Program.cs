// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

int[] vetor = new int[1000];
int[] posicao = new int[1000];
int j;
int i;
int maior = 1000;
int menor = 1;
int media = (maior + menor) / 2;
int Teste = 0;
int contadorb = 0;
int contador = 0;
int contadort = 0;
Console.Write("Coloque seu valor pra Buscar: \n");
int busca1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\n\n");
try
{
    for (i = 0; i < 1000; i++)
    {
        vetor[i] = i;
        posicao[i] = 1;
    }
    
    //Busca Linear
    Console.Write("Busca Linear pro valor {0} \n", busca1);
    for (j = 0; j < 1000; j++)
    {
        
        if (vetor[j] == busca1)
        {
            Console.Write("Numero Encotrado na posicao ");
            Console.Write(j);
            Console.Write("\nVoce realizou um total de ");
            Console.Write(contador);
            Console.Write(" buscas");
            Teste = 1;
        }
        if (vetor[j] == 1000 && Teste != 1)
        {
            Console.Write("Numero Não Encotrado");
        }
        contador++;
    }

 
    //Busca binaria 
    Console.Write("\n\n\nBusca Binaria pro valor {0}", busca1);
    j = (vetor.GetLength(0) / 2) - 1;
    contadorb = 1;
    while (menor < maior)
    {
        media = (maior + menor) / 2;
        if (media > busca1)
        {
            maior = media;
        }
        else if (media < busca1)
        {
            menor = media + 1;
        }
        else
        {
            Console.Write("\nO programa realizou um total de {0} buscas \n", contadorb);
            break;
        }
        contadorb++;

    }
    //Busca por tabela de frequencia
    Console.Write("\n\n\nBusca por tabela de frequencia pro valor {0}", busca1);
    if (posicao[busca1 - 1] > 0)
    {
        contadort++;
        Console.Write("\nNumero Encotrado na posicao ");
        Console.Write(busca1);
        Console.Write("\nVoce realizou {0} busca\n" ,contadort) ;
    }
}
catch (IndexOutOfRangeException ex)
{
    Console.Write("Valor fora do escopo");
}
catch (Exception ex)
{
    Console.Write("Erro");
}