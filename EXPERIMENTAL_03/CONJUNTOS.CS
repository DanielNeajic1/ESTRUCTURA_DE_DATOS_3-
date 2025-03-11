#include <iostream>
#include <set>

int main() {
    // Declaración de un conjunto de enteros
    std::set<int> conjunto;

    // Inserción de elementos en el conjunto
    conjunto.insert(10);
    conjunto.insert(5);
    conjunto.insert(20);
    conjunto.insert(10); // Intento de inserción de un duplicado

    // Mostrar los elementos del conjunto en orden ascendente
    std::cout << "Elementos del conjunto en orden: ";
    for (int elemento : conjunto) {
        std::cout << elemento << " ";
    }
    std::cout << std::endl;

    // Verificación de la existencia de un elemento
    int buscar = 5;
    if (conjunto.count(buscar)) {
        std::cout << "El elemento " << buscar << " está en el conjunto." << std::endl;
    } else {
        std::cout << "El elemento " << buscar << " no está en el conjunto." << std::endl;
    }

    // Eliminación de un elemento
    conjunto.erase(buscar);
    std::cout << "Conjunto después de eliminar el elemento " << buscar << ": ";
    for (int elemento : conjunto) {
        std::cout << elemento << " ";
    }
    std::cout << std::endl;

    return 0;
}
