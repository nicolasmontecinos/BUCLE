using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //(MIERCOLES 3 DE OCTUBRE)(Tabla de multiplicar del 1 al 10)

            //int i = 0;
            //int num;

            //Console.WriteLine("Introduce un numero");
            //num = Convert.ToInt32(Console.ReadLine());

            //while (i < 11)
            //{
            //    Console.WriteLine(num + "x" + i + "=" + (num * i));
            //    i++;

            //}

            //Console.ReadLine();


            ////Programa que muestre los numeros del 1 al 100 con bucle WHILE

            //i = 0;

            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //Console.ReadLine();




            //EJERCICIO DO WHILE

            //Console.ReadLine();
            ////Programa que muestre los numeros del 1 al 100 con bucle WHILE

            //i = 0;

            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //Console.ReadLine();


            //PEDIR NUMEROS HASTA QUE SE INTRODUZCA UNO NEGATIVO


            //int numero;

            //Console.WriteLine("Introduzca un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //while (numero >= -1 && numero <= 12)
            //{
            //    Console.WriteLine("Introduzca un numero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //}


            //EJERCICIO CON BUCLE (FOR)

            //for (int il = 0; il <= 30; il = il + 3)
            //{
            //    Console.WriteLine(il);


            //}

            //Console.ReadLine();



            //PEDIR 4 NUMEROS Y QUE ESCRIBA LA SUMA TOTAL (BUCLE FOR)

            //VARIABLES

            //int contador = 1;
            //int num;
            //int suma = 0;

            //while (contador <= 4)
            //{
            //    Console.WriteLine("Introduzca numero 1");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    contador = contador + 1;
            //}



            //Console.ReadLine();

            //PEDIR 4 NUMEROS Y QUE ESCRIBA LA SUMA TOTAL (BUCLE FOR)(EJEMPLO DE ARRATE)


            //int sum=0 ;
            //int nume;


            //for (int it = 0; it < 4; it++)
            //{
            //    Console.WriteLine("INtroduce un numero\n");

            //    nume = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + nume;
            //}

            //Console.WriteLine("Total" + sum);

            //Console.ReadLine();




            ////EJERCICIOS BUCLE(DOCUMENTO WORD)(MIERCOLES 3 DE OCTUBRE)

            /*(1)Escribe un programa que muestre en pantalla los números del 10 al 20
             (incluidos los dos) con una línea vacía entre ellos.*/


            //Console.WriteLine("Escriba un numero");

            //int i = 10;


            //for (i = 10; i <= 20; i++) 
            //{
            //    Console.WriteLine(" el resultado " + i +" \n");

            //}

            //Console.ReadLine();





            /*(2)Escribe un programa que muestre en pantalla los números del 20 al 10
             (incluidos los dos) con una línea vacía entre ellos.*/

            //Console.WriteLine("Escriba un numero");

            //int ite = 20;


            //for (ite = 20; ite >= 10; ite--)
            //{
            //    Console.WriteLine(" el resultado " + ite + " \n");

            //}

            //Console.ReadLine();


            //(3)Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.//


            //VARIABLES


            //double sum = 0;
            //int nume;

            //for (int it = 0; it < 10; it++)
            //{
            //    Console.WriteLine("INtroduce un numero\n");

            //    nume = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + nume;
            //}

            //Console.WriteLine("Media" + sum / 10);

            //Console.ReadLine();
            /////////////////PRUEBA FALLIDA DE EJERCICIO//////////////////////////

            //int contador = 1;
            //int num;
            //int suma = 0;

            //while (contador <= 10)
            //{
            //    Console.WriteLine("Introduzca numero 1");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    contador = contador + 1;
            //}

            //Console.ReadLine();


            /*(4)Escribe un programa que pida valores hasta que el usuario introduzca un 0.
             Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran
             los valores negativos. Mostrar la suma de los valores introducidos.*/

            ///////////////////////////////////P-E-N-D-I-E-N-T-E//////////////////////////////////////////

            //double suma = 0;
            //int numero;
            //int i = 0;

            //Console.WriteLine("INtroduce un numero\n");



            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //}

            //while (i <= 0);

            //Console.ReadLine();


















            //numero = Convert.ToInt32(Console.ReadLine());
            //suma = suma + numero;

            //Console.WriteLine(suma);

            //Console.ReadLine();

            /*(5)Escribe un programa que muestre todos los valores pares o impares entre 1 y 100
             dependiendo de si el usuario introduce P o I . Si introduce
             otra cosa, decir que ese valor no es correcto y pedirle otra vez.(EJEMPLO ARRATE)*/

            //String respuesta = "";

            //while (respuesta != "P" && respuesta != "I")
            //{
            //    Console.WriteLine("Escribe P o I");
            //    respuesta = Console.ReadLine();
            //}

            //if (respuesta=="P")

            //{
            //    for (int i =2; i <101;i=i+2)
            //    {

            //        Console.WriteLine(i);
            //    }

            //}
            //else

            //{
            //    for (int i = 1; i<101; i= i+2)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.ReadLine();









            /*(7)Pedir al usuario un número. Mostrar en pantalla 
                *
                **
                ***  Con tantas líneas como el número que ha introducido*/

            //int num;


            //Console.WriteLine("Introduzca un numero");
            //num = Convert.ToInt32(Console.ReadLine());









            //////////////////////////////E-J-E-R-C-I-C-I-O-S  I-K-E-R-////////////////////////////////

            /*(2)Mostrar en pantalla los números del 48 al 43 (incluidos 48 y 43).
             Hacerlo tres veces, una con for, una con while y una con do while*/

            ///FOR//

            for (int num = 43; num <= 48; num++)
            {
                Console.WriteLine(num);


            }

            Console.ReadLine();


            //WHILE//


            //int numero = 48;


            //while (numero > 43)
            //{
            //    Console.WriteLine(numero);
            //    numero--;
            //}
            //Console.ReadLine();


            //DO WHILE//

            //int numm = 48;

            //do
            //{
            //    Console.WriteLine(numm);
            //    numm--;
            //}


            //while (numm >= 43);

            //Console.ReadLine();














            //int numero;

            //Console.WriteLine("Introduzca un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //while (numero >= -1 && numero <= 12)
            //{
            //    Console.WriteLine("Introduzca un numero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //}






        }



    }

}
