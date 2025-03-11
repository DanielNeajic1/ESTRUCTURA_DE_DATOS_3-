#include <iostream>
#include <map>
#include <string>

int main() {
    // Declaración de un mapa que asocia nombres (clave) con calificaciones (valor)
    std::map<std::string, int> calificaciones;

    // Inserción de pares clave-valor en el mapa
    calificaciones["Ana"] = 90;
    calificaciones["Luis"] = 85;
    calificaciones["María"] = 95;
    calificaciones["Pedro"] = 88;

    // Mostrar las calificaciones de los estudiantes
    std::cout << "Calificaciones de los estudiantes:\n";
    for (const auto& par : calificaciones) {
        std::cout << par.first << ": " << par.second << "\n";
    }

    // Actualización de la calificación de un estudiante
    calificaciones["Luis"] = 90;
    std::cout << "\nDespués de actualizar la calificación de Luis:\n";
    for (const auto& par : calificaciones) {
        std::cout << par.first << ": " << par.second << "\n";
    }

    // Eliminación de un estudiante
    calificaciones.erase("Ana");
    std::cout << "\nDespués de eliminar a Ana:\n";
    for (const auto& par : calificaciones) {
        std::cout << par.first << ": " << par.second << "\n";
    }

    return 0;
}
