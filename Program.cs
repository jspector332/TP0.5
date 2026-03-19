namespace TP0;

class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso();
        int menu;
        do{
            menu = ingresarMenu("Bienvenido. Ingrese una opcion: \n1.Agregar alumnos \n2.Buscar alumno por dni\n3.Agregar faltas\n4.Mostrar todos los alumnos.\n5.Mostrar a todos los alumnos libres.\n6.Salir.");
            Console.Clear();
            switch (menu){
                case 1:
                string alumno = ingresarString("Ingresar nombre del alumno a agregar: ");
                int dni = ingresarNum("Ingresar dni del alumno a agregar: ");
                Console.WriteLine(curso.agregarAlumno(dni, alumno));
                break;
                case 2:
                Console.WriteLine(curso.buscarAlumnoXDni(ingresarNum("Ingresar dni del alumno a buscar")));
                break;
                case 3:
                Console.WriteLine(curso.agregarFaltas(ingresarNum("Ingresar el dni del alumno que falto: "), ingresarFaltas("Ingresar cantidad de faltas a agregar: ")));
                break;
                case 4:
                foreach(Alumno alumno1 in curso.mostrarAlumnos()){
                    Console.WriteLine(alumno1.mostrarInfo());
                }
                if ((curso.mostrarAlumnos()).Count == 0){
                    Console.WriteLine("No hay alumnos. ");
                }
                break;
                case 5:
                foreach(Alumno alumno2 in curso.mostrarAlumnosLibres()){
                    Console.WriteLine(alumno2.mostrarInfo());
                }
                if ((curso.mostrarAlumnosLibres()).Count == 0){
                    Console.WriteLine("No hay alumnos libres. ");
                }
                break;
                case 6:
                break;
            }
        }while (menu != 6);
    }
        static int ingresarMenu(string v){
            int n;
            Console.WriteLine(v);
            n = int.Parse(Console.ReadLine());
            while (n < 1 && n > 6){
                Console.WriteLine("Numero fuera del rango. Ingresar de nuevo: ");
                n = int.Parse(Console.ReadLine());
            }
            return n;
        }
        static string ingresarString(string v){
            string s;
            Console.WriteLine(v);
            s = Console.ReadLine();
            return s;
        }
        static int ingresarNum(string v){
            int n;
            Console.WriteLine(v);
            n = int.Parse(Console.ReadLine());
            return n;
        }
        static double ingresarFaltas(string v){
            double d;
            Console.WriteLine(v);
            d = double.Parse(Console.ReadLine());
            while (d != 0.5 && d != 1){
                Console.WriteLine("La cantidad ingresada no es valida. Ingresar una o media falta: ");
                d = double.Parse(Console.ReadLine());
            }
            return d;
        }
}