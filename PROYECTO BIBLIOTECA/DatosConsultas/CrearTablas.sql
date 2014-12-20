CREATE TABLE Estilo
(
	ES#    VARCHAR2(4),
	Nombre VARCHAR2(30),
	CONSTRAINT PK_Estilo_ES# PRIMARY KEY (ES#)
);
--
CREATE TABLE Autor
(
	AU#       VARCHAR2(4),
	Nombre    VARCHAR2(30),
	Apellidos VARCHAR2(50),
	ES# VARCHAR2(4),
	CONSTRAINT PK_Autor_AU# PRIMARY KEY (AU#),
	CONSTRAINT FK_Autor_ES# FOREIGN KEY (ES#) REFERENCES Estilo(ES#) ON DELETE CASCADE
);
--
CREATE TABLE Categoria
(
	CA#    VARCHAR2(4),
	Nombre VARCHAR2(30),
	CONSTRAINT PK_Categoria_CA# PRIMARY KEY (CA#)
);
--
CREATE TABLE Libro
(
	LI#        VARCHAR2(4),
	Titulo     VARCHAR2(50),
	NumPaginas VARCHAR2(4),
	NumEdicion VARCHAR2(30),
	Anio       VARCHAR2(4),
	CA#        VARCHAR2(4),
	CONSTRAINT PK_Libro_LI# PRIMARY KEY (LI#),
	CONSTRAINT FK_Libro_CA# FOREIGN KEY (CA#) REFERENCES Categoria(CA#) ON DELETE CASCADE
);
--
CREATE TABLE Escribe
(
	LI# VARCHAR2(4),
	AU# VARCHAR2(4),
	CONSTRAINT FK_Escribe_AU# FOREIGN KEY(AU#) REFERENCES Autor(AU#) ON DELETE CASCADE,
	CONSTRAINT FK_Escribe_LI# FOREIGN KEY(LI#) REFERENCES Libro(LI#) ON DELETE CASCADE
);
--
CREATE TABLE Prestamo
(
	PR#           VARCHAR2(4),
	Identificador VARCHAR2(30),
	CONSTRAINT PK_Prestamo_PR# PRIMARY KEY (PR#)
);
--
CREATE TABLE Tiene
(
	LI# VARCHAR2(4),
	PR# VARCHAR2(4),
	CONSTRAINT FK_Tiene_LI# FOREIGN KEY(LI#) REFERENCES Libro(LI#) ON DELETE CASCADE,
	CONSTRAINT FK_Tiene_PR# FOREIGN KEY(PR#) REFERENCES Prestamo(PR#) ON DELETE CASCADE
);
--
CREATE TABLE Empleado
(
	EM#       VARCHAR2(4),
	Nombre    VARCHAR2(30),
	Apellidos VARCHAR2(50),
	Turno     VARCHAR2(30),
	CONSTRAINT PK_Empleado_EM# PRIMARY KEY(EM#)
);
--
CREATE TABLE Usuario
(
	US#         VARCHAR2(4),
	Nombre      VARCHAR2(30),
	Apellidos   VARCHAR2(50),
	Direccion   VARCHAR2(30),
	DiasBloqueo NUMBER(4) DEFAULT 0,
	CONSTRAINT PK_Usuario_US# PRIMARY KEY(US#)
);
--
CREATE TABLE Realiza
(
	Fecha DATE, 
	FechaDevolucion DATE,
	FechaLimite DATE,
	EM# VARCHAR2(4),
	PR# VARCHAR2(4),
	US# VARCHAR2(4),
	CONSTRAINT FK_Realiza_EM# FOREIGN KEY(EM#) REFERENCES Empleado(EM#) ON DELETE CASCADE,
	CONSTRAINT FK_Realiza_PR# FOREIGN KEY(PR#) REFERENCES Prestamo(PR#) ON DELETE CASCADE,
	CONSTRAINT FK_Realiza_US# FOREIGN KEY(US#) REFERENCES Usuario(US#) ON DELETE CASCADE
);