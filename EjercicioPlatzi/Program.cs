using System;
using System.Collections.Generic;

namespace EjercicioPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué ejercicio te gustaría ejecutar?");
            var input = 0;
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    ExecEx01();
                    break;
                case 2:
                    ExecEx02();
                    break;
                case 3:
                    ExecEx03();
                    break;
                case 4:
                    float numero1, numero2;
                    ExecEx04(out numero1, out numero2);
                    break;
                case 5:
                    ExecEx05();
                    break;
                case 6:
                    ExecEx06();
                    break;
                case 7:
                    ExecEx07();
                    break;
                case 8:
                    ExecEx08();
                    break;
                case 9:
                    ExecEx09();
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        /*Reto #1 “Hola Mundo”
        Instrucciones: este es un clásico de clásicos, pero haremos un pequeño cambio.
        En lugar de solo imprimir un mensaje en pantalla, pedirás al usuario que digite un nombre y mostrarás en pantalla lo siguiente: Hola, [nombre]*/
        private static void ExecEx01()
        {
            Console.WriteLine("Hola, escriba su nombre");
            string nombre;
            nombre = Console.ReadLine();
            Console.WriteLine("Hola,  " + nombre);

        }

        /*Reto #2 “Hola… nombre y apellido:”
         Instrucciones: Ahora que sabemos incluir nombres, podemos agregar más datos. 
         Intentemos con un apellido para tener algo así:Hola, [nombre] [apellido]*/
        private static void ExecEx02()
        {
            string nombre;
            string apellido;
            Console.WriteLine("Hola, escriba su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Hola,  " + nombre + " " + apellido);

        }

        /*Reto #3 “Mensaje multilínea”:
          Instrucciones: seguro has visto que en Platzi hay más de 600 cursos 
         ¿puedes mostrar a que categorías corresponden en una sola línea de código?*/
        private static void ExecEx03()
        {
            var categorias = new List<string>
            {"Desarrollo e Ingenieria","Diseño y UX",
             "Marketing","Negocios y emprendimiento","Producción Audiovisual",
             "Crecimiento Profesional"};
            Console.WriteLine("Platzi cuenta con cursos de:");

            foreach (string categoria in categorias)
            {
                Console.WriteLine(categoria);
            }

        }

        /* Reto #4 “Suma de enteros”
        Instrucciones: otro clásico conocido, donde pedirás al usuario que ingrese 2 números y muestre en pantalla el resultado.
        Si quieres añadir más dificultad puedes utilizar números con punto decimal y especificar el número de decimales después del punto.*/
        private static void ExecEx04(out float numero1, out float numero2)
        {
            float total;

            Console.WriteLine("Escribir el primer número:");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escribir el segundo número:");
            numero2 = float.Parse(Console.ReadLine());

            total = numero1 + numero2;
            Console.WriteLine(numero1 + "+" + numero2 + "=" + total);

        }


        /*Reto #5 “Suma y multiplicación”
        Instrucciones: añadiendo un extra al reto anterior ahora el usuario ingresará 3 números, 
        sumarás los 2 primeros y el resultado será multiplicado por el tercero. 
        Añade las consideraciones del punto decimal del reto anterior.*/
        private static void ExecEx05()
        {
            int numero1;
            int numero2;
            int numero3;
            int resultado;

            Console.WriteLine("Ingresar el primer número:");

            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el segundo número:");

            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el tercer número:");

            numero3 = int.Parse(Console.ReadLine());

            resultado = (numero1 + numero2) * numero3;

            Console.WriteLine("Resultado: " + resultado);
        }

        /*Reto #6 “Resta de pizzas”
        Instrucciones: llegaste a una fiesta con X cantidad de rebanadas de pizza(indicadas por el usuario),
        después de un rato se consumió Y cantidad de rebanadas y quedan Z.*/
        private static void ExecEx06()
        {
            int rodajasInicio;
            int rodajasFin;
            int total;

            Console.WriteLine("¿Cuántas rodajas tiene la pizza?");
            rodajasInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántas rodajas se ha comido?");
            rodajasFin = int.Parse(Console.ReadLine());

            total = rodajasInicio - rodajasFin;
            Console.WriteLine("restan " + total + " rodajas.");
        }

        /*Reto #7 “Edad futura y pasada”
         Instrucciones: pide al usuario que indique su nombre y su edad. 
         Como mensaje de salida le indicarás que edad tuvo el año pasado y cuantos años tendrá el siguiente año.
         Ejemplo: [nombre] el año pasado tenías X años y el próximo año cumplirás Y años.*/
        private static void ExecEx07()
        {
            int lastYear;
            int nextYear;

            Console.WriteLine("¿Cuál es tu nombre?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("¿Cuántos años tenes?");
            int age;
            age = int.Parse(Console.ReadLine());

            lastYear = age - 1;
            nextYear = age + 1;
            Console.WriteLine(name + " el año pasado tenías " + lastYear + " años y el próximo año cumplirás " + nextYear + " años");
        }

        /*Reto #8 “Divide la cuenta”
        Instrucciones: vas con tus amigos a tu restaurante favorito y acuerdan dividir la cuenta. 
        Para facilitar las cosa pedirás al usuario que indique el total a pagar, entre cuantas personas se dvidirá la cuenta, porcentaje de propina a incluir,
        un porcentaje de impuestos, total a pagar incluyendo propina más impuestos y el total a pagar por cada persona.*/
        private static void ExecEx08()
        {
            float cuenta, porcentajeImpuestos, impuestos, porcentajePropina, propina, comensales, total, totalPersona;

            Console.WriteLine("Monto de la cuenta");
            cuenta = float.Parse(Console.ReadLine());

            Console.WriteLine("Número de comensales?");
            comensales = float.Parse(Console.ReadLine());

            Console.WriteLine("Porcentaje de impuestos");
            porcentajeImpuestos = float.Parse(Console.ReadLine());

            Console.WriteLine("Porcentaje de propina");
            porcentajePropina = float.Parse(Console.ReadLine());

            impuestos = ((cuenta * porcentajeImpuestos) / 100);
            propina = (cuenta * porcentajePropina) / 100;
            total = cuenta + propina + impuestos;
            totalPersona = total / comensales;
                       
            Console.WriteLine("Impuestos $" + impuestos);

            Console.WriteLine("Popina $" + propina);

            Console.WriteLine("Total a Pagar $" + total);

            Console.WriteLine("Total a Pagar por persona $" + totalPersona);

        }

       /* Reto #9 “Calculando días”
        Instrucciones: escribe un programa al que le indiques una cantidad de días y como resultado deberá mostrar cuantas horas, minutos y segundos hay en dicha cantidad de días.*/
        private static void ExecEx09()
        {
            int dias, horas, minutos, segundos;
            Console.WriteLine("Ingrese un número de días:");
            dias = int.Parse(Console.ReadLine());
            horas = dias * 24;
            minutos = horas * 60;
            segundos = minutos * 60;

            Console.WriteLine(dias + " días tiene " + horas + " horas, o " + minutos + " minutos, o " + segundos + " segundos.");

        }


    }

}
