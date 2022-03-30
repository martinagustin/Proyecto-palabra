using System;

namespace Proyecto_palabra
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Ingrese su palabra");
            //tring inputDate = Console.ReadLine();
            Console.WriteLine("---------------MENU------------\n\tQue desea?\t\n1-Invertir la palabra\n2-Primer letra mayuscula\n3-Cambiar letras por numeros");
            //Console.WriteLine(inputDate.PrimeraLetraMayus());
            string opcion = Console.ReadLine();
            string palabra;
            switch(opcion)
            {
                case "1":
                    Console.WriteLine("------INVERTER WORD-------\n Please input your word!");
                    palabra = Console.ReadLine();
                    Reverse(palabra);
                    break;
                case "2":
                    Console.WriteLine("-------FIRST LETTER UPPER--------\n Pleas input your word!");
                    palabra = Console.ReadLine();
                    if (palabra.Contains(" "))
                        Console.WriteLine("Por favor solo escriba una palabra");
                    else
                        Console.WriteLine(FirstMayus(palabra));
                    break;
                case "3":
                    Console.WriteLine("Please type word you want to convert");
                    palabra = Console.ReadLine();
                    Console.WriteLine(changeCharNum(palabra));
                    break;
            }

        }
        static void Reverse( string text)
        {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            Console.WriteLine(reverse);
        }
        static string FirstMayus(string text)
        {
            string fWord;
            return text[0].ToString().ToUpper() + text.Substring(1);
        }
        static string changeCharNum(string text)
        {
            string palabra="";
            text = text.ToLower();
            foreach (char letra in text)
            {
                switch(letra)
                {
                    case 'a':
                        palabra =(palabra+"4");
                        break;
                    case 'e':
                        palabra +="3";
                        break;
                    case 'i':
                        palabra +="1";
                        break;
                    case 'o':
                        palabra += "0";
                        break;
                    default:
                        palabra = (palabra + letra);
                        break;
                }
            }
            return palabra;
        }

        //static string request 
        //metodo para llamar y que solicite el readline

    }
}
