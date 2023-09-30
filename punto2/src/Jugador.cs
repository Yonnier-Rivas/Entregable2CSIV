public class Jugador {
    //Atributos (private) de cada jugador 
    private string nombre;
    private string posicion;
    private int rendimiento;

    // Constructor de la clase Jugador
    public Jugador(string nombre, string posicion, int rendimiento) {
        this.nombre = nombre;
        this.posicion = posicion;
        this.rendimiento = rendimiento;
    }

    public string GetNombre() { //Obtener y devolver el nombre del jugador
        return this.nombre;
    }

    public string GetPosicion() { //Obtener y devolver la posicion del jugador
        return this.posicion;
    }

    public int GetRendimiento() { //Obtener y devolver el rendimiento del jugador
        return this.rendimiento;
    }
}