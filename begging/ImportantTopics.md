# Temas Imprescindibles para Aprender C#

## 1. Fundamentos del Lenguaje
- **Tipos de datos m�s usados**:
  - Primitivos: `int`, `double`, `float`, `bool`, `char`, `string`.  
  - Nullables: `int?`, `bool?`.  
  - Tipos complejos: `object`, `dynamic`, `decimal`.  
  - Arrays y colecciones: `int[]`, `List<T>`, `Dictionary<K,V>`.
- **Estructuras b�sicas**:
  - Variables y constantes: `var`, `const`.
  - Operadores: Aritm�ticos, l�gicos, de comparaci�n y bit a bit.
  - Estructuras de control: `if`, `switch`, `while`, `for`, `foreach`.
  - Manejo de excepciones: `try-catch-finally`, `throw`.

## 2. Programaci�n Orientada a Objetos (POO)
- **Clases y objetos**:
  - Creaci�n de clases, instanciaci�n de objetos.
  - Modificadores de acceso: `public`, `private`, `protected`, `internal`.
- **Encapsulamiento**:
  - Propiedades (`get` y `set`).
  - M�todos.
- **Herencia y polimorfismo**:
  - Herencia (`: baseClass`).
  - M�todos virtuales y sobrescritura (`virtual`, `override`).
  - Uso de `abstract` y `sealed`.
- **Interfaces**: Definici�n e implementaci�n.
- **Clases est�ticas**: M�todos y propiedades est�ticas.

## 3. Estructuras de Datos y Colecciones
- **Colecciones gen�ricas**:
  - `List<T>`, `Dictionary<K, V>`, `Queue<T>`, `Stack<T>`.
- **Colecciones no gen�ricas** (menos usadas): `ArrayList`, `Hashtable`.
- **Enumeraciones (`enum`) y estructuras (`struct`)**.

## 4. LINQ (Language Integrated Query)
- **Consultas b�sicas**:
  - Filtrar (`where`), ordenar (`order by`), seleccionar (`select`).
- **Operadores avanzados**:
  - `GroupBy`, `Join`, `Take`, `Skip`.
- **LINQ to Objects, LINQ to SQL, LINQ to XML**.
- M�todos de extensi�n: `Select`, `FirstOrDefault`, `Any`, `All`.

## 5. Programaci�n Funcional
- Delegados (`delegate`) y expresiones lambda.
- Eventos y manejadores (`event`).
- M�todos an�nimos.
- Uso de `Func<T>` y `Action<T>`.

## 6. Manejo de Archivos
- Leer y escribir archivos: `File`, `StreamReader`, `StreamWriter`.
- Manejo de JSON y XML:
  - Serializaci�n y deserializaci�n (`System.Text.Json`, `Newtonsoft.Json`).
  - `XDocument` para trabajar con XML.

## 7. Asincron�a y Multitarea
- Programaci�n as�ncrona:
  - `async` y `await`.
  - `Task`, `Task<T>`.
- Hilos y paralelismo:
  - `Thread`, `ThreadPool`.
  - Parallel LINQ (PLINQ).
  - `Task.Run`, `CancellationToken`.

## 8. Temas Avanzados
- **Expresiones regulares** (`Regex`).
- **Inyecci�n de dependencias**.
- **Reflection** (`System.Reflection`).
- **Dynamic Programming** con `dynamic`.
- **Seguridad**:
  - Cifrado y hashing (`System.Security.Cryptography`).
  - Validaci�n de datos.

## 9. Desarrollos Espec�ficos
- **Aplicaciones de consola**: Primeros pasos.
- **Aplicaciones de escritorio**: Windows Forms, WPF (Windows Presentation Foundation).
- **Aplicaciones web**:
  - ASP.NET Core.
  - API REST con Web API.
- **Videojuegos**: Uso de Unity con C#.

## 10. Buenas Pr�cticas
- Nomenclatura y estilo de c�digo.
- Uso de `using` para liberar recursos (`IDisposable`).
- Pruebas unitarias: `xUnit`, `NUnit`, o `MSTest`.
- Documentaci�n de c�digo (`///`).
