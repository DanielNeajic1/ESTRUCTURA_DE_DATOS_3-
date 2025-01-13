using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ListaVehiculos listaVehiculos = new ListaVehiculos();

        // Ejemplo de agregar vehículos
        listaVehiculos.AgregarVehiculo(new Vehiculo
        {
            Placa = "ABC123",
            Marca = "Toyota",
            Modelo = "Corolla",
            Anio = 2020,
            Precio = 20000
        });

        listaVehiculos.AgregarVehiculo(new Vehiculo
        {
            Placa = "XYZ789",
            Marca = "Honda",
            Modelo = "Civic",
            Anio = 2018,
            Precio = 18000
        });

        // Listar todos los vehículos
        listaVehiculos.VerTodosLosVehiculos();

        // Buscar vehículo
        var vehiculo = listaVehiculos.BuscarVehiculo("ABC123");
        Console.WriteLine(vehiculo != null ? $"Vehículo encontrado: {vehiculo.Marca} {vehiculo.Modelo}" : "Vehículo no encontrado");

        // Ver vehículos por año
        listaVehiculos.VerVehiculosPorAnio(2020);
    }
}