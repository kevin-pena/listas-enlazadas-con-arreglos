
class ListaEnlazadaConArreglo
{
    private int[] arreglo;
    private int capacidad;
    private int longitud;
    public ListaEnlazadaConArreglo()
    {
        capacidad = 2; // Capacidad inicial del arreglo
        arreglo = new int[capacidad];
        longitud = 0; // Lista vacía
    }
    public void Agregar(int elemento)
    {
        if (longitud == capacidad)
        {
            // Redimensionar el arreglo si está lleno
            capacidad *= 2;
            Array.Resize(ref arreglo, capacidad);
        }

        arreglo[longitud] = elemento;
        longitud++;

        Console.WriteLine($"Elemento {elemento} agregado a la lista.");
    }
    public void MostrarLista()
    {
        Console.WriteLine("Elementos en la lista:");
        for (int i = 0; i < longitud; i++)
        {
            Console.WriteLine(arreglo[i]);
        }
    }
}
class Program
{
    static void Main()
    {
        ListaEnlazadaConArreglo lista = new ListaEnlazadaConArreglo();

        lista.Agregar(1);
        lista.Agregar(2);
        lista.Agregar(3);

        lista.MostrarLista();
    }
}
