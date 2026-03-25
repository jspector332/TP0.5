namespace TP0;

public class Curso{
    private Dictionary<int, Alumno> dicAlumnos;
    
    public Curso(){
        dicAlumnos = new Dictionary <int, Alumno>();
    }
    public string agregarAlumno(int dni, string nombre){
        string resu = "";
        if (dicAlumnos.ContainsKey(dni) == false){
            dicAlumnos.Add(dni, new Alumno(nombre));
            resu = "Alumno fue agregado con exito.";
        }
        else{
            resu = "Este dni ya esta en uso / No se pudo agregar.";
        }
        return resu;
    }
    public string buscarAlumnoXDni(int dni){
        string resu = "No se encontro un alumno con este dni.";
        if (dicAlumnos.ContainsKey(dni)){
            resu = dicAlumnos[dni].getNombre();
        }
        return resu;
    }
    public string agregarFaltas(int dni, double num){
        string resu = "";
        if (dicAlumnos.ContainsKey(dni)){
            dicAlumnos[dni].addFaltas(num);
            resu = "Las faltas fueron agregadas correctamente.";
        }
        else{
            resu = "No se pudieron agregar las faltas.";
        }
        return resu;
    }
    public Dictionary<int, Alumno> mostrarAlumnos(){
        return dicAlumnos;
    }
    public List<Alumno> mostrarAlumnosLibres(){
        List<Alumno> listaDisp = new List <Alumno>();
        foreach (Alumno alumno in dicAlumnos.Values){
            if (alumno.estaLibre())
            listaDisp.Add(alumno);
        }
        return listaDisp;
    }
}