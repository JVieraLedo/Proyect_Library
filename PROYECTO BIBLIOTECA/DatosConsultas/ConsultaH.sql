--Libros que se han prestado y se han devuelto (prestados y devueltos):
--Libro, Usuario, Fecha de préstamo,Fecha de devolución.

SELECT Libro.Titulo, Usuario.Nombre, Usuario.Apellidos, Realiza.Fecha, Realiza.FechaDevolucion
FROM libro, Tiene, Prestamo, Realiza, Usuario
WHERE FechaDevolucion IS NOT NULL AND
	  Libro.LI# = Tiene.LI# AND
	  Tiene.PR# = Prestamo.PR# AND
	  Prestamo.PR# = Realiza.PR# AND
	  Realiza.US# = Usuario.US#;