using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel
    {
        // área para declaração de variaveis globais
        private int num1;
        private int num2;
        private double num3;
        private double num4;
        private int resultado;
        private int idade;
        //Método construtor: instancia valores na memória
        public ExercicioModel()
        {
            SetNum1(0);
            SetNum2(0);
            SetResultado(0);
            SetIdade(0);
        }//fim do metodo construtor

        public ExercicioModel(int num1, int num2)
        {
            SetNum1(num1);
            SetNum2(num2);
            SetResultado(0);

        }//fim do metodo construtor

        public ExercicioModel(double num1, double num2)
        {
            SetNum3(num1);
            SetNum4(num2);
        }

        //Métodos GETS E SETS (GET = OBTER/SET = ALTERAR)

        public int GetNum1()
        {
            return this.num1;
        }// fim do getNum1

        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }// fim do SetNum1

        public int GetNum2()
        {
            return this.num2;
        }// fim do getNum2

        public void SetNum2(int num2)
        {
            this.num2 = num2;
        }// fim do SetNum2

        public double GetNum3()
        {
            return this.num3;
        }// fim do getNum3
        public void SetNum3(double num3)
        {
            this.num3 = num3;
        }// fim do SetNum3

        public double GetNum4()
        {
            return this.num4;
        }// fim do getNum4
        public void SetNum4(double num4)
        {
            this.num4 = num4;
        }// fim do SetNum4

        public int GetIdade()
        {
            return this.idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }//fim do SetIdade





        public int GetResultado()
        {
            return this.resultado;
        }// fim do método resultado

        public void SetResultado(int resultado)
        {
            this.resultado = resultado;

        } //Fim do método resultado

        public int Somar()
        {
            return this.num1 + this.num2;
        }//fim método soma

        public int Subtrair()
        {
            SetResultado(GetNum1() - GetNum2());
            return GetResultado();
        }

        public int Multiplicar()
        {
            SetResultado(GetNum1() * GetNum2());
            return GetResultado();
        }

        public double Dividir()
        {
            if (GetNum2() == 0)
            {
                return -1;
            }
            else if (GetNum2() < 1)
            {
                return -2;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();
            }
        }// fim do dividir

        public double Potencia(double bas, double expoente)
        {
            return Math.Pow(bas, expoente);
        }// fim da potencia

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//fim da raiz

        public double Potencia()
        {
            return Math.Pow(GetNum3(), GetNum4());
        }

        public double RaizNum3()
        {
            return Math.Sqrt(GetNum3());
        }

        public double RaizNum4()
        {
            return Math.Sqrt(GetNum4());
        }

        public string Exercicio01(int ano)
        {
            if (ano % 4 == 0)
            {
                return ano + " É bissexto! \n";
            }
            else
            {
                return ano + " Não é Bissexto \n";
            }
        }
        public int Exercicio02(int numero)//Verifique se um número está entre 100 e 200. 

        {
            if (numero >= 100 && numero <= 200)
            {
                return -1;
            }
            else
            {
                return -2;
            }
        }

        public string Exercicio03(int idade)
        {
            if (idade >= 16 && idade < 18)
            {
                return ("Pode votar, porém não obrigatório \n");
            }
            else if (idade >= 18)
            {
                return ("Voto Obrigatório \n");
            }
            else
            {
                return ("Não pode votar \n");
            }
        }

        public string Exercicio04(double num1, double num2, double num3)
        {
            if (num3 >= num1 && num3 <= num2)
            {
                return ("O número está dentro do intervalo");
            }
            else
            {
                return ("O número está fora do intervalo");
            }
        }

        public string Exercicio05(double num1, double num2, double num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10, int buscar)
        {
            if (buscar == num1)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num2)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num3)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num4)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num5)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num6)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num7)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num8)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num9)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else if (buscar == num10)
            {
                return "O número " + buscar + " está no intervalo";
            }
            else
            {
                return "O número " + buscar + " não está no intervalo";
            }
        }

        public string Exercicio06(int lado1, int lado2, int lado3)
        {
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                return "Digite valores maiores que 0";
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                return "O triângulo é equilátero \n";
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                return "O triângulo é escaleno \n";
            }
            else
            {
                return "O triângulo é isósceles \n";
            }
        }


        public string Exercicio07(int dia)
        {
            if (dia == 1)
            {
                return "Domingo \n";
            }
            else if (dia == 2)
            {
                return "Segunda-Feira \n";
            }
            else if (dia == 3)
            {
                return "Terça-Feira \n";    
            }
            else if (dia == 4)
            {
                return "Quarta-Feira \n";
            }
            else if (dia == 5)
            {
                return "Quinta-Feira \n";
            }
            else if (dia == 6)
            {
                return "Sexta-Feira \n";
            }
            else if (dia == 7)
            {
                return "Sábado \n";
            }
            else
            {
                return "Dia inválido \n";
            }
        }
        public string Exercicio08(string senha)
        {
        if (senha == "1234")
            {
                return "Senha correta.";
            }
        else
            {
                return "Senha inválida, tente novamente";
            }
        }
        public string Exercicio09(DateTime hora1, DateTime hora2)
        {

            if (hora1 == hora2)
            {
                return "Horas iguais";
            }
            else if (hora1 > hora2) 
            {
                return ("Hora " + hora1 + " é mais tarde");
            }
            else
            {
                return ("Hora " + hora2 + " é mais tarde");
            }
        }

        public string Exercicio10(double num1, double num2)
        {
            if (num1 > num2)
            {
                return "O "+ num1 + " é maior que  " + num2;
            }
            else
            {
                return "O " + num2 + " é maior que " + num1;
            }    
        }

        public string Exercicio11(double num1, double num2, double num3, double num4, double num5)
        {
            double media = (num1 + num2 + num3 + num4 + num5) / 5;
            return "A média é : " + media;
        }


    }// fim da classe
}// fim do projeto

