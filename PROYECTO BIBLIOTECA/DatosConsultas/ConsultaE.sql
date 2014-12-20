--Categoría con mayor cantidad de libros: Poder conocer el 
--nombre de la categoría que mayor cantidad de
--libros contiene.

SELECT Categoria.Nombre, COUNT(Categoria.Nombre) AS "NUMERO DE LIBROS"
FROM Categoria, Libro
WHERE Categoria.CA# = Libro.CA#
GROUP BY Categoria.Nombre
HAVING COUNT(Categoria.Nombre) =
(SELECT MAX(contador) FROM
	(SELECT COUNT(Categoria.Nombre) contador
	FROM Categoria, Libro
	WHERE Categoria.CA# = Libro.CA#
	GROUP BY Categoria.Nombre
	)
	);
			