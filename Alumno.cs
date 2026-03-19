public class Alumno(int dn, string nom){
    public Alumno(){
    private int dni = dn;
    private string nombre = nom;
    private double cantidadFaltas = 0;
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
        return "DNI: " + this.dni + "\nNombre: " + this.nombre + "\nFaltas: " + this.cantidadFaltas + "\nEstado: " + (cantidadFaltas > 15) ? "Libre" : "No libre";
    }
}