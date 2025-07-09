# PhysicalDriveReader

Herramienta en C# para leer y mostrar el sector 0 (MBR) del disco físico `PhysicalDrive0`.

## ¿Para qué sirve?

Esta herramienta permite acceder al sector de arranque maestro (MBR) del disco físico principal del sistema (PhysicalDrive0) y mostrar:

- El contenido hexadecimal completo de los primeros 512 bytes (sector 0).
- La firma del MBR para validar su integridad.
- La tabla de particiones con detalles de cada entrada (estado, tipo, primer sector, cantidad de sectores).

Esto es útil para:

- Analizar la estructura y configuración de particiones en discos.
- Detectar posibles corrupciones o modificaciones sospechosas en el MBR.
- Aprender y comprender cómo funciona el proceso de arranque y particionamiento en sistemas Windows.
- Realizar auditorías, análisis forenses y diagnóstico bajo nivel del disco físico.
- Base para desarrollar herramientas avanzadas de gestión, respaldo o reparación de MBR.

---

## Uso

- Ejecutar la aplicación con permisos de administrador.
- Pulsar el botón "Leer Sector 0 (MBR) de PHYSICALDRIVE0".
- El contenido del MBR y la tabla de particiones se mostrarán en el cuadro de texto principal.

---

## Archivos

- `PhysicalDriveReader.cs` - Clase principal con la interfaz gráfica.
- `Program.cs` - Punto de entrada `Main()` que lanza la aplicación.
- `NativeMethods.cs` - Importación de funciones nativas WinAPI.
- `Constants.cs` - Constantes para acceso a disco y flags.
- `MBRReader.cs` - Lógica para abrir y leer el sector 0.
- `MBRFormatter.cs` - Funciones para formatear y mostrar el contenido del MBR.
- `PartitionEntry.cs` - Clase para parsear y representar las particiones.
- `UIControls.cs` - Métodos para creación de controles UI reutilizables.
- `Extensions.cs` - Métodos auxiliares (pueden ampliarse).
- `README.md` - Documentación del proyecto.

---

## Requisitos

- Plataforma Windows.
- Ejecutar con permisos administrativos para poder leer el disco físico.

---

## Advertencia

Manipular directamente el disco físico puede ser peligroso. Esta herramienta solo lee el MBR, pero si se implementa para modificarlo, siempre haz copias de seguridad antes.

---

## Licencia

Este proyecto es open source y puede ser utilizado con fines educativos y de desarrollo.

(Escrito por un compa de discord)
