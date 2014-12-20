--Pr�stamos efectuados por cada usuario, en el que aparezca para 
--cada usuario, los pr�stamos que ha realizado indicando la fecha
--de retirada y devoluci�n y que se detalle el/los libros que retir�.

SELECT Usuario.Nombre, Usuario.Apellidos, Prestamo.Identificador, Realiza.Fecha,
FechaDevolucion, Libro.Titulo
FROM Libro, Tiene, Prestamo, Realiza, Usuario
WHERE Libro.LI# = Tiene.LI# AND
	  Tiene.PR# = Prestamo.PR# AND
	  Prestamo.PR# = Realiza.PR# AND
	  Realiza.US# = Usuario.US# AND
	  FechaDevolucion IS NOT NULL
ORDER BY Usuario.Nombre, Realiza.Fecha;