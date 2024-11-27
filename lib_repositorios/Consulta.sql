CREATE DATABASE gestionador_productos;
USE gestionador_productos;

CREATE TABLE personas (
    id INT PRIMARY KEY IDENTITY, 
    nombre VARCHAR(20), 
    cedula INT
);

CREATE TABLE paquetes (
    id INT PRIMARY KEY IDENTITY, 
    tipo_paquete VARCHAR(50),
    medida VARCHAR(15)
);

CREATE TABLE transportistas (
    id INT PRIMARY KEY IDENTITY, 
    tipo_transportista VARCHAR(15)
);


CREATE TABLE estados (
    id_estado INT PRIMARY KEY IDENTITY,
	etapa VARCHAR(15),
);


CREATE TABLE detalles (
    id INT PRIMARY KEY IDENTITY, 
    descripcion VARCHAR(50), 
    id_paquete INT,
    FOREIGN KEY (id_paquete) REFERENCES paquetes(id),
	id_estado INT, 
	FOREIGN KEY (id_estado) REFERENCES estados(id_estado),
    id_transportista INT, 
    FOREIGN KEY (id_transportista) REFERENCES transportistas(id),
    fecha_entrega DATE
);

CREATE TABLE pedidos (
    id INT PRIMARY KEY IDENTITY, 
    codigo VARCHAR(8),
    id_persona INT,
    FOREIGN KEY (id_persona) REFERENCES personas(id),
    id_detalle INT, 
    FOREIGN KEY (id_detalle) REFERENCES detalles(id)
);



INSERT INTO personas (nombre, cedula)
VALUES ('Samuel', 234), 
       ('Miguel', 123); 

INSERT INTO transportistas (tipo_transportista)
VALUES ('Carro'), 
       ('Moto'),
       ('Avion'), 
       ('Camion');

INSERT INTO paquetes (tipo_paquete, medida)
VALUES ('Sobre', '17'),
       ('Caja de carton', '30 x 25 x 15'),
       ('Contenedor de plastico', '30 x 20 x 15'),
       ('Contenedor grande', '80 x 60 x 40');

INSERT INTO estados (etapa)
VALUES ('Entregado'),
       ('Por entregar');


INSERT INTO detalles (descripcion, id_estado, id_paquete, id_transportista, fecha_entrega)
VALUES ('Manizales - Cordoba', 1, 2, 1, '2024-06-15'),
       ('Medellin - Buenos Aires', 2, 3, 3, '2024-06-22'),
       ('Medellin - Medellin', 1, 1, 2, '2024-06-12'),
       ('Quibdo - Leticia', 2, 4, 4, '2024-06-20');

INSERT INTO pedidos (codigo, id_persona, id_detalle)
VALUES ('P03', 1, 1),
       ('P06', 1, 2),
       ('P06', 2, 3), 
       ('P07', 2, 4);
