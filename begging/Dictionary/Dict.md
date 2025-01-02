# Usar Diccionarios en C#

## Introducci�n
Un **diccionario** es una colecci�n que almacena pares clave-valor, donde cada clave es �nica y se utiliza para acceder al valor correspondiente. Es �til para b�squedas r�pidas y para almacenar datos relacionados de forma estructurada.

---

## M�todos y Propiedades M�s Comunes

### **Agregar elementos**
Permite insertar un nuevo par clave-valor en el diccionario. **Si la clave ya existe, se generar� un error**.  
Ejemplo de uso:  
```dictionary[key] = value;```

---

### **Acceder a valores**
Permite obtener el valor asociado a una clave espec�fica. **Si la clave no existe, se generar� un error**.  
Ejemplo de uso:  
```value = dictionary[key];```

---

### **Actualizar valores**
Permite modificar el valor asociado a una clave existente. Si la clave no existe, se a�ade autom�ticamente al diccionario.  
Ejemplo de uso:  
```dictionary[key] = newValue;```

---

### **Eliminar elementos**
Elimina un par clave-valor del diccionario mediante la clave. Si la clave no existe, no se realiza ninguna acci�n.  
Ejemplo de uso:  
```dictionary.Remove(key);```

---

### **Verificar existencia de claves o valores**
Permite verificar si una clave o un valor espec�fico existen en el diccionario.  
- Verificar clave:  
  ```dictionary.ContainsKey(key);```  
- Verificar valor:  
  ```dictionary.ContainsValue(value);```

---

### **Recorrer el diccionario**
Permite iterar sobre todos los pares clave-valor.  
Ejemplo de uso:  

foreach (var kvp in dictionary) {
	kvp.Key	  // para la clave
	kvp.Value // para el valor
}


---

### **Obtener las claves o valores**
Permite obtener una colecci�n de todas las claves o todos los valores almacenados en el diccionario.  
- Obtener claves:  
  ```dictionary.Keys;```  
- Obtener valores:  
  ```dictionary.Values;```

---

### **Contar elementos**
Devuelve la cantidad total de pares clave-valor almacenados en el diccionario.  
Ejemplo de uso:  
```dictionary.Count;```

---

### **Limpiar el diccionario**
Elimina todos los elementos del diccionario.  
Ejemplo de uso:  
```dictionary.Clear();```

---

### **Intentar obtener un valor**
Intenta obtener un valor asociado a una clave sin generar un error si la clave no existe.  
Ejemplo de uso:  
```dictionary.TryGetValue(key, out value);```

---

## Consejos Adicionales
- Usa tipos adecuados para claves y valores seg�n tus necesidades.
- Aseg�rate de manejar excepciones al trabajar con claves inexistentes.
- Aprovecha los m�todos como `TryGetValue` para evitar errores al acceder a claves que no est�n presentes.
