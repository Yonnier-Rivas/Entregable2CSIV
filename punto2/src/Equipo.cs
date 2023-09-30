public class Equipo{

    // Atributos de la clase Equipo
    private string nombre;
    private List<Jugador> jugadores;
    private int rendimientoTotal;

    // Constructor de la clase Equipo
    public Equipo() {
        this.nombre = "Jugador"; //Nombre predeterminado
        this.jugadores = new List<Jugador>(); // Lista inicializada como vacia
        this.rendimientoTotal = 0;
    }

    // Metodo para agregar jugador al equipo
    public void AgregarJugador(Jugador jugador) {
        this.jugadores.Add(jugador);
        this.rendimientoTotal += jugador.GetRendimiento(); // actualizar el rendimiento total 
    }
    
    // Metodo para calcular el rendimiento total del equipo
    public int CalcularRendimiento() {
        return this.rendimientoTotal;
    }

    // Metodo para calcular el ganador entre dos equipos
    public Equipo CalcularGanador(Equipo equipo){
    int rendimientoEquipo1 = this.CalcularRendimiento();  //rrendimiento total del equipo1
    int rendimientoEquipo2 = equipo.CalcularRendimiento(); // rendimiento total del equipo2

        if (rendimientoEquipo1 > rendimientoEquipo2){
            this.SetNombre("Equipo numero 1");
            return this; // Devuelve el equipo1 como ganador
        }
        else if (rendimientoEquipo2 > rendimientoEquipo1){
            equipo.SetNombre("Equipo numero 2");
            return equipo; // Devuelve el equipo2 como ganador
        }
        else{
            this.SetNombre("Empate");
            equipo.SetNombre("Empate");
            return null; //Devulve null si el rendimiento total es mismo en ambos equipos
        }
    }

    public string GetNombre() { // obtener y retornar el nombre del equipo
        return this.nombre;
    }

    public void SetNombre(string nombre) {   // Establecer y asignar el nombre al equipo
        this.nombre = nombre;
    }

    public List<Jugador> GetJugadores() { //Obtener y devolver la lista de jugadores del equipo
        return this.jugadores;
    }

    public int GetRendimientoTotal() {  //obtener y devolver el rendimiento total del equipo
        return this.rendimientoTotal;
    }

   public void ImprimirJugadores(){ //Metodo para imprimir la info los jugadores de un equipo.
        foreach (var jugador in this.jugadores){
            Console.WriteLine($"Nombre: {jugador.GetNombre()}, Posición: {jugador.GetPosicion()}, Rendimiento: {jugador.GetRendimiento()}");
        }
    }
}