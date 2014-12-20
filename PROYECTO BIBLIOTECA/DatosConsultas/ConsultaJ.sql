--Préstamos efectuados por cada usuario, en el que aparezca para 
--cada usuario, los préstamos que ha realizado indicando la fecha
--de retirada y devolución y que se detalle el/los libros que retiró.

SELECT Usuario.Nombre, Usuario.Apellidos, Prestamo.Identificador, Realiza.Fecha,
FechaDevolucion, Libro.Titulo
FROM Libro, Tiene, Prestamo, Realiza, Usuario
WHERE Libro.LI# = Tiene.LI# AND
	  Tiene.PR# = Prestamo.PR# AND
	  Prestamo.PR# = Realiza.PR# AND
	  Realiza.US# = Usuario.US# AND
	  FechaDevolucion IS NOT NULL
ORDER BY Usuario.Nombre, Realiza.Fecha;