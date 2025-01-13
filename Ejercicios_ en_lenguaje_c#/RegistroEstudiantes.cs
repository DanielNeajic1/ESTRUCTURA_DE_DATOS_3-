// Ejercicio 1: Registro de estudiantes de Redes III

using System;
using System.Collections.Generic;

class Estudiante
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public double NotaDefinitiva { get; set; }
}

class ListaEstudiantes
{
    private LinkedList<Estudiante> estudiantesAprobados = new LinkedList<Estudiante>();
    private LinkedList<Estudiante> estudiantesReprobados = new LinkedList<Estudiante>();

    public void AgregarEstudiante(Estudiante estudiante)
    {
        if (estudiante.NotaDefinitiva >= 6.0)
            estudiantesAprobados.AddFirst(estudiante);
        else
            estudiantesReprobados.AddLast(estudiante);
    }

    public Estudiante BuscarEstudiante(string cedula)
    {
        foreach (var estudiante in estudiantesAprobados)
            if (estudiante.Cedula == cedula) return estudiante;
        foreach (var estudiante in estudiantesReprobados)
            if (estudiante.Cedula == cedula) return estudiante;
        return null;
    }

    public void EliminarEstudiante(string cedula)
    {
        var estudiante = BuscarEstudiante(cedula);
        if (estudiante != null)
        {
            estudiantesAprobados.Remove(estudiante);
            estudiantesReprobados.Remove(estudiante);
        }
    }

    public int TotalEstudiantesAprobados() => estudiantesAprobados.Count;
    public int TotalEstudiantesReprobados() => estudiantesReprobados.Count;

    public void ListarEstudiantes()
    {
        Console.WriteLine("Estudiantes Aprobados:");
        foreach (var estudiante in estudiantesAprobados)
            Console.WriteLine($"{estudiante.Nombre} {estudiante.Apellido}, Nota: {estudiante.NotaDefinitiva}");

        Console.WriteLine("Estudiantes Reprobados:");
        foreach (var estudiante in estudiantesReprobados)
            Console.WriteLine($"{estudiante.Nombre} {estudiante.Apellido}, Nota: {estudiante.NotaDefinitiva}");
    }
}