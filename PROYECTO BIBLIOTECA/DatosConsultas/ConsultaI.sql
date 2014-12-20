--Libros que están actualmente fuera de plazo 
--(prestados, no devueltos y fuera del plazo de 2 semanas):
--Libro, Usuario, Fecha de préstamo, Fecha Actual.

SELECT Libro.Titulo, Realiza.Fecha, SYSDATE
FROM Libro, Tiene, Prestamo, Realiza
WHERE Libro.LI# = Tiene.LI# AND
	  Tiene.PR# = Prestamo.PR# AND
	  Prestamo.PR# = Realiza.PR# AND
	  Realiza.FechaDevolucion IS NULL AND
	  SYSDATE > Realiza.FechaLimite;