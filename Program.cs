internal class Program
{
    static void Main(){
        SeleccionCasas seleccionCasas = new SeleccionCasas ();

        Estudiante estudiante1 = new EstudianteGryffindor {Nombre = "Harry Potter", Edad = 11};
        Estudiante estudiante2 = new EstudianteHufflepuff {Nombre = "Hermione Granger", Edad = 11};
        Estudiante estudiante3 = new EstudianteRavenclaw {Nombre = "Luna Lovegood", Edad = 12};
        Estudiante estudiante4 = new EstudianteSlytherin {Nombre = "Draco Malfoy", Edad = 12};

        seleccionCasas.AsignarrCasa(estudiante1);
        seleccionCasas.AsignarrCasa(estudiante2);
        seleccionCasas.AsignarrCasa(estudiante3);
        seleccionCasas.AsignarrCasa(estudiante4);

        seleccionCasas.MostrarEstudianteAsignado();

    }
}