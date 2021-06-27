CREATE DATABASE if NOT EXISTS aev7 CHARACTER SET UTF8;
SET default_storage_engine=INNODB;
USE aev7;

CREATE TABLE if NOT EXISTS empleados
(nif VARCHAR(10) NOT NULL,
nombre VARCHAR(20) NOT NULL,
apellidos VARCHAR(30) NOT NULL,
administrador TINYINT(1) NOT NULL,
contrasenya VARCHAR(20),
PRIMARY KEY (nif));

CREATE TABLE if NOT EXISTS fichajes
(id INT(11) NOT NULL AUTO_INCREMENT,
nif VARCHAR(10) NOT NULL,
fechaHora_Entrada DATETIME NOT NULL,
estado_Entrada BOOL NOT NULL,
fechaHora_Salida DATETIME,
estado_Salida BOOL NOT NULL,
PRIMARY KEY (id));

INSERT INTO empleados (nif, nombre, apellidos, administrador, contrasenya) 
VALUES ('11111111-H', 'Juan', 'Marqués', TRUE, '1dam');

DELETE FROM empleados WHERE nif="11111111H";

DELETE TABLE empleados;

Select * from empleados;

SELECT nif FROM empleados;

SELECT nif,nombre,apellidos,administrador,contrasenya FROM empleados;

SELECT * FROM empleados WHERE nif LIKE "11111111-H" AND contrasenya LIKE "_%";

UPDATE fichajes SET estado_Salida = TRUE WHERE nif LIKE "48068408-F" AND estado_Salida LIKE FALSE;

UPDATE fichajes SET fechaHora_Salida = "2025-05-04 01:05:02", estado_Salida = TRUE 
WHERE nif LIKE "22222222-A" AND estado_Salida LIKE FALSE;

SELECT e.nombre, e.apellidos, f.fechaHora_Entrada FROM empleados e INNER JOIN fichajes f 
ON e.nif=f.nif WHERE f.estado_Salida IS FALSE;

SELECT fechaHora_Entrada,fechaHora_Salida FROM fichajes WHERE nif LIKE "24508408-F"
AND estado_Entrada LIKE TRUE AND estado_Salida LIKE TRUE AND fechaHora_Entrada >= "2021-05-01 00:00:00"
AND fechaHora_Salida <= "2021-05-07 23:59:59" AND fechaHora_Salida NOT LIKE "0001-01-01 00:00:00";

UPDATE fichajes SET estado_Salida = false 
WHERE nif LIKE "22222222-A" AND estado_Salida LIKE FALSE;
