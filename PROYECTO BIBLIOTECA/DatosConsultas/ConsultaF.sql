--Libros de la biblioteca organizados por estilos de el/los autor/es,
--conociendo para cada estilo el número total de libros. 
--Poder elegir el estilo y ver el detalle de los libros correspondientes.

SELECT Libro.Titulo, Estilo.Nombre AS "ESTILO"
FROM Libro, Autor, Escribe, Estilo
WHERE Estilo.ES# = Autor.ES# AND 
	  Autor.AU# = Escribe.AU# AND
	  Escribe.LI# = Libro.LI#
ORDER BY Estilo.Nombre;

SELECT COUNT(Libro.Titulo) AS "NUMERO DE LIBROS", Estilo.Nombre AS "NOMBRE ESTILO"
FROM Libro, Autor, Escribe, Estilo
WHERE Estilo.ES# = Autor.ES# AND 
	  Autor.AU# = Escribe.AU# AND
	  Escribe.LI# = Libro.LI#
GROUP BY Estilo.Nombre
ORDER BY Estilo.Nombre;

SELECT Libro.Titulo, Libro.NumPaginas, Libro.NumEdicion, Libro.Anio, Estilo.Nombre
FROM Libro, Autor, Escribe, Estilo
WHERE Estilo.ES# = Autor.ES# AND 
	  Autor.AU# = Escribe.AU# AND
	  Escribe.LI# = Libro.LI# AND
	  Estilo.Nombre = 'Periodismo';