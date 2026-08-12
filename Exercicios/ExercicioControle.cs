using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
                              "11.Exercício 3 \n" +
                              "12.Exercício 4 \n"+
                              "13.Exercício 5 \n"+
                              "14.Exercício 6 \n"+
                              "15.Exercício 7 \n"+
                              "16.Exercício 8 \n"+
                              "17.Exercício 9 \n"+
                              "18.Exercício 10 \n"+
                              "19.Exercício 11 \n");
                              
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
                        Console.WriteLine("A potência é: " + this.modelo.Potencia(bas, expoente));
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
                        if (this.modelo.Exercicio02(numero) == -1)
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
                        double num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio04(num1, num2, num3));
                        break;
                    case 13:
                        Console.WriteLine("Digite o primeiro número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro número: ");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quarto número: ");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quinto número: ");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o sexto número: ");
                        int num6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o sétimo número: ");
                        int num7 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o oitavo número: ");
                        int num8 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o nono número: ");
                        int num9 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o décimo número: ");
                        int num10 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o número que deseja buscar: ");
                        int buscar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio05(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, buscar));
                        break;
                    case 14:
                        Console.WriteLine("Informe o tamanho do lado 1");
                        int lado1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o tamanho do lado 2");
                        int lado2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o tamanho do lado 3");
                        int lado3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio06(lado1, lado2, lado3));
                        break;
                    case 15:
                        Console.WriteLine("Digite um número de 1 a 7");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio07(dia));
                        break;
                    case 16:
                        string senha = "";
                        do
                        {
                            Console.WriteLine("Digite sua senha: ");
                            senha = Console.ReadLine();                      
                            Console.WriteLine(this.modelo.Exercicio08(senha));
                        } while(senha != "1234");
                        break;
                    case 17:
                        Console.WriteLine("Digite um horário");
                        DateTime hora1 = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Digite outro horário");
                        DateTime hora2 = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio09(hora1, hora2));
                        break;
                    case 18:
                        Console.WriteLine("Digite um número");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro número");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio10(num1,num2));
                        break;
                    case 19:
                        Console.WriteLine("Digite o número 1: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o número 2: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o número 3: ");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o número 4: ");
                        num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o número 5: ");
                        num5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio11(num1, num2, num3, num4, num5));
                        break;
                    case 20:
                        int resultado = 0;
                        int num = 0;
                        do {
                            Console.WriteLine("Digite um número:");
                            num = Convert.ToInt32(Console.ReadLine());
                            resultado = this.modelo.Exercicio12(num);
                            Console.WriteLine(resultado);
                        }
                        while(resultado < 100);
                        Console.WriteLine("O valor final é: " + resultado);
                        break;
                        
                    case 21:
                        int contador = 0;
                        do
                        {
                           Console.WriteLine("Digite sua senha: ");
                           senha = Convert.ToString(Console.ReadLine());
                           Console.WriteLine(this.modelo.Exercicio08(senha));
                            if (senha == "1234")
                            {
                                break;         
                            }
                            else
                            {
                                contador += 1;
                            }
                        } while (contador < 3);
                        break;
                    case 22:
                        contador = 0;
                        int maior;
                        int menor;
                        do
                        {
                            Console.WriteLine("Digite um número");
                            num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(this.modelo.Exercicio14(num, maior, menor));
                            contador++;
                        }
                        while (contador < 10);
                        Console.WriteLine("O maior número digitado foi: " + maior);
                        Console.WriteLine("O menor número digitado foi: " + menor);
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida!");
                        break;

                }//fim do escolha
            } while (GetOpcao() != 0);// fim do... while
        }//fim do metodo executar menu

    }// fim da classe 
}// fim do projeto