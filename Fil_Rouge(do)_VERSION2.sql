use fil_rouge
go

INSERT INTO	dbo.ContactFournisseur
	VALUES	('CFS'),
			('CFM')

INSERT INTO	dbo.Fournisseur 
	VALUES	('Sonovente',1),--1
			('MichelMusique',2),--2
			('Musikia',2),--3
			('Star_Musique',1)--4

INSERT INTO	dbo.ContactClient
	VALUES  ('CCOrchestreSymphonique',0),--1
			('CCConcervatoireN',0),--2
			('CCParticulier',1)--3

INSERT	INTO dbo.Client 
	VALUES	('OrchestreSymphoniqueNORD',00.10,1), --1
			('OrchestreSymphoniqueSUD',00.10,1), --2
			('OrchestreSymphoniqueEST',00.10,1), --3
			('OrchestreSymphoniqueOUEST',00.10,1), --4
			('OrchestreSymphoniqueCENTRE',00.10,1), --5
			('ConcervatoireNORD',00.10,2), --6
			('ConcervatoireSUD',00.10,2), --7
			('ConcervatoireEST',00.10,2), --8
			('ConcervatoireOUEST',00.10,2),--9
			('ConcervatoireCENTRE',00.10,2),--10
			('Beethoven',00.50,3),--11
			('Mozart',00.50,3),--12
			('JimmyPage',00.50,3),--13
			('JimmyHendrix',00.50,3),--14
			('KurtCobain',00.50,3),--15
			('Joe Satriani',00.50,3)--16

INSERT INTO Rubrique
	VALUES	('Instrument à Vent'),--1
			('Instrument à Corde'),--2
			('Batterie/Percussion'),--3
			('Piano/Synthetiseur')--4

INSERT INTO	SousRubrique
	VALUES	('Bois',1),--1
			('Cuivres',1),--2
			('Corde Pincées',2),--3
			('Corde Frottées',2),--4
			('Cymbales',3),--5
			('Bongos',3),--6
			('Piano',4),--7
			('Synthetiseur',4)--8

INSERT INTO Produit
	VALUES	(1,'BFABS','Flute à Bec Aulos 303A ELITE SOPRANO',9.00,70,1,1),--1
			(2,'BFTRA','Flute Traversiere STAGG WS-PF211S',179.00,22,1,1),--2
			(3,'BCLAR','Clarinette en Sib,LEVANTE-LVCL4250',349.00,3,1,1),--3
			(4,'CBUGL','Bugles Soprano Sib, ALYSEE FH 8354',499.00,0,2,1),--4
			(5,'CFGUI','Gibson SJ-200 Bob Dylan Players Ed. JIMY PAGE',4222.00,0,3,1),--5
			(1,'CFVIO','VIOLON PRIMA SEMI-PRO 3/4 GARNITURE',250.00,9,4,2),--6
			(2,'CFVIO', 'Violon electrique GEWA 4/4 401647', 400.00,12,4,2),--7
			(3,'CYMBA','SABIAN SBR SPLASH 10',32.00,25,5,2),--8
			(4,'CYMBA','SABIAN SBR RIDE 20',95.00,11,5,2),--9
			(5,'CYMBA','SABIAN XS20 CRASH 14 MEDIUM THIN', 125.00,2,5,2),--10
			(6,'BONGO','PEARL BONGOS 7& 8 1/2 CHENE CARBON VAPOR',172.00,1,6,2),--11
			(7,'PIANO','BOSTON GP 193 PE',33559.00,0,7,2),--12
			(1,'BFABA','Flûte à bec alto Aulos flute a bec alto 309a',39.00,1,1,3),--13
			(2,'BFTRA','Flûte traversiere étude YAMAHA yfl 381 f flute tete argent',1099.00,3,1,3),--14
			(3,'CFGUI','Fender Classic 60s Jaguar Lacquer Fiesta Red RW guitare électrique Référence : 9000-0015-8351',1019.00,0,3,3),--15
			(4,'CFGUI','Fender American Deluxe Strat RW Sun HENDRIX',1498.00,0,3,3),--16
			(5,'PIANO','Bechstein	B190',43356.00,0,7,3),--17
			(1,'SYNTH','PSR-F50 + stand + casque',105.00,17,8,4),--18
			(2,'CFGUI','Stratocaster Jimi Hendrix (MEX, MN) - olympic white',949.00,3,3,4),--19
			(3,'CFGUI','Ibanez JS24P-CA SATRIANI',1349.00,0,3,4),--20
			(4,'CFGUI','Les Paul Standard Pro Plus Top E-Club Ltd 2014 - transparent black',435.00,8,3,4)--21

INSERT INTO EtatCommande
	VALUES	(1,'saisie'),
			(2,'annulée'),
			(3,'préparation'),
			(4,'expédié'),
			(5,'Facturée'),
			(6,'retard paiement'),
			(7,'Soldée')

			
INSERT INTO Commande
	VALUES	(6,'Rue Conservatoir NORD','Rue Conservatoir NORD','2015/09/15','2015/09/16','2015/09/27',7,null), --1
			(7,'Rue ConcervatoireSUD','Rue ConcervatoireSUD','2014/09/7','2014/09/7','2014/09/10',7,null),--2
			(9,'Rue ConcervatoireOUEST','Rue ConcervatoireOUEST','2014/09/03','2014/09/03','2014/09/03',7,null),--3
			(8,'Rue ConcervatoireEST','Rue ConcervatoireEST','2014/09/26','2014/09/26','2014/09/26',7,null),--4
			(10,'Rue ConcervatoireCENTRE','Rue ConcervatoireCENTRE','2014/09/17','2014/09/17','2014/09/17',7,null),--5
			(6,'Rue Conservatoir NORD','Rue Conservatoir NORD','2015/09/15',null,null,3,null),--6
			(7,'Rue ConcervatoireSUD','Rue ConcervatoireSUD','2015/09/13',null,null,3,null),--7
			(9,'Rue ConcervatoireOUEST','Rue ConcervatoireOUEST','2015/09/21',null,null,3,null),--8    --1annulé 2 annulée 3 préparation 
			(8,'Rue ConcervatoireEST','Rue ConcervatoireEST','2015/09/10',null,null,3,null),--9 			4expédié 5 Facturée 6 retard paiement 7 Soldée
			(10,'Rue ConcervatoireCENTRE','Rue ConcervatoireCENTRE','2015/09/06',null,null,4,null),--10 	
			(11,'Rue Beethoven','Rue Beethoven','2015/12/24','2015/12/24','2015/12/24',4,null),
			(12,'Rue Beethoven','Rue Beethoven','2015/12/13','2015/12/13','2015/12/13',5,null),
			(13,'Rue Beethoven','Rue Beethoven','2015/12/07','2015/12/07','2015/12/07',5,null),
			(14,'Rue Beethoven','Rue Beethoven','2015/12/18','2015/12/18','2015/12/18',6,null),
			(15,'Rue Beethoven','Rue Beethoven','2015/12/20','2015/12/20','2015/12/20',6,null),
			(16,'Rue Beethoven','Rue Beethoven','2015/12/06','2015/12/06','2015/12/06',6,null)


INSERT INTO LigneCommande
	VALUES	(1,122,1),
			(3,10,1),
			(5,42,1),
			(4,10,1),
			(17,1,2),
			(21,2,2),
			(13,5,2),
			(18,22,2),
			(3,1,3),
			(9,40,3),
			(5,20,3),
			(17,1,4),
			(2,16,4),
			(5,4,4),
			(16,22,5),
			(4,22,6),
			(12,1,6),
			(1,133,7),
			(3,4,7),
			(5,30,7),
			(4,34,8),
			(17,10,8),
			(21,2,8),
			(13,5,8),
			(18,12,8),
			(3,5,8),
			(9,42,8),
			(5,20,9),
			(17,1,10),
			(2,31,10),
			(5,4,10),
			(16,12,10),
			(4,13,10),
			(12,1,11),
			(15,1,12),
			(5,1,13),
			(16,1,14),
			(19,1,14),
			(17,1,15),
			(20,1,16)
			


use master
go