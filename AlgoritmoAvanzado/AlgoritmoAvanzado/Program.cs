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
Console.WriteLine("Lista de números proporcionada:");
do
{
    //Enseñar la lista desordenada
    for (int i = 0; i < listanumeros.Count; i++)
    {
        Console.WriteLine(listanumeros[i]);
    }
    //Preguntar para seguir
    Console.WriteLine("Pulse C para contiuar");
    continuar = Console.ReadKey().Key;
}while(continuar != ConsoleKey.C);

List<int> listanumerosord = new List<int>();

//Ordenar de menor a mayor
while (listanumeros.Count > 0)
{
    //Iniciar variable para ordenar en -1
    int maxNumber = 100000;
        //recorrer lista de numeros
        foreach (var number in listanumeros) 
        {
            //si el numero es mayor actualizar maxNumber
            if(number < maxNumber) 
            {
                maxNumber = number;
            }
        }
    //Añadir el numero más grande a la lista de numeros ordenados
    listanumerosord.Add(maxNumber);
    //Borrarlo de la lista de numeros desordenados
    listanumeros.Remove(maxNumber);
}

Console.Clear();
//Mostrar por pantalla la lista ordenada
for (int i = 0;i < listanumerosord.Count; i++) 
{ 
    Console.WriteLine(listanumerosord[i]);
}