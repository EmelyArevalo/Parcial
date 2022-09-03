using System;
using System.Collections;

namespace Parcial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int validar = 0;
            //Preguntamos el numero de estudiantes que desea ingresar 
            do
            {
                Console.WriteLine("favor ingrese el numero de estudiantes que desea ingresar");
                int numEs = int.Parse(Console.ReadLine());
                int contador = 0;
                ArrayList lista = new ArrayList();
                string name;
                double lab1;
                double lab2;
                double parcial;

            //Programamos el ciclo while 

                while (contador < numEs)
                {
                    Console.WriteLine("Escriba el nombre del estudiante: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Escriba la nota del laboratorio 1: ");
                    lab1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la nota del laboratorio 2: ");
                    lab2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la nota del parcial: ");
                    parcial = double.Parse(Console.ReadLine());

                    double notaFinal = NotaFinal(lab1, lab2, parcial);
                    string apr = Aprob(notaFinal);

                    Estudiantes estudiantes = new Estudiantes { Nombre = name, NotaFinal = notaFinal, Aprob = apr };
                    lista.Add(estudiantes);

                    contador++;
                }

                foreach(Estudiantes st in lista)
                {
                    Console.WriteLine(st.getData());
                }

                Console.WriteLine("");
                Console.WriteLine("Si desea ingresar nuevos datos escriba 0");
                validar = int.Parse(Console.ReadLine());
   
            } while (validar == 0);

            //Las Funciones 

            static double NotaFinal (double Lab1, double Lab2, double Parc)
            {
                double notaFinal = (Lab1 * 0.3) + (Lab2 * 0.3) + (Parc * 0.4);
                return notaFinal;
            }

            static string Aprob(double NotaFinal)
            {
                if(NotaFinal > 6)
                {
                    return "Aprobado";
                }
                else
                {
                    return "Reprobado";
                }


            }

        
        }
    }

}
public class Estudiantes
{
    private string _name;
    private double _notaFinal;
    private string _aprob;

    public string Nombre
    {
        get => _name;
        set => _name = value;
    }

    public double NotaFinal
    {
        get => _notaFinal;
        set => _notaFinal = value;
    }

    public string Aprob
    {
        get => _aprob;
        set => _aprob = value;
    }

    public string getData()
    {
        return "El nombre del estudiante es: " + _name + ", la nota final es: " + _notaFinal + ", el estado del estudiante es: " + _aprob;
    }
}
