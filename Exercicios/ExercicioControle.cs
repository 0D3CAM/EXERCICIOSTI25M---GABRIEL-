using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
     class ExercicioControle
    {
        ExercicioModel modelo; //conectando classe model e control 
        private int opcao;

        public ExercicioControle()
        {
            this.modelo = new ExercicioModel();
            SetOpcao (0);
        }//Fim do construtor padrão

        public int GetOpcao()
        {
            return this.opcao;
        }//fim GetOpcao

        public void SetOpcao(int opcao)
        {
            this.opcao = opcao;
        }//fim do set

        public void Coletar()
        {
            Console.Write("Digite o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //passar para construtor com parametro
            this.modelo = new ExercicioModel(num1, num2);
        }//fim Coletar = pegar 2 numeros digitados

        public void ColetarReal()
        {
            //Pegar dois numeros
            Console.WriteLine("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Chamar construtor que recebe reais
            this.modelo = new ExercicioModel(num1,num2);
        }
        
            //Mostrar as opções de operação na tela
        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n" +
                              "0.Sair\n" +
                              "1.Soma\n" +
                              "2.Subtração\n" +
                              "3.Divisão\n" +
                              "4.Multiplicação\n" +
                              "5.Potência\n" +
                              "6.Potência com parâmetros\n" +
                              "7.Raiz\n" +
                              "8.Raiz com parâmetros\n" +
                              "9.Exercício 1 \n" +
                              "10.Exercício 2 \n" +
                              "11.Exercício 3");
                              
            SetOpcao(Convert.ToInt32(Console.ReadLine()));//Console.ReadLine so le string
            Console.Clear();//Limpa o console
        }//fim do menu 

        //executar menu
        public void ExecutarMenu()
        {
            do
            {
                Menu();//Mostrar opções
                switch (GetOpcao())
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//pegar dois numeros
                        Console.WriteLine("\n A soma é: " + this.modelo.Somar());//fazer operação de soma
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("\n A subtração é: " + this.modelo.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        //validação
                        if (this.modelo.Dividir() == -1)
                        {
                            Console.WriteLine("\n Impossivel dividir por 0");
                        }
                        else if (this.modelo.Dividir() == -2)
                        {
                            Console.WriteLine("\n Impossivel dividir por numeros negativos");
                        }
                        else
                        {
                            Console.WriteLine("\n A divisão é:  " + this.modelo.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("\n A multiplicação é: " + this.modelo.Multiplicar());
                        break;
                    case 5:
                        ColetarReal();
                        Console.WriteLine("\n A potência é: " + this.modelo.Potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("Informe o expoente: ");
                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostrar o resultado operação 
                        Console.WriteLine("A potência é: " + this.modelo.Potencia (bas, expoente));
                        break;
                    case 7:
                        ColetarReal();
                        Console.WriteLine("\n A raiz do primeiro numero é: " + this.modelo.RaizNum3());
                        Console.WriteLine("\n A raiz do segundo numero é: " + this.modelo.RaizNum4());
                        break;
                    case 8:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        //Chamar método que calcula raiz
                        Console.WriteLine("A Raiz do primeiro número é: " + this.modelo.Raiz(num1));
                        Console.WriteLine("A Raiz do segundo número é: " + this.modelo.Raiz(num2));
                        break;
                    case 9:
                        Console.WriteLine("Digite o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine(this.modelo.Exercicio01(ano));
                        break;
                    case 10:
                            Console.WriteLine("Digite um número: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                        if(this.modelo.Exercicio02(numero) == -1)
                        {
                            Console.WriteLine("Está no intervalo");
                        }
                        else
                        {
                            Console.WriteLine("Não está no intervalo");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Digite sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio03(idade)); 
                        break;
                    case 12:
                        Console.WriteLine("Digite o primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro número: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());

                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida!");
                        break;

                }//fim do escolha
            } while (GetOpcao() != 0);// fim do... while
        }//fim do metodo executar menu

    }// fim da classe 
}// fim do projeto