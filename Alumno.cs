namespace TP0;

public class Alumno{
    private int dni;
    private string nombre;
    private double cantidadFaltas;

    public Alumno(int dn, string nom){
        this.dni = dn;
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
        return ("DNI: " + this.dni + "\nNombre: " + this.nombre + "\nFaltas: " + this.cantidadFaltas);
    }
    internal bool esIgual(int dniABuscar){
        return dniABuscar == this.dni;
    }
}