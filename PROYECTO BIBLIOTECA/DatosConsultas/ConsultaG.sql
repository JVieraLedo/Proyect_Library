--Libros que se encuentran actualmente prestados (prestados,
--no devueltos y dentro del plazo de 2 semanas): 
--Libro, Usuario, Fecha de préstamo.
SELECT Libro.Titulo, Usuario.Nombre, Usuario.Apellidos, Realiza.Fecha
FROM Libro, Tiene, Prestamo, Realiza, Usuario
WHERE Libro.LI#    = Tiene.LI#    AND
	  Tiene.PR#    = Prestamo.PR# AND
	  Prestamo.PR# = Realiza.PR#  AND
	  Realiza.US#  = Usuario.US#  AND
	  Realiza.FechaDevolucion IS NULL AND
	  SYSDATE < FechaLimite;