# Temas Imprescindibles para Aprender C#

## 1. Fundamentos del Lenguaje
- **Tipos de datos más usados**:
  - Primitivos: `int`, `double`, `float`, `bool`, `char`, `string`.  
  - Nullables: `int?`, `bool?`.  
  - Tipos complejos: `object`, `dynamic`, `decimal`.  
  - Arrays y colecciones: `int[]`, `List<T>`, `Dictionary<K,V>`.
- **Estructuras básicas**:
  - Variables y constantes: `var`, `const`.
  - Operadores: Aritméticos, lógicos, de comparación y bit a bit.
  - Estructuras de control: `if`, `switch`, `while`, `for`, `foreach`.
  - Manejo de excepciones: `try-catch-finally`, `throw`.

## 2. Programación Orientada a Objetos (POO)
- **Clases y objetos**:
  - Creación de clases, instanciación de objetos.
  - Modificadores de acceso: `public`, `private`, `protected`, `internal`.
- **Encapsulamiento**:
  - Propiedades (`get` y `set`).
  - Métodos.
- **Herencia y polimorfismo**:
  - Herencia (`: baseClass`).
  - Métodos virtuales y sobrescritura (`virtual`, `override`).
  - Uso de `abstract` y `sealed`.
- **Interfaces**: Definición e implementación.
- **Clases estáticas**: Métodos y propiedades estáticas.

## 3. Estructuras de Datos y Colecciones
- **Colecciones genéricas**:
  - `List<T>`, `Dictionary<K, V>`, `Queue<T>`, `Stack<T>`.
- **Colecciones no genéricas** (menos usadas): `ArrayList`, `Hashtable`.
- **Enumeraciones (`enum`) y estructuras (`struct`)**.

## 4. LINQ (Language Integrated Query)
- **Consultas básicas**:
  - Filtrar (`where`), ordenar (`order by`), seleccionar (`select`).
- **Operadores avanzados**:
  - `GroupBy`, `Join`, `Take`, `Skip`.
- **LINQ to Objects, LINQ to SQL, LINQ to XML**.
- Métodos de extensión: `Select`, `FirstOrDefault`, `Any`, `All`.

## 5. Programación Funcional
- Delegados (`delegate`) y expresiones lambda.
- Eventos y manejadores (`event`).
- Métodos anónimos.
- Uso de `Func<T>` y `Action<T>`.

## 6. Manejo de Archivos
- Leer y escribir archivos: `File`, `StreamReader`, `StreamWriter`.
- Manejo de JSON y XML:
  - Serialización y deserialización (`System.Text.Json`, `Newtonsoft.Json`).
  - `XDocument` para trabajar con XML.

## 7. Asincronía y Multitarea
- Programación asíncrona:
  - `async` y `await`.
  - `Task`, `Task<T>`.
- Hilos y paralelismo:
  - `Thread`, `ThreadPool`.
  - Parallel LINQ (PLINQ).
  - `Task.Run`, `CancellationToken`.

## 8. Temas Avanzados
- **Expresiones regulares** (`Regex`).
- **Inyección de dependencias**.
- **Reflection** (`System.Reflection`).
- **Dynamic Programming** con `dynamic`.
- **Seguridad**:
  - Cifrado y hashing (`System.Security.Cryptography`).
  - Validación de datos.

## 9. Desarrollos Específicos
- **Aplicaciones de consola**: Primeros pasos.
- **Aplicaciones de escritorio**: Windows Forms, WPF (Windows Presentation Foundation).
- **Aplicaciones web**:
  - ASP.NET Core.
  - API REST con Web API.
- **Videojuegos**: Uso de Unity con C#.

## 10. Buenas Prácticas
- Nomenclatura y estilo de código.
- Uso de `using` para liberar recursos (`IDisposable`).
- Pruebas unitarias: `xUnit`, `NUnit`, o `MSTest`.
- Documentación de código (`///`).
