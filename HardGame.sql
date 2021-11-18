/* INICIO TABELAS */
CREATE TABLE LOJA
(
	LojaID	INTEGER NOT NULL,
	Rua		VARCHAR(50),
	Numero	INTEGER,
	Cidade	VARCHAR(15)
	PRIMARY KEY (LojaID)
);

CREATE TABLE FORNECEDOR
(
	FornecedorID	INTEGER NOT NULL,
	Nome			VARCHAR(50) NOT NULL,
	Telefone		VARCHAR(9)
	PRIMARY KEY		(FornecedorID)
);

CREATE TABLE CLIENTE
(
	NIF			INTEGER NOT NULL,
	Primeiro	VARCHAR(25),
	Sobrenome	VARCHAR(25)
	PRIMARY KEY (NIF)
);

CREATE TABLE FUNCIONARIO
(
	FuncionarioID	INTEGER NOT NULL,
	Nome			VARCHAR(50) NOT NULL,
	Tipo			CHAR(1),
	Sexo			CHAR(1),
	LojaID			INTEGER NOT NULL,
	FOREIGN KEY (LojaID) REFERENCES LOJA(LojaID)
		ON DELETE CASCADE ON UPDATE CASCADE,
	PRIMARY KEY (FuncionarioID)
);

CREATE TABLE PRODUTO
(
	ProdutoID	INTEGER NOT NULL,
	Nome		VARCHAR(50),
	Preco		MONEY NOT NULL,
	PRIMARY KEY (ProdutoID)
);

CREATE TABLE CONSOLA
(
	ProdutoID	INTEGER NOT NULL,
	Geracao		INTEGER,
	FOREIGN KEY (ProdutoID) REFERENCES PRODUTO(ProdutoID)
		ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE JOGO
(
	ProdutoID	INTEGER NOT NULL,
	Genero		VARCHAR(15),
	FOREIGN KEY (ProdutoID) REFERENCES PRODUTO(ProdutoID)
		ON DELETE CASCADE ON UPDATE CASCADE,
)

CREATE TABLE TEM
(
	LojaID	INTEGER NOT NULL,
	NIF	INTEGER NOT NULL,
	FOREIGN KEY (LojaID) REFERENCES LOJA(LojaID)
		ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (NIF) REFERENCES CLIENTE(NIF)
		ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE COMPRA
(
	FornecedorID	INTEGER NOT NULL,
	LojaID			INTEGER NOT NULL,
	ProdutoID		INTEGER NOT NULL,
	Quantidade		INTEGER NOT NULL,
	DataCompra		DATE,
	PRIMARY KEY (FornecedorID, LojaID, ProdutoID),
	FOREIGN KEY (FornecedorID) REFERENCES FORNECEDOR(FornecedorID)
	ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (LojaID) REFERENCES LOJA(LojaID)
	ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (ProdutoID) REFERENCES PRODUTO(ProdutoID)
	ON DELETE CASCADE ON UPDATE CASCADE

)

CREATE TABLE VENDA
(
	FuncionarioID	INTEGER NOT NULL,
	NIF				INTEGER NOT NULL,
	ProdutoID		INTEGER NOT NULL,
	Quantidade		INTEGER NOT NULL,
	DataCompra		DATE
	PRIMARY KEY (FuncionarioID, NIF, ProdutoID),
	FOREIGN KEY (FuncionarioID) REFERENCES FUNCIONARIO(FuncionarioID)
	ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (NIF) REFERENCES CLIENTE(NIF)
	ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (ProdutoID) REFERENCES PRODUTO(ProdutoID)
	ON DELETE CASCADE ON UPDATE CASCADE
)

select * from loja

/* FIM TABELAS */

INSERT INTO PRODUTO
VALUES  (1,'CyberPunk 2077',48),
		(2,'Haven',30),
		(3,'Football Manager 2021',45),
		(4,'COD Black Ops Cold War',47.5),
		(5,'Handball 2021',34),
		(6,'DiRT 5',41),
		(7,'Watch Dogs: Legion',40),
		(8,'Amnesia Rebirth',15),
		(9,'Fifa 21',55),
		(10,'EFootball PES 2021',30),
		(11,'Crusader Kings 3',50),
		(12,'Marvel Avengers',60),
		(13,'Captain Tsubasa',13),
		(14,'Surgeon Simulator 2',20),
		(15,'Death Stranding',52),
		(16,'Sword Art Online',23),
		(17,'Minecraft Dungeons',31),
		(18,'Saints Row: The Third Remastered',36),
		(19,'Resident Evil Resistance',28),
		(20,'Nintendo Switch',289.99),
		(21,'Xbox Series X',499),
		(22,'Playstation 4',219.99),
		(23,'Playstation 5',399.99),
		(24,'Xbox One',259.99),
		(25,'GameBoy Advanced',200),
		(26,'Alice madness',18.9), 
        (27,'Rocket League',10),
		(29,'Just Dance 5',29.),
		(30,'Halo:Master Chief',40.),
		(31,'Nitendo Branco',89),
		(32,'PlayStation 3',79),
		(33,'The Sims 3',8),
		(34,'Diablo III',14),
		(35,'The Sims 4',8);

INSERT INTO CONSOLA
  VALUES    (21,5),
			(22,4),
			(23,5),
			(24,4),
			(25,1),
			(32,3);

INSERT INTO JOGO
  VALUES(1,'Mundo Aberto'),
		(2,'Aventura'),
		(3,'Desporto'),
		(4,'FPS'),
		(5,'Desporto'),
		(6,'Carros'),
		(7,'Mundo Aberto'),
		(8,'Terror'),
		(9,'Desporto'),
		(10,'Desporto'),
		(11,'Estrategia'),
		(12,'Aventura'),
		(13,'Desporto'),
		(14,'Simulador'),
		(15,'Mundo Aberto'),
		(16,'RPG'),
		(17,'Aventura'),
		(18,'Mundo Aberto'),
		(19,'Terror'),
		(26,'Terror'), 
        (27,'Desporto'),
		(29,'Simulador'),
		(30,'FPS'),
		(33,'Simulador'),
		(34,'RPG'),
		(35,'Simulador');

INSERT INTO LOJA
  VALUES (1,'R. da Constituicao',13,'Porto'),
         (2,'Av. Dom Afonso Henriques',1037,'Porto'),
		 (3,'R. António Do Espírito Santo',94,'Leiria'),
		 (4,'R. João de Freitas Branco',34,'Lisboa'),
		 (5,'R. António Rodrigues Rocha',297,'Gaia');

INSERT INTO FUNCIONARIO
  VALUES (1,'Alice Fabroso','P','F',3),
         (2,'Rafael Soares','P','M',2),
		 (3,'Luiza Cardoso','F','F',1),
		 (4,'Miguel Salazar','F','M',4),
		 (5,'Guilherme Alves','P','M',4),
		 (6,'Arthur Goncalves','F','M',3),
		 (7,'Matilde Santos','F','F',2);

INSERT INTO FORNECEDOR
  VALUES (1,'CapitalGames','21295646'),
         (2,'Arena Games','21258215'),
		 (3,'PCM Eletronica','22255725'),
		 (4,'Oceano Informatica','93535734'),
		 (5,'MegaGames','96266634');

INSERT INTO CLIENTE
  VALUES (1,'Fernanda','Chaves'),
		 (2,'Joao','Loureiro'),
         (3,'Isabel','Gomes'),
		 (4,'Tanaka','Santos'),
		 (5,'Patrick','Vieira'),
		 (6,'Nicolash','Alves'),
		 (7,'Marina',null),
		 (8,'Alex','Progenio'),
		 (9,'Renan',null),
		 (10,null,null);

INSERT INTO COMPRA /*Fornecedor, Loja, Produto, Quantidade, Data */ 
 VALUES (5,3,3,2,'2020-01-14'),
		(1,1,2,4,'2020-06-13'),
		(3,2,32,1,'2020-02-16'),
		(1,4,22,2,'2020-02-16'),
		(1,3,12,8,'2020-08-03'),
		(4,2,11,4,'2020-09-27'),
		(2,5,17,2,'2020-02-06'),
		(1,4,21,3,'2020-11-29'),
		(1,2,12,4,'2020-03-22'),
		(2,2,11,11,'2020-10-12'),
		(2,5,23,10,'2020-04-28'),
		(4,3,30,38,'2020-06-01');

INSERT INTO VENDA /*Funcionario, NIF, ProdutoID,Quantidade, Data */
  VALUES(2,2,11,100,'2020-04-23'),
		(4,2,19,1,'2020-12-27'),
		(7,3,20,1,'2020-11-11'),
		(4,4,32,2,'2020-03-01'),
		(2,5,8,1,'2020-02-02'),
		(4,5,4,1,'2020-11-04'),
		(3,1,1,4,'2020-12-12'),
		(6,9,3,1,'2020-12-11'),
		(7,6,27,2,'2020-08-23'),
		(2,7,24,1,'2020-09-29'),
		(1,3,21,1,'2020-10-30'),
		(2,10,11,2,'2020-12-31'),
		(3,1,18,1,'2020-09-10'),
		(4,2,2,3,'2020-01-19');

INSERT INTO TEM /*LojaID, NIF*/
	VALUES	(1,2),
			(1,5),
			(1,7),
			(2,1),
			(2,2),
			(3,3),
			(4,5),
			(5,10),
			(5,9),
			(4,7),
			(2,6);
 
