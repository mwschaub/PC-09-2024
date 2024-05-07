namespace MarcS
{
class Parcialito
{
    public static void Main()
    {
        string[] names = new string[10];
        int[] notes = new int[10];

    for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el nombre del alumno {i+1}: ");
#pragma warning disable CS8601 // Possible null reference assignment.
                names[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                Boolean noteval = false;
            while (!noteval)
            {
                Console.Write($"Ingrese la nota de {names[i]}: ");
                if (int.TryParse(Console.ReadLine(), out int notaal) && notaal >= 0 && notaal <= 100)
                {
                    notes[i] = notaal;
                    noteval = true;
                }
            else
             {
             Console.WriteLine("Error! tiene sueñito la opción no es válida.");
             }} }
        Boolean menuini = true;
        while (menuini)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Mostrar nombre y nota de alumnos que aprobaron el curso.");
            Console.WriteLine("2. Mostrar nombre y nota de alumnos que no aprobaron el curso.");
            Console.WriteLine("3. Mostrar el promedio de notas del grupo.");
            Console.WriteLine("4. Salir del programa.");
            Console.WriteLine("Ingrese la opción: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string opcion = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                switch (opcion)
            {
                case "1":
                    aprobaditos(names, notes);
                    break;
                case "2":
                    reprobaditos(names, notes);
                    break;
                case "3":
                    MostrarPromedio(notes);
                    break;
                case "4":
                    menuini = false;
                    Console.WriteLine("Salir del programa");
                    break;
                default:
                    Console.WriteLine("Error! tiene sueñito la opción no es válida.");
                    break;
            }
        }
    }
   static void MostrarPromedio(int[] notes)
    {
        int suma = 0;
        foreach (int nota in notes)
        {
            suma += nota;
        }


        double promedio = suma / 10;

        Console.WriteLine("Promedio de notas del grupo:" + promedio);
    }
   static void aprobaditos(string[] names, int[] notes)
    {
        Console.WriteLine("Alumnos aprobados");
     for (int i = 0; i < 10; i++)
        {
            if (notes[i] >= 65)
            {
                Console.WriteLine($"{names[i]} - Nota: {notes[i]}");
            }
        }
    }
   static void reprobaditos(string[] nombres, int[] notas)
    {
        Console.WriteLine("Alumnos reprobados");
        for (int i = 0; i < 10; i++)
        {
         if (notas[i] < 65)
            {
                Console.WriteLine($"{nombres[i]} - Nota: {notas[i]}");
            }
        }
    }


}
    }
