using static System.Net.Mime.MediaTypeNames;

namespace Adivinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha a dificuldade");
                Console.WriteLine("(1) para Fácil = 15 chances \n(2) para Médio = 10 chances \n(3) para Difícil = 5 chances\n(4) para Desistir!");
                int dif = Convert.ToInt32(Console.ReadLine());
                int tentativas = 15;
                int pont = 1000;
                if (dif >= 1 && dif <= 4)
                {
                    if (dif == 2)
                    {
                        tentativas = 10;
                    }
                    else if (dif == 3)
                    {
                        tentativas = 5;
                    }
                    else if (dif == 4)
                    {
                        return;
                    }
                    Random rnd = new Random();
                    int chutagoras = rnd.Next(1, 20);
                    do
                    {
                        Console.WriteLine("##################################");
                        Console.WriteLine($"Qual o seu chute, você ainda tem {tentativas} chances");
                        Console.WriteLine("##################################");
                        int chu = Convert.ToInt32(Console.ReadLine());
                        if (chu > 0 && chu <= 20)
                        {
                            if (chu == chutagoras)
                            {
                                Console.WriteLine("------------------------");
                                Console.WriteLine("Parabéns você acertou, ganha bolo");
                                Console.WriteLine("------------------------");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("------------------------");
                                if (chu > chutagoras)
                                {
                                    Console.WriteLine("Você errou, o numero secreto é menor");
                                }
                                else
                                {
                                    Console.WriteLine("Você errou, o numero secreto é maior");
                                }
                                int mb = (chu - chutagoras) / 2;
                                if (mb < 0)
                                {
                                    mb = Math.Abs(mb);
                                }
                                pont -= mb;
                                Console.WriteLine($"Você ainda tem{pont} pontos");
                                Console.WriteLine("------------------------");
                            }
                            tentativas--;
                        }
                        else
                        {
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Insira um numero entre 1 e 20!!!");
                            Console.WriteLine("------------------------");
                        }
                    } while (tentativas > 0);
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Você perdeu tente novamente");
                    Console.WriteLine("------------------------");
                }
                else
                {
                    Console.WriteLine("Informe um numero de 1 a 4;");
                }
            }
        }
    }
}