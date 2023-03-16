using System.Reflection.Metadata.Ecma335;

namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe o tamanho do diamante ou Exit");
                String s = Console.ReadLine();
                if (s.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }
                else if (s.Equals("") || s == null)
                {
                    Console.WriteLine("Favor digitar um valor");
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    int d = Convert.ToInt32(s);
                    if (d % 2 == 0)
                    {
                        Console.WriteLine("Favor informar um numero impar");
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        String[,] diamante = new String[d , d];
                        int meio = (d / 2);
                        d--;
                        int inicio = meio; //meio
                        int fim = meio; //
                        for(int linha=0; linha<=meio; linha++)
                        {
                            for (int coluna = 0; coluna <=d; coluna++)
                            {
                                if (inicio <= coluna && coluna <= fim)
                                    { 
                                        diamante[linha, coluna] = "x";
                                    }else
                                    {
                                        diamante[linha, coluna] = " ";
                                    }
                            }
                            inicio--;
                            fim++;
                        }
                        inicio++;
                        fim--;
                        for (int linha = meio; linha <=d; linha++)
                        {
                            for (int coluna = 0; coluna <=d; coluna++)
                            {
                                if (inicio <= coluna)
                                {if(coluna <= fim) {
                                    diamante[linha, coluna] = "x";
                                }}
                                else
                                {
                                    diamante[linha, coluna] = " ";
                                }

                            }
                            inicio++;
                            fim--;
                        }
                        for(int l = 0; l <=d; l++)
                        {
                            for(int c = 0; c <=d; c++)
                            {
                                Console.Write($"{diamante[l, c]}");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}