using System.Runtime.CompilerServices;

class SeleccionCasas : ISeleccionCasa{
    private List<Estudiante> estudiantes = new List<Estudiante>();

    public void AsignarrCasa(Estudiante estudiante){
        estudiante.SeleccionarCasa();
        estudiantes.Add(estudiante);
    }

    public void MostrarEstudianteAsignado(){
        Console.WriteLine("\nEstudiantes asignados a casas:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"{estudiante.Nombre} - {estudiante.GetType().Name}");
        }
    }
}