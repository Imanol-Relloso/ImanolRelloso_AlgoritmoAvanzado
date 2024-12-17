using AlgoritmoAvanzado.Classes;

List<int> listanumeros = new List<int>();

ConsoleKey continuar;
//Preguntar al usuario los números
do
{
    Console.Clear();
    Console.WriteLine("\nIntroduzca un número:");
    string respuesta = Console.ReadLine();
    int number = int.Parse(respuesta);

    //Añadir números a la lista
    listanumeros.Add(number);

    //Preguntar si quiere seguir añadiendo números
    Console.WriteLine("\n¿Quiere introducir más números? s/n");
    continuar = Console.ReadKey().Key;
} while (continuar == ConsoleKey.S);

Console.Clear();
Console.WriteLine(listanumeros);