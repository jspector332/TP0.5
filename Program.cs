namespace TP0;

class Program
{
    int menu;
    static void Main(string[] args)
    {
        Curso curso = new Curso();
        int menu;
        do{
            menu = ingresarMenu("Bienvenido. Ingrese una opcion: \n1.Agregar alumnos \n2.Buscar alumno por dni\n3.Agregar faltas\n4.Mostrar todos los alumnos.\n5.Salir.");
            Console.Clear();
            switch (menu){
                case 1:
                string tipo = ingresarString("Ingresar tipo de vehiculo: ");
                estacionamiento.agregarVehiculo(tipo);
                break;
                case 2:
                estacionamiento.obtenerDisponibles();
                break;
                case 3:
                estacionamiento.realizarViaje(ingresarNum("Ingresa el id del auto a simular: "), ingresarDouble("Ingresa la cantidad de KM a simular: "));
                break;
                case 4:
                estacionamiento.cargaMasiva();
                break;
                case 5:
                break;
            }
        }while (menu != 5);
    }
}    
