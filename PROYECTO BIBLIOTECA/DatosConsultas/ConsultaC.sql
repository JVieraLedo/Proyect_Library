--Libros de la biblioteca organizados por categorías, 
--conociendo para cada categoría el número total de libros.
--Poder elegir la categoría y ver el detalle de los libros correspondientes.

SELECT Categoria.Nombre, COUNT(Libro.Titulo) AS "NUMERO DE LIBROS"
FROM Libro, Categoria
WHERE Libro.CA# = Categoria.CA#
GROUP BY Categoria.Nombre
ORDER BY Categoria.Nombre;

SELECT Li.Titulo, Li.NumPaginas, Li.NumEdicion, Anio, Ca.Nombre
FROM Libro Li JOIN Categoria Ca ON Li.CA# = Ca.CA#
WHERE Ca.Nombre = 'Novela';