CREATE DATABASE PC_ShopBD

/*Crear tabla de los Clientes*/
CREATE TABLE Clientes (
DNI_Cliente BIGINT,
Nombre_Cliente VARCHAR(40),
Apellido_Cliente VARCHAR(40),
Fecha_Nacimiento DATE,
Lugar_Nacimiento VARCHAR(30),
Direccion TEXT,
Correo_Cliente VARCHAR(40),
Telefono_Cliente VARCHAR(11),
PRIMARY KEY (DNI_Cliente)
)

/*Insertar registro en la tabla Clientes*/
INSERT INTO Clientes (DNI_Cliente, Nombre_Cliente, Apellido_Cliente, Fecha_Nacimiento, Lugar_Nacimiento, Direccion, Correo_Cliente, Telefono_Cliente) VALUES 
(40212802785, 'Cristian Isaac', 'Vargas', '2001-04-03', 'Republica Dominicana', 'Cerros del Ozama', 'civargas34@gmail.com', '8097537928')

/*Consulta a la tabla Usuarios*/
SELECT * FROM Clientes

/*--------------------------------------------------------------------------------------------------------------------*/

/*Crear tabla de los Usuarios*/
CREATE TABLE Usuarios (
ID_Usuario INT NOT NULL AUTO_INCREMENT,
Nombre_Usuario VARCHAR(40),
Apellido_Usuario VARCHAR(40),
Correo_Usuario VARCHAR(40),
Contrasena VARCHAR(25),
Telefono_Usuario VARCHAR(11),
Turno_Usuario VARCHAR(15),
PRIMARY KEY (ID_Usuario)
)

/*Insertar registros en la tabla de los Usuarios*/
INSERT INTO Usuarios (Nombre_Usuario, Apellido_Usuario, Correo_Usuario, Contrasena, Telefono_Usuario, Turno_Usuario) VALUES 
('Juan Alberto', 'Perez Santana', 'japerez@gmail.com', 'juan12345', '8093867575', 'Remoto')
INSERT INTO Usuarios (Nombre_Usuario, Apellido_Usuario, Correo_Usuario, Contrasena, Telefono_Usuario, Turno_Usuario) VALUES 
('Felipe', 'Rodriguez', 'frodriguez@gmail.com', 'Felipe12345', '8096975326', 'Mañana')

/*Consulta a la tabla Usuarios*/
SELECT * FROM Usuarios

/*--------------------------------------------------------------------------------------------------------------------*/

/*Crear tabla de las Computadoras*/
CREATE TABLE Computadoras (
ID_Computadora INT NOT NULL AUTO_INCREMENT,
Marca VARCHAR(40),
Modelo VARCHAR(40),
Color VARCHAR(40),
Fecha_Llegada DATE,
Precio FLOAT,
Descripcion TEXT,
PRIMARY KEY (ID_Computadora)
)

/*Insertar registro a la tabla de Computadoras*/
INSERT INTO Computadoras(Marca, Modelo, Color, Fecha_Llegada, Precio, Descripcion) VALUES
('Lenovo', 'IdeaPad s300', 'Gris', '2019-09-03', 15500.50, "Excelente para las clases virtuales")

/*Consulta a la tabla Computadoras*/
SELECT * FROM Computadoras

/*--------------------------------------------------------------------------------------------------------------------*/

/*Crear tabla de las Facturas*/
CREATE TABLE Facturas (
ID_Factura INT NOT NULL AUTO_INCREMENT,
DNI_Cliente BIGINT,
ID_Usuario INT,
ID_Computadora INT,
Fecha_Factura DATE,
Subtotal FLOAT,
Descuento FLOAT,
Total_Venta FLOAT,
PRIMARY KEY (ID_Factura),
FOREIGN KEY (DNI_Cliente) REFERENCES Clientes(DNI_Cliente),
FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario),
FOREIGN KEY (ID_Computadora) REFERENCES Computadoras(ID_Computadora)
)

/*Insertar registro a la Tabla Facturas*/
INSERT INTO Facturas (DNI_Cliente, ID_Usuario, ID_Computadora, Fecha_Factura, Subtotal, Descuento, Total_Venta) VALUES
(40212802785 /*DNI del Cliente*/, 2 /*ID del Usuario*/, 1 /*ID de la Computadora*/, '2021-08-07' /*Llegada de la computadora*/,  15500.50/*El mismo precio de la Compu*/, NULL/*Descuento*/, 15500.50 /*Total*/)

SELECT * FROM Facturas
