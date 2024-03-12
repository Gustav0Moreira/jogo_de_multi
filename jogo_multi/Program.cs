using System;

namespace jogo_multi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Bem-vindo ao jogo da multiplicação");
            string nome = Nome();
            Console.WriteLine("O jogo a seguir é simples! Você deve digitar o valor correto da multiplicação conforme o nível da tabuada");
            Multip();

            
            

        }
        static string Nome()
        {
            string nome = null;
            int control_1 = 0;
            while (control_1 == 0)
            {
                
                Console.WriteLine("Qual o seu nome?: ");
                nome = Console.ReadLine();
                Console.WriteLine("Seu nome é: " + nome + "?" + "\n 1-Sim \n 2-Não");
                int rep = int.Parse(Console.ReadLine());
                if (rep == 1)
                {
                    control_1++;
                    Console.WriteLine("É um prazer " + nome);

                }
                else
                {
                    Console.WriteLine("Vamos começar de novo...");
                    
                }
            }
            return nome;
            

        }

        static void Multip()
        {
            bool control_1 = true;
            int cont = 1;
            int cont_lv = 1;
            while (control_1)
            {
                Console.WriteLine("Nível: " + cont_lv);
                Console.WriteLine("Quanto é: " + cont + " X " + cont_lv);
                int rep = int.Parse(Console.ReadLine());

                if (rep == cont * cont_lv)
                {
                    Console.WriteLine("Parabéns você acertou!");
                    cont++;
                    if (cont > 10)
                    {
                        cont = 1;
                        cont_lv++;
                    }
                }
                else
                {
                    Console.WriteLine("Você errou, vamos de novo");
                }

            }
        }
    }
}