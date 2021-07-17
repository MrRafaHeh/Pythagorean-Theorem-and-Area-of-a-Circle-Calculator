using System;

namespace SoloLearn_2_
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.Title =
                "Calculadora";


            
            const double pi = 3.14;
            bool radio;
            double Area;
            string respuesta;
            bool radio2;
            string calculadora;

            Console.WriteLine("Seleccione el tipo de calculadora que desea usar");
            Console.WriteLine("escribe (1) si es que deseas calcular el area de un circulo");
            Console.WriteLine("Escribe (2) si es que deseas calcular teorema de pitagoras");

            calculadora = Console.ReadLine();
            // Aqui elejimos el tipo de calculadora para el programa, si la calucladora es = Area Circulo

            if (calculadora == "1")
            {








                Console.WriteLine("Perfecto ahora coloca el radio de tu circulo y el calculo se completara automaticamente");

                radio = double.TryParse(Console.ReadLine(), out double result);




                if (radio == true)
                {
                    radio2 = true;
                    if (radio2 == true)
                    {
                        Area = (result * result) * pi;
                        //conseguir que no de error si la variable no es doble
                        //LO HICEEEEEEEEEEEEEEEEE SIUUUUUUUUUU









                        Console.WriteLine("El Area de tu Circulo es  {0} ", Area);
                        Console.WriteLine("Estoy en lo ¿Correcto?, si es asi Coloca: Correcto");
                        Console.WriteLine("Si me equivoque, escribe: Incorrecto");
                        respuesta = Console.ReadLine();

                        if (respuesta == "Correcto" || respuesta == "correcto")
                        {
                            Console.WriteLine("Oh. Increible Intentemoslo otra vez, reinicia el programa");

                        }


                        else if (respuesta == "Incorrecto" || respuesta == "incorrecto")
                        {
                            Console.WriteLine("Oh... que extraño eso nunca pasa, reinicia el programa y intentalo denuevo");
                        }


                        else
                        {
                            Console.WriteLine("Creo que no te entiendo, asegurate de escribir bien");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Error en la sintaxis de el problema");
                    }





                }

                else
                {
                    Console.WriteLine("Error de Sintaxis, reinicie el programa e intentelo denuevo (Recuerde que en la calculadora tipo: area circulo)");
                    Console.WriteLine("No se aceptan Letras o otro tipo de formatos");

                }



            }

            // aqui termina IF 1---------------------------------------------------------------------------------------------------------------------------------------------------

            if (calculadora == "2")
            {
                bool variable;

                Console.WriteLine("perfecto selecciona que variable quieres usar (Cateto o Hipotenusa)");
                Console.WriteLine(" seleciona (1) para cateto");
                Console.WriteLine("selecciona (2) para hipotenusa");
                variable = double.TryParse(Console.ReadLine(), out double i);

                if (i == 1)
                {
                    bool cateto1;
                    bool hipotenusa;
                    double calculo;
                    double raiz;
                    bool lol = false;
                    Console.WriteLine("Perfeccto calculemos cateto");
                    Console.WriteLine("Coloca el valor de ");
                    Console.WriteLine("Cateto 1");
                    Console.WriteLine("Hipotenusa");
                    Console.WriteLine("Escribelos en el mismo orden, de lo contrario el calculo sea errado");
                    
                    cateto1 = double.TryParse(Console.ReadLine(), out double cat);
                    hipotenusa = double.TryParse(Console.ReadLine(), out double hipo);
                    if (cateto1 == true || hipotenusa == true)
                    {
                        raiz = 0;
                        
                        
                        if (hipo * hipo > cat * cat )
                        {
                            raiz = hipo * hipo - cat * cat;
                            Console.WriteLine("paso 1");
                            
                        }
                        else
                        {
                            Console.WriteLine("Ejercicio mal planteado, los catetos no pueden ser mayor que la hipotenusa");
                        }
                        Console.WriteLine("{0} seria la raiz cuadrada", raiz);

                        calculo = 40;
                            //el orden de mayor a menor siempre es en relacion a raiz

                            if (calculo * calculo < raiz)
                            {
                                calculo = 60;

                                if (calculo * calculo < raiz)
                                {

                                    while (calculo * calculo < raiz)

                                    {
                                        calculo = ++calculo;

                                    }
                                    Console.WriteLine("Proceso 2,5 {0}", calculo);
                                }


                                if (calculo * calculo > raiz)
                                {

                                    while (calculo * calculo > raiz)
                                    {
                                        calculo = --calculo;

                                    }
                                    Console.WriteLine("Proceso 2 {0}", calculo);
                                }


                            }
                            if (calculo * calculo > raiz)
                            {
                                calculo = 20;
                                if (calculo * calculo < raiz)
                                {
                                    while (calculo * calculo < raiz)
                                    {
                                        calculo = ++calculo;


                                    }

                                    Console.WriteLine("Proceso 1,5 {0}", calculo);
                                }
                                if (calculo * calculo > raiz)
                                {
                                    while (calculo * calculo > raiz)
                                    {
                                        calculo = --calculo;




                                    }

                                    Console.WriteLine("Proceso 1 {0}", calculo);

                                }

                            }



                        if (calculo * calculo != raiz)
                        {


                            lol = true;

                            if (calculo * calculo > raiz)
                            {


                                while (calculo * calculo != raiz && calculo * calculo > raiz)
                                {
                                    

                                    calculo -= 0.01d;


                                }
                                Console.WriteLine("Proceso 0.5 {0}", calculo);
                            }
                            if (calculo * calculo < raiz)
                            {
                                while (calculo * calculo != raiz && calculo * calculo  < raiz)
                                {
                                    
                                    
                                    calculo += 0.01d;
                                   
                                    
                                }
                                Console.WriteLine("Proceso 0 {0}", calculo);
                            }

                            
                        }

                        
                        

                        
                        double resultado = (Math.Truncate (calculo * 100) / 100); 

                        if (lol == true)
                        {
                            Console.WriteLine(" Lo tengo!!, el resultado es   {0}  ", resultado);
                        }
                        if (calculo * calculo == raiz)
                        {


                            Console.WriteLine(" Lo tengo!!, el resultado es {0} ", calculo);

                        }


                        else if (calculo * calculo != raiz && (calculo + 0.01 * calculo + 0.01) == raiz)
                        
                        {
                            Console.WriteLine("Error, ninguno de os caracteres que ingreso es valido, le recuerdo que en esta calculadora no se aceptan letras");
                        }
                    }

                }
                if (i == 2)
                {
                    bool cati1;
                    bool cati2;
                    double a1;
                    double a2;
                    double pantufla;
                    bool zapato = false;
                    Console.WriteLine("Perfecto, entonces indicame el valor de:");
                    Console.WriteLine("Cateto 1");
                    Console.WriteLine("Cateto 2");
                    Console.WriteLine("En ese mismo orden, de lo contrario el calculo sera errado");
                     cati1 = double.TryParse(Console.ReadLine(), out double kati1);
                    cati2 = double.TryParse(Console.ReadLine(), out double kati2);
                    if (cati2 == true && cati1 == true)
                    {
                        //Raiz
                        a1 = kati1 * kati1 + kati2 * kati2;
                        a2 = 40;
                        //primer if
                        Console.WriteLine(a1);
                        if (a2 * a2 < a1 )
                        {
                            
                            while (a2 * a2 < a1)
                            {
                                ++a2;
                            }
                            Console.WriteLine("Proceso 2 {0}", a2);
                        }
                        if (a2 * a2 > a1)
                        {
                            
                            while (a2 * a2 > a1)
                            {
                                --a2;
                            }
                            Console.WriteLine("Proceso 1 {0}", a2);
                        }
                        if (a2 * a2 != a1)
                        {
                            zapato = true;
                            
                            while (a2 * a2 < a1)
                            {
                                a2 += 0.01;
                            }
                            
                            while (a2 * a2 > a1)
                            {
                                a2 -= 0.01;
                            }
                            Console.WriteLine("Proceso 0 {0}", a2);
                        }
                        if (a2 * a2 == a1)
                        {
                            Console.WriteLine("Lo tengo!, la hipotenusa vale {0}", a2);

                        }
                        
                        pantufla = (Math.Truncate (a2 * 100) / 100);

                        
                        if (zapato == true)
                        {
                            Console.WriteLine("Lo tengo!, la hipotenusa vale {0}", pantufla);
                        }

                    }
                    else
                    {
                        Console.WriteLine("No se aceptan digitos que no sean numeros");
                    }
                }
               

            }

            







     
        
        }

        
        
    } 


}