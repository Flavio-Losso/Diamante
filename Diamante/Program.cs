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
                        String[,] i = new String[d , d];
                        int a = (d / 2);
                        d--;
                        int e = a;
                        int f = a;
                        for(int fl=0; fl<=a; fl++)
                        {
                            for (int fa = 0; fa <=d; fa++)
                            {
                                if (e <= fa)
                                { 
                                    if (fa <= f) {
                                        i[fl, fa] = "x";
                                }
                                }else
                                {
                                    i[fl, fa] = " ";
                                }
                                
                            }
                            e--;
                            f++;
                        }
                        e++;
                        f--;
                        for (int fz = a; fz <=d; fz++)
                        {
                            for (int fx = 0; fx <=d; fx++)
                            {
                                if (e <= fx)
                                {if(fx <= f) {
                                    i[fz, fx] = "x";
                                }}
                                else
                                {
                                    i[fz, fx] = " ";
                                }

                            }
                            e++;
                            f--;
                        }
                        for(int o = 0; o <=d; o++)
                        {
                            for(int l = 0; l <=d; l++)
                            {
                                Console.Write($"{i[o, l]}");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}