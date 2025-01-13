# Ejercicio 1
asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"]
print(asignaturas)

# Ejercicio 2
for asignatura in asignaturas:
    print(f"Yo estudio {asignatura}")

# Ejercicio 3
notas = []
for asignatura in asignaturas:
    nota = input(f"¿Qué nota has sacado en {asignatura}? ")
    notas.append(nota)

for asignatura, nota in zip(asignaturas, notas):
    print(f"En {asignatura} has sacado {nota}")

# Ejercicio 4
numeros = input("Introduce los números ganadores de la lotería separados por comas: ")
numeros = list(map(int, numeros.split(",")))
numeros.sort()
print("Números ganadores ordenados:", numeros)

# Ejercicio 5
numeros = list(range(1, 11))
print(", ".join(map(str, numeros[::-1])))

# Ejercicio 6
notas = []
for asignatura in asignaturas:
    nota = int(input(f"¿Qué nota has sacado en {asignatura}? "))
    if nota < 5:
        notas.append(asignatura)

print("Tienes que repetir las asignaturas:", notas)

# Ejercicio 7
import string
abecedario = list(string.ascii_lowercase)
resultado = [letra for i, letra in enumerate(abecedario, start=1) if i % 3 != 0]
print(resultado)

# Ejercicio 8
palabra = input("Introduce una palabra: ").lower()
if palabra == palabra[::-1]:
    print("La palabra es un palíndromo.")
else:
    print("La palabra no es un palíndromo.")

# Ejercicio 9
palabra = input("Introduce una palabra: ").lower()
vocales = "aeiou"
for vocal in vocales:
    print(f"La vocal {vocal} aparece {palabra.count(vocal)} veces.")

# Ejercicio 10
precios = [50, 75, 46, 22, 80, 65, 8]
print("Menor precio:", min(precios))
print("Mayor precio:", max(precios))

# Ejercicio 11
v1 = [1, 2, 3]
v2 = [-1, 0, 2]
producto_escalar = sum(x * y for x, y in zip(v1, v2))
print("Producto escalar:", producto_escalar)

# Ejercicio 12
matriz1 = [[1, 2], [3, 4]]
matriz2 = [[2, 0], [1, 2]]
producto = [[sum(a * b for a, b in zip(fila, col)) for col in zip(*matriz2)] for fila in matriz1]
print("Producto de matrices:")
for fila in producto:
    print(fila)

# Ejercicio 13
import math
muestra = input("Introduce una muestra de números separados por comas: ")
muestra = list(map(float, muestra.split(",")))
media = sum(muestra) / len(muestra)
desviacion = math.sqrt(sum((x - media) ** 2 for x in muestra) / len(muestra))
print(f"Media: {media}, Desviación típica: {desviacion}")
