namespace TP0;

public class Alumno{
    private string nombre;
    private double cantidadFaltas;

    public Alumno(string nom){
        this.nombre = nom;
        this.cantidadFaltas = 0;
    }
    public void addFaltas(double num){
        this.cantidadFaltas += num;
    }
    public bool estaLibre(){
        return this.cantidadFaltas > 15;
    }
    public string getNombre(){
        return this.nombre;
    }
    public string mostrarInfo(){
        return ("\nNombre: " + this.nombre + "\nFaltas: " + this.cantidadFaltas);
    }
}