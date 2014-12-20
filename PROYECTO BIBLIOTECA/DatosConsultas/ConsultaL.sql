--Desbloquear manualmente a un usuario cuando se considere necesario.

UPDATE Usuario
SET DiasBloqueo = NULL
WHERE US# = 'U001';
