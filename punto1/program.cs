// Crear dos Pokemon
APokemon pokemon1 = IngresarPokemon(1);
APokemon pokemon2 = IngresarPokemon(2);

int vidaPokemon1 = 100; 
int vidaPokemon2 = 100;
int daño1 = 0;
int daño2 = 0;

// Batalla durante 3 turnos
for (int turno = 1; turno <= 3; turno++){
    Console.WriteLine($"\nTurno {turno}:");

    // Ataque del Pokemon 1 y defensa del Pokemon 2
    int ataque1 = pokemon1.Atacar();
    double defensa2 = pokemon2.Defender();

    if (ataque1 != 0){
        daño1 = (int)(ataque1 - defensa2);
        daño1 = Math.Max(daño1, 0); 
        vidaPokemon2 -= daño1;
        
        if (daño1 > 0){
            Console.WriteLine($"{pokemon1.Nombre} hizo un ataque de {ataque1} y {pokemon2.Nombre} uso una defensa de {defensa2} causando un daño de {daño1}\nEl nivel de vida de {pokemon2.Nombre} es de {vidaPokemon2}");
        }
        else{
            Console.WriteLine($"{pokemon1.Nombre} no ocasionó ningún daño a {pokemon2.Nombre}.\nEl nivel de vida de {pokemon2.Nombre} es: {vidaPokemon2}");
        }
    }
    else{
        Console.WriteLine($"{pokemon1.Nombre} no ocasionó ningún daño a {pokemon2.Nombre}.\nEl nivel de vida de {pokemon2.Nombre} es: {vidaPokemon2}");
    }

        
    // Ataque del Pokemon 2 y defensa del Pokemon 1
    int ataque2 = pokemon2.Atacar();
    double defensa1 = pokemon1.Defender();

    if (ataque2 != 0){
        daño2 = (int)(ataque2 - defensa1);
        daño2 = Math.Max(daño2, 0); // Asegurarse que el daño no es negativo
        vidaPokemon1 -= daño2;
        
        if (daño2 > 0){
            Console.WriteLine($"{pokemon2.Nombre} hizo un ataque de {ataque2} y {pokemon1.Nombre} uso una defensa de {defensa1} causando un daño de {daño2}\nEl nivel de vida de {pokemon1.Nombre} es de {vidaPokemon1}");
        }
        else{
            Console.WriteLine($"{pokemon2.Nombre} no ocasionó ningún daño a {pokemon1.Nombre}.\nEl nivel de vida de {pokemon1.Nombre} es: {vidaPokemon1}");
        }
    }
    else{
        Console.WriteLine($"{pokemon2.Nombre} no ocasionó ningún daño a {pokemon1.Nombre}.\nEl nivel de vida de {pokemon1.Nombre} es: {vidaPokemon1}");
    }

}

// Determinacion del resultado de la batalla
if (vidaPokemon1 > vidaPokemon2){
    Console.WriteLine($"\n{pokemon1.Nombre} gana la batalla.");
}
else if (vidaPokemon2 > vidaPokemon1){
    Console.WriteLine($"\n{pokemon2.Nombre} gana la batalla.");
}
else{
    Console.WriteLine("\nLa batalla termina en empate");
}  

//Ingresar los datos de los Pokemones
static APokemon IngresarPokemon(int numeroPokemon){
    Console.WriteLine($"\nIngrese los datos del Pokemon {numeroPokemon}:");
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Tipo: ");
    string tipo = Console.ReadLine();
    List<int> ataques = new List<int>();

    //For para validar que la lista de ataques sea ingresada correctamente
    for (int i = 0; i < 3; i++){
        Console.Write($"Ataque {i + 1} (rango 0-40): ");
        string ataqueUsuario = Console.ReadLine();
    
        if (!int.TryParse(ataqueUsuario, out int valorAtaque) || valorAtaque < 0 || valorAtaque > 40){
            Console.WriteLine("El valor del ataque debe estar en el rango de 0 a 40, intentalo de nuevo.");
            i--; 
        }
        else{
            ataques.Add(valorAtaque);
        }
    }

    Console.Write("Defensa (entero entre 10 y 35): ");
    int defensa;

    //while para validar que la defensa sea ingresada correctamente
    while (true){
        Console.Write("Defensa (entero entre 10 y 35): ");
        if (int.TryParse(Console.ReadLine(), out defensa) && defensa >= 10 && defensa <= 35){
            break;
        }
        else{
            Console.WriteLine("La defensa debe estar entre 10 y 35.");
        }
    }
    
    if (numeroPokemon == 1){
        return new Pokemon1(nombre, tipo, ataques, defensa);
    }
    else{
        return new Pokemon2(nombre, tipo, ataques, defensa);
    } 
}