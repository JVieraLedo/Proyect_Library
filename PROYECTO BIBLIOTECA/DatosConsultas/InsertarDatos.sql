INSERT INTO Estilo VALUES('E001', 'Divulgacion');
INSERT INTO Estilo VALUES('E002', 'Periodismo');
INSERT INTO Estilo VALUES('E003', 'Consulta');
INSERT INTO Estilo VALUES('E004', 'Critica');
INSERT INTO Estilo VALUES('E005', 'Satira');
COMMIT;
--
INSERT INTO Autor VALUES('A001', 'Rafael', 'Alberti', 'E005');
INSERT INTO Autor VALUES('A002', 'Antonio', 'Machado', 'E005');
INSERT INTO Autor VALUES('A003', 'Miguel', 'Cervantes', 'E001');
INSERT INTO Autor VALUES('A004', 'Gustavo Adolfo', 'Becquer', 'E001');
INSERT INTO Autor VALUES('A005', 'Arturo', 'Perez Reverte', 'E004');
INSERT INTO Autor VALUES('A006', 'Dan', 'Brown', 'E004');
INSERT INTO Autor VALUES('A007', 'Isabel', 'Allende', 'E002');
INSERT INTO Autor VALUES('A008', 'Fernando', 'Savater', 'E002');
INSERT INTO Autor VALUES('A009', 'Fernando', 'Fernan Gomez', 'E003');
INSERT INTO Autor VALUES('A010', 'Patrick', 'Modiano', 'E003');
COMMIT;
--
INSERT INTO Categoria VALUES('C001', 'Novela');
INSERT INTO Categoria VALUES('C002', 'Infantil');
INSERT INTO Categoria VALUES('C003', 'Medicina');
INSERT INTO Categoria VALUES('C004', 'Religion');
INSERT INTO Categoria VALUES('C005', 'Historia');
INSERT INTO Categoria VALUES('C006', 'Teatro');
INSERT INTO Categoria VALUES('C007', 'Manuscritos');
COMMIT;
--
INSERT INTO Libro VALUES('L001', 'Pleamar', 211, 12, 1944, 'C001');
INSERT INTO Libro VALUES('L002', 'Campos de Castilla', 199, 5, 1912, 'C007');
INSERT INTO Libro VALUES('L003', 'Don Quijote de la Mancha', 528, 33, 1605, 'C001');
INSERT INTO Libro VALUES('L004', 'Libro de los gorriones', 87, 2, 1868, 'C007');
INSERT INTO Libro VALUES('L005', 'Las rimas', 102, 3, 1870, 'C005');
INSERT INTO Libro VALUES('L006', 'La tabla de Flandes', 484, 4, 1994, 'C005');
INSERT INTO Libro VALUES('L007', 'La conspiracion', 590, 9, 2006, 'C004');
INSERT INTO Libro VALUES('L008', 'Hija de la fortuna', 215, 8, 1998, 'C003');
INSERT INTO Libro VALUES('L009', 'Caton', 176, 4, 1989, 'C006');
INSERT INTO Libro VALUES('L010', 'Domingo de carnaval', 217, 20, 1945, 'C007');
INSERT INTO Libro VALUES('L011', 'La hierba de las noches', 256, 2, 2014, 'C002');
COMMIT;
--

INSERT INTO Escribe VALUES('L001', 'A001');
INSERT INTO Escribe VALUES('L002', 'A002');
INSERT INTO Escribe VALUES('L003', 'A003');
INSERT INTO Escribe VALUES('L004', 'A003');
INSERT INTO Escribe VALUES('L005', 'A004');
INSERT INTO Escribe VALUES('L006', 'A005');
INSERT INTO Escribe VALUES('L007', 'A006');
INSERT INTO Escribe VALUES('L008', 'A007');
INSERT INTO Escribe VALUES('L009', 'A008');
INSERT INTO Escribe VALUES('L010', 'A009');
INSERT INTO Escribe VALUES('L011', 'A010');
COMMIT;
--

INSERT INTO Prestamo VALUES('P001', 'ID-001/Pleamar');
INSERT INTO Prestamo VALUES('P002', 'ID-002/Campos');
INSERT INTO Prestamo VALUES('P003', 'ID-003/Conspiracion');
INSERT INTO Prestamo VALUES('P004', 'ID-004/Hierva');
INSERT INTO Prestamo VALUES('P005', 'ID-005/Quijote');
INSERT INTO Prestamo VALUES('P006', 'ID-006/Pleamar');
INSERT INTO Prestamo VALUES('P007', 'ID-007/Gorriones');
INSERT INTO Prestamo VALUES('P008', 'ID-008/Rimas');
INSERT INTO Prestamo VALUES('P009', 'ID-009/Fortuna');
INSERT INTO Prestamo VALUES('P010', 'ID-010/Campos');
INSERT INTO Prestamo VALUES('P011', 'ID-011/Carnaval');
INSERT INTO Prestamo VALUES('P012', 'ID-012/Gorriones');
INSERT INTO Prestamo VALUES('P013', 'ID-013/Caton');
INSERT INTO Prestamo VALUES('P014', 'ID-014/Tabla');
INSERT INTO Prestamo VALUES('P015', 'ID-015/Conspiracion');
INSERT INTO Prestamo VALUES('P016', 'ID-016/Quijote');
INSERT INTO Prestamo VALUES('P017', 'ID-017Conspiracion');
INSERT INTO Prestamo VALUES('P018', 'ID-018/Hierva');
INSERT INTO Prestamo VALUES('P019', 'ID-019Quijote');
INSERT INTO Prestamo VALUES('P020', 'ID-020/Pleamar');
INSERT INTO Prestamo VALUES('P021', 'ID-021/Gorriones');
COMMIT;

--

