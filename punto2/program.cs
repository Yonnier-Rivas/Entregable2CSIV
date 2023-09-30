
const int numJugadoresPorEquipo = 3; // Cantidad de jugadores en cada equipo

//Lista de jugadores
Jugador[] jugadores = { 
    new Jugador("Mauro", "Escolta", 5),
    new Jugador("Yonnier", "Base", 9),
    new Jugador("Darwin", "Alero", 2),
    new Jugador("Camilo", "Pívot", 8),
    new Jugador("Camila", "Ala-Pívot", 4),
    new Jugador("Estefania", "Base", 10)
};

// Equipos establecidos
Equipo equipo1 = new Equipo();
Equipo equipo2 = new Equipo();

List<Jugador> jugadoresDisponibles = new List<Jugador>(jugadores);  // Lista auxiliar para controlar los jugadores ya seleccionados

Random random = new Random(); //única instancia de Random para seleccionar jugadores aleatorios

// Llena los equipos con jugadores aleatorios sin repetir
for (int i = 0; i < numJugadoresPorEquipo; i++){
    int index = random.Next(jugadoresDisponibles.Count);
    Jugador jugadorSeleccionado = jugadoresDisponibles[index];
    equipo1.AgregarJugador(jugadorSeleccionado);
    jugadoresDisponibles.RemoveAt(index);
}

for (int i = 0; i < numJugadoresPorEquipo; i++){
    int index = random.Next(jugadoresDisponibles.Count);
    Jugador jugadorSeleccionado = jugadoresDisponibles[index];
    equipo2.AgregarJugador(jugadorSeleccionado);
    jugadoresDisponibles.RemoveAt(index);
}

// Mostrar los jugadores en cada equipo
 Console.WriteLine("Resultados:");

Console.WriteLine("\nJugadores del Equipo 1:");
equipo1.ImprimirJugadores();

Console.WriteLine("\nJugadores del Equipo 2:");
equipo2.ImprimirJugadores();

// Determinar el ganador del partido
Equipo ganador = equipo1.CalcularGanador(equipo2);

// Imprimir la suma total de rendimiento de cada equipo
Console.WriteLine("\nLa suma total de rendimiento del equipo 1 es: " + equipo1.GetRendimientoTotal());
Console.WriteLine("La suma total de rendimiento del equipo 2 es: " + equipo2.GetRendimientoTotal());

// Imprimir el ganador
if (ganador == null){
    Console.WriteLine("\nHay un empate.");
}
 else{
    Console.WriteLine("\nEl equipo ganador es: " + ganador.GetNombre());
}
