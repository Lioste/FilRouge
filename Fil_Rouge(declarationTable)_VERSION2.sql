/*



use fil_rouge
go 

drop user ServiceFournisseur 
drop user Administrateur 
drop user Client 
drop user ServiceCommercial
go
drop login ServiceCommercial
drop login ServiceFournisseur
drop login Administrateur
drop login Client
go
drop role COMMERCIAL
drop role ADMINISTRATION
drop role FOURNISSEUR
drop role CLIENTELE
go

use master
GO

drop database Fil_Rouge
GO



*/
CREATE DATABASE Fil_Rouge
GO

USE Fil_Rouge
GO

CREATE TABLE	ContactFournisseur(
	IDContactFournisseur		int IDENTITY PRIMARY KEY,
	NomContactFournisseur		varchar(100) not null
)

CREATE TABLE	Fournisseur(
	IDFournisseur 				int IDENTITY PRIMARY KEY,
	NomFournisseur				varchar(100) not null,
	IDContactFournisseur 		int REFERENCES ContactFournisseur(IDContactFournisseur)
)

CREATE TABLE	ContactClient(
	IDContactClient				int IDENTITY PRIMARY KEY,
	NomContactClient			varchar(100) not null,
	ParticulierContactClient	bit not null
)

CREATE TABLE	Client(
	IDClient 					int IDENTITY PRIMARY KEY,
	NomClient 					varchar(100) not null,
	CoefClient 					numeric(4,2) not null, 
	IDContactClient				int REFERENCES ContactClient(IDContactClient)
)

CREATE	TABLE 	Rubrique(
	IDRubrique 					int IDENTITY PRIMARY KEY,
	NomRubrique					varchar(100) not null
)

CREATE TABLE 	SousRubrique(
	IDSousRubrique				int IDENTITY PRIMARY KEY,
	NomSousRubrique				varchar(100) not null,
	IDRubrique 					int REFERENCES Rubrique(IDRubrique)
)

CREATE TABLE	Produit(
	IDProduit					int IDENTITY PRIMARY KEY,
	FournisseurIDProduit	int not null,
	LibelleCourtProduit			char(5) not null,
	LibelleLongProduit			varchar(100) not null,
	PrixUniteProduit			money not null,
	StockProduit				int not null,
	IDSousRubrique 				int REFERENCES SousRubrique(IDSousRubrique),
	IDFournisseur 				int REFERENCES Fournisseur(IDFournisseur)
)

CREATE TABLE	EtatCommande(
	EtatCommande				int CHECK (EtatCommande BETWEEN 1 AND 7) PRIMARY KEY,
	LibelleEtatCommande			varchar(15)
)

CREATE TABLE	Commande(
	IDCommande					int IDENTITY PRIMARY KEY,
	IDClient 					int REFERENCES Client(IDClient),
	AdresseLivraison			varchar(100) not null,
	AdresseFacturation			varchar(100) not null,
	DateCommande				Date not null,
	DateExpeditionCommande		Date null,
	DateReceptionCommande		Date null,
	EtatCommande				int REFERENCES EtatCommande(EtatCommande),
	ReductionCC					numeric(4,2) null,
)

CREATE TABLE	LigneCommande(
	IDLigneCommande				int IDENTITY PRIMARY KEY,
	IDProduit 					int REFERENCES Produit(IDProduit),
	QuantiteProduit				int not null,
	IDCommande 					int REFERENCES Commande(IDCommande)
)

GO

create login ServiceCommercial with password = 'commmercial', DEFAULT_DATABASE=[Fil_Rouge],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

create login ServiceFournisseur with password = 'fournisseur', DEFAULT_DATABASE=[Fil_Rouge],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

create login Administrateur with password = 'admin', DEFAULT_DATABASE=[Fil_Rouge],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

create login Client with password = 'particulier', DEFAULT_DATABASE=[Fil_Rouge],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF

create user ServiceCommercial for login ServiceCommercial
create user ServiceFournisseur for login ServiceFournisseur
create user Administrateur for login Administrateur
create user Client for login Client

go

		create role ADMINISTRATION

grant control on schema ::dbo to ADMINISTRATION
		
		create role FOURNISSEUR

grant control on dbo.RUBRIQUE to FOURNISSEUR
grant control on dbo.SOUSRUBRIQUE to FOURNISSEUR
grant control on dbo.PRODUIT to FOURNISSEUR
		

		Create role COMMERCIAL 

grant update(ReductionCC) on dbo.COMMANDE to COMMERCIAL
grant update(coefClient) on dbo.CLIENT to COMMERCIAL

		Create role CLIENTELE 

grant select on dbo.COMMANDE to CLIENTELE
grant select on dbo.PRODUIT to CLIENTELE
grant update (AdresseLivraison,AdresseFacturation) on dbo.Commande to CLIENTELE
grant update (IdProduit ,QuantiteProduit) on dbo.LigneCommande to CLIENTELE
go	
		execute sp_addrolemember 'ADMINISTRATION','Administrateur'
		execute sp_addrolemember 'FOURNISSEUR','ServiceFournisseur'		
		execute sp_addrolemember 'COMMERCIAL','ServiceCommercial'
		execute sp_addrolemember 'CLIENTELE','Client'