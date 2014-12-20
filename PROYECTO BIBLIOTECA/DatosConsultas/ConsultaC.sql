--Libros de la biblioteca organizados por categor�as, 
--conociendo para cada categor�a el n�mero total de libros.
--Poder elegir la categor�a y ver el detalle de los libros correspondientes.

SELECT Categoria.Nombre, COUNT(Libro.Titulo) AS "NUMERO DE LIBROS"
FROM Libro, Categoria
WHERE Libro.CA# = Categoria.CA#
GROUP BY Categoria.Nombre
ORDER BY Categoria.Nombre;

SELECT Li.Titulo, Li.NumPaginas, Li.NumEdicion, Anio, Ca.Nombre
FROM Libro Li JOIN Categoria Ca ON Li.CA# = Ca.CA#
WHERE Ca.Nombre = 'Novela';