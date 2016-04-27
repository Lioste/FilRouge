CREATE TABLE	contactfournisseur(
	IDContactFournisseur		int unsigned NOT NULL AUTO_INCREMENT,
	NomContactFournisseur		varchar(100) not null,
    PRIMARY KEY (`IDContactFournisseur`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE	fournisseur(
	IDFournisseur 				int unsigned NOT NULL AUTO_INCREMENT,
	NomFournisseur				varchar(100) not null,
	IDContactFournisseur 		int REFERENCES ContactFournisseur(IDContactFournisseur),
    PRIMARY KEY (`IDFournisseur`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE	contactclient(
	IDContactClient				int unsigned NOT NULL AUTO_INCREMENT,
	NomContactClient			varchar(100) not null,
	ParticulierContactClient	BOOLEAN not null,
    PRIMARY KEY (`IDContactClient`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE	client(
	IDClient 					int unsigned NOT NULL AUTO_INCREMENT,
	NomClient 					varchar(100) not null,
	CoefClient 					numeric(4,2) not null, 
	IDContactClient				int REFERENCES ContactClient(IDContactClient),
    PRIMARY KEY (`IDClient`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE	TABLE 	rubrique(
	IDRubrique 					int unsigned NOT NULL AUTO_INCREMENT,
	NomRubrique					varchar(100) not null,
    PRIMARY KEY (`IDRubrique`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE 	sousrubrique(
	IDSousRubrique				int unsigned NOT NULL AUTO_INCREMENT,
	NomSousRubrique				varchar(100) not null,
	IDRubrique 					int REFERENCES Rubrique(IDRubrique),
    PRIMARY KEY (`IDSousRubrique`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE	`produit`(
	IDProduit					int unsigned NOT NULL AUTO_INCREMENT,
	FournisseurIDProduit		int not null,
	LibelleCourtProduit			char(5) not null,
	LibelleLongProduit			varchar(100) not null,
	PrixUniteProduit			NUMERIC(10,2) not null,
	StockProduit				int not null,
	IDSousRubrique 				int REFERENCES SousRubrique(IDSousRubrique),
	IDFournisseur 				int REFERENCES Fournisseur(IDFournisseur),
    PRIMARY KEY (`IDProduit`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE	etatcommande(
	IdEtatCommande				ENUM ('0','1','2','3','4','5','6','7'),
	LibelleEtatCommande			varchar(15),
    PRIMARY KEY (`IdEtatCommande`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE	commande(
	IDCommande					int unsigned NOT NULL AUTO_INCREMENT,
	IDClient 					int REFERENCES Client(IDClient),
	AdresseLivraison			varchar(100) not null,
	AdresseFacturation			varchar(100) not null,
	DateCommande				Date not null,
	DateExpeditionCommande		Date null,
	DateReceptionCommande		Date null,
	EtatCommande				int REFERENCES EtatCommande(EtatCommande),
	ReductionCC					numeric(4,2) null,
    PRIMARY KEY (`IDCommande`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE	lignecommande(
	IDLigneCommande				int unsigned NOT NULL AUTO_INCREMENT,
	IDProduit 					int REFERENCES Produit(IDProduit),
	QuantiteProduit				int not null,
	IDCommande 					int REFERENCES Commande(IDCommande),
    PRIMARY KEY (`IDLigneCommande`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(32) COLLATE utf8_unicode_ci NOT NULL,
  `password` char(40) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(120) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(70) COLLATE utf8_unicode_ci NOT NULL,
  `created_at` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `active` char(1) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
