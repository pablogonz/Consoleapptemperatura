using System;
using temperaturekata;
namespace demopac
{
    class Program
    {
        static void Main(string[] args)
        {

            double temperature;
            Console.Write("Introduzca una temperatura:");
            Console.WriteLine(" seleccione la escala  a la que quiere convertirla?");
            Console.WriteLine(@"
1- celcius to fahrenheit
2- fahrenheit to celcius
3-celcius to kelvin
4-fahrenheit to kelvin");

            int caso = Convert.ToInt32(Console.ReadLine());

            switch (caso)
            {
                case 1:
                    Console.WriteLine(temperaturekata.ctof(temperature));
                    break;
                case 2:
                    Console.WriteLine(temperaturekata.ftoc(temperature));
                    break;
                case 3:
                    Console.WriteLine(temperaturekata.ctok(temperature));
                    break;
                case 4:
                    Console.WriteLine(temperaturekata.ftok(temperature));
                    break;


                default:
                    break;
            }
        }
    }
}