--k) Bloquear automáticamente a los usuarios que hayan excedido el 
--período de devolución de libros.

--Usuarios con libros sin devolver y fuera de plazo.		
UPDATE Usuario
SET  DiasBloqueo = (SELECT (TRUNC(SYSDATE - Realiza.FechaLimite) * 5 ) 
					FROM Realiza 
					WHERE Realiza.US# = Usuario.US# AND
					FechaDevolucion IS NULL         AND
					SYSDATE > FechaLimite
					)
WHERE US# IN (SELECT US# FROM Realiza WHERE SYSDATE > FechaLimite AND FechaDevolucion IS NULL);

--Usuarios con libros devueltos fuera de la fecha limite.
UPDATE Usuario
SET  DiasBloqueo = (SELECT (TRUNC(Realiza.FechaDevolucion - Realiza.FechaLimite) * 5 ) 
					FROM Realiza 
					WHERE Realiza.US# = Usuario.US# AND
					FechaDevolucion > FechaLimite
					)
WHERE US# IN (SELECT US# 
			  FROM Realiza
			  WHERE Realiza.US# = Usuario.US# AND
					FechaDevolucion > FechaLimite
			  );