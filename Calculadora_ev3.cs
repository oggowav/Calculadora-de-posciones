double tiempoAnalitico = 25;
double posicionDiferencial = CalcularPosicionDiferencial(tiempoAnalitico);
double posicionIntegral = CalcularPosicionIntegral(tiempoAnalitico);

// Lo que se va a imprimir
Console.WriteLine("Ecuación de aceleración de la partícula:a(t) = 6.5t + 4");
Console.WriteLine("Ecuación de velocidad de la partícula: v(t) = 3.25t^2 + 4t + 2.5");
Console.WriteLine("Velocidad de la partícula en el intervalo de 5 a 10 minutos: ");
for (int t = 5; t <= 10; t++)
{
    Console.WriteLine("La velocidad en el minuto " + t + " va a ser igual a: " + ((3.25 * Math.Pow(t, 2)) + (4*t) + 2.5));
};
Console.WriteLine("Ecuación de posición de la partícula: x(t) = (3.25/3)t^3 + 2t^2 + 2.5t");
Console.WriteLine($"Posición de la partícula a los 25 minutos (diferencial): {posicionDiferencial}");
Console.WriteLine($"Posición de la partícula a los 25 minutos (integral): {posicionIntegral}");

static double CalcularPosicionDiferencial(double tiempo)
{
    double posicion = 0;
    double dt = 0.1;
    double t = 0;

    while (t < tiempo) 
    {
        double v = 3.25 * Math.Pow(t, 2) + 4 * t + 2.5; // Calcula la velocidad en el tiempo actual (va cambiando cada minuto)
        posicion += v * dt; // Actualiza la posición utilizando el método de Euler
        t += dt; // Incrementa el tiempo
    }
    return posicion;
}

    static double CalcularPosicionIntegral(double tiempo)
{
    double posicion = 0;

    posicion = (3.25 / 3) * Math.Pow(tiempo, 3) + 2 * Math.Pow(tiempo, 2) + 2.5 * tiempo;

    return posicion;
}