INSERT INTO Tiene VALUES('L001', 'P001');
INSERT INTO Tiene VALUES('L002', 'P002');
INSERT INTO Tiene VALUES('L007', 'P003');
INSERT INTO Tiene VALUES('L011', 'P004');
INSERT INTO Tiene VALUES('L003', 'P005');
INSERT INTO Tiene VALUES('L001', 'P006');
INSERT INTO Tiene VALUES('L004', 'P007');
INSERT INTO Tiene VALUES('L005', 'P008');
INSERT INTO Tiene VALUES('L008', 'P009');
INSERT INTO Tiene VALUES('L002', 'P010');
INSERT INTO Tiene VALUES('L010', 'P011');
INSERT INTO Tiene VALUES('L004', 'P012');
INSERT INTO Tiene VALUES('L009', 'P013');
INSERT INTO Tiene VALUES('L006', 'P014');
INSERT INTO Tiene VALUES('L007', 'P015');
INSERT INTO Tiene VALUES('L003', 'P016');
INSERT INTO Tiene VALUES('L007', 'P017');
INSERT INTO Tiene VALUES('L011', 'P018');
INSERT INTO Tiene VALUES('L003', 'P019');
INSERT INTO Tiene VALUES('L001', 'P020');
INSERT INTO Tiene VALUES('L004', 'P021');
COMMIT;
--
INSERT INTO Empleado VALUES('E001', 'Victor', 'Andrade Sanchez', '8:00 - 12:00');
INSERT INTO Empleado VALUES('E002', 'Terry' , 'Anguiano Simmons', '8:00 - 12:00');
INSERT INTO Empleado VALUES('E003', 'Katia', 'Bravo Alarza', '12:00 - 18:00');
INSERT INTO Empleado VALUES('E004', 'Julio', 'Jimenez Diaz', '12:00 - 18:00');
INSERT INTO Empleado VALUES('E005', 'Antonio', 'Villaverde Diez', '18:00 - 21:00');
INSERT INTO Empleado VALUES('E006', 'Armando', 'Sánchez Morales', '18:00 - 21:00');
INSERT INTO Empleado VALUES('E007', 'Nuria', 'Navarro Campos', '21:00 - 03:00');
INSERT INTO Empleado VALUES('E008', 'Lara', 'Moreno Morales', '21:00 - 03:00');
INSERT INTO Empleado VALUES('E009', 'Laura', 'Borrell Navarro', '03:00 - 08:00');
INSERT INTO Empleado VALUES('E010', 'Noelia', 'Pedraza Ruiz', '03:00 - 08:00');
COMMIT;
--
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U001', 'Juan', 'Perez Gomez', 'c/ Moscu 9');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U002', 'David', 'Fernandez Diaz', 'c/ Libia 19');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U003', 'Jose', 'Garcia Garcia', 'c/ Paris 119');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U004', 'Laura', 'Benitez Velasco', 'c/ Oslo 1');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U005', 'Mercedes', 'Salas Viera', 'c/ Washington 12');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U006', 'Antonio', 'Catalinas Roman', 'c/ Burundi 11');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U007', 'Mario', 'Benitez Velasco', 'c/ Oslo 1');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U008', 'Jose', 'Servant Martinez', 'c/ Madrid 91');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion) 
VALUES('U009', 'Hilario', 'Perez Garcia', 'c/ Dublin 103');
INSERT INTO Usuario (US#, Nombre, Apellidos, Direccion)
VALUES('U010', 'Jorge', 'Garcia Palas', 'c/ Zurich 9');
COMMIT;
--
INSERT INTO Realiza VALUES('1/10/2014', TO_DATE('20/10/2014', 'dd/mm/yyyy'), TO_DATE('1/10/2014', 'dd/mm/yyyy')+14, 'E001', 'P010', 'U009');
INSERT INTO Realiza VALUES('03/11/2014', NULL 								, TO_DATE('03/11/2014', 'dd/mm/yyyy')+14,   'E001', 'P009', 'U010');
INSERT INTO Realiza VALUES('10/11/2014', TO_DATE('14/11/2014', 'dd/mm/yyyy'), TO_DATE('10/11/2014', 'dd/mm/yyyy')+14, 'E002', 'P008', 'U008');
INSERT INTO Realiza VALUES('09/10/2014', NULL 								, TO_DATE('09/10/2014', 'dd/mm/yyyy')+14,  'E003', 'P007', 'U007');
INSERT INTO Realiza VALUES('25/10/2014', TO_DATE('01/11/2014', 'dd/mm/yyyy'), TO_DATE('25/10/2014', 'dd/mm/yyyy')+14, 'E004', 'P006', 'U006');
INSERT INTO Realiza VALUES('28/10/2014', TO_DATE('12/11/2014', 'dd/mm/yyyy'), TO_DATE('28/10/2014', 'dd/mm/yyyy')+14, 'E005', 'P005', 'U005');
INSERT INTO Realiza VALUES('08/11/2014', NULL 								, TO_DATE('08/11/2014', 'dd/mm/yyyy')+14,   'E006', 'P007', 'U006');
INSERT INTO Realiza VALUES('12/11/2014', TO_DATE('14/11/2014', 'dd/mm/yyyy'), TO_DATE('12/11/2014', 'dd/mm/yyyy')+14, 'E007', 'P003', 'U004');
INSERT INTO Realiza VALUES('04/11/2014', TO_DATE('13/11/2014', 'dd/mm/yyyy'), TO_DATE('04/11/2014', 'dd/mm/yyyy')+14, 'E008', 'P004', 'U003');
INSERT INTO Realiza VALUES('13/11/2014', TO_DATE('12/11/2014', 'dd/mm/yyyy'), TO_DATE('13/11/2014', 'dd/mm/yyyy')+14, 'E009', 'P002', 'U002');
INSERT INTO Realiza VALUES('11/11/2014', TO_DATE('14/11/2014', 'dd/mm/yyyy'), TO_DATE('11/11/2014', 'dd/mm/yyyy')+14, 'E010', 'P001', 'U001');
INSERT INTO Realiza VALUES('11/11/2014', NULL                               , TO_DATE('11/11/2014', 'dd/mm/yyyy')+14,   'E010', 'P002', 'U009');
INSERT INTO Realiza VALUES('10/11/2014', TO_DATE('14/11/2014', 'dd/mm/yyyy'), TO_DATE('10/11/2014', 'dd/mm/yyyy')+14, 'E004', 'P001', 'U003');
INSERT INTO Realiza VALUES('05/10/2014', NULL                               , TO_DATE('05/10/2014', 'dd/mm/yyyy')+14,   'E001', 'P007', 'U001');
INSERT INTO Realiza VALUES('08/11/2014', TO_DATE('13/11/2014', 'dd/mm/yyyy'), TO_DATE('08/11/2014', 'dd/mm/yyyy')+14, 'E006', 'P005', 'U010');
COMMIT;
