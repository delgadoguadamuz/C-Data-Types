using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program
    {
        //enum: enumeraciones , se declaran a nivel de clase
        enum Days { Dom, Lun, Mar, Mier, Vier, Sab };
    
        static void Main(string[] args)
        {
            // int : tipo entero, valor numero de -2000000000 a 2000000000 de 32bits
            //Declaracion
            int age;
            //Inicializacion
            age = 18;
            //Declaracion con inicializacion
            int year = 2017;

            // bool: valor tipo booleano, almacena true o false
            bool active = false;
            // por defecto es false

            //byte: numero de 0 a 255, 8bits
            byte position = 1;

            //char: es un caracter U+0000 a hasta U+FFFF, unicode de 16bits
            char type = 'a';

            //decimal: -7.9*10^28 a -7.9*10^2, 29 numeros despues del punto (.)
            decimal pi = 3.14m;

            //double: -5*10^-324 a -5*10^308, 16 digitos 
            double distance = 100.5;

            // float: numero -3.4*10^38 a 3.4*10^38, 7 digitos de largo
            float x = 3.5f;

            //long: -9,000,000,000,000,000,000 a 9,000,000,000,000,000,000 64bits
            long code = 204957458734857348;

            // sbyte -127 a 127, 8bits
            sbyte status = -127;

            //short: -32,000 a 32,000, 16bits
            short pbi = 3459;

            //uint: 0 a 4,000,000,000 32bits unsigned
            uint myUnit = 7584358;

            //ulong: -9,000,000,000,000,000,000 a 9,000,000,000,000,000,000 64bits, unsigned
            ulong code = 204957458734857348;

            //ushort: -32,000 a 32,000, 16bits, unsigned
            ushort pbi = 3459;




        }
    }

    struct Book
    {
        decimal price;
        string name;
        int code;


    }
}
