--Développer des composants d’accès aux données




--Formaliser des requêtes à l'aide du langage SQL


--1. Pour chacune des interrogations demandées (voir cahier des charges), créez un
--script contenant la ou les requêtes nécessaires. 


----------------------Chiffre d'affaire généré pour l'ensemble et par fournisseur	
--CA FOURNISSEUR GLOBAL
SELECT		SUM(LC.QuantiteProduit*P.PrixUniteProduit+P.StockProduit*P.PrixUniteProduit) as 'Adition'
FroM		Commande C
JOIN		LigneCommande LC ON C.IDCommande = LC.IDCommande
JOIN		Produit P ON P.IDProduit = LC.IDProduit
JOIN		Fournisseur F ON F.IDFournisseur = P.IDFournisseur
WHERE		C.EtatCommande >= 3 
--CA Par Fournisseur (stock + commande >= En preparation)
SELECT		F.NomFournisseur,SUM(LC.QuantiteProduit*P.PrixUniteProduit+P.StockProduit*P.PrixUniteProduit) as 'Adition'
FroM		Commande C
JOIN		LigneCommande LC ON C.IDCommande = LC.IDCommande
JOIN		Produit P ON P.IDProduit = LC.IDProduit
JOIN		Fournisseur F ON F.IDFournisseur = P.IDFournisseur
WHERE		C.EtatCommande >= 3 AND LC.IDCommande = C.IDCommande
GROUP BY	F.NomFournisseur
--------------------- Liste des produits commandés (ref produit, qte commandé)
SELECT		 IDProduit,SUM(QuantiteProduit) as 'Adition'
FROM		LigneCommande LC
JOIN		Commande C ON C.IDCommande = LC.IDCommande
WHERE		C.EtatCommande > 2
GROUP BY	IDProduit
ORDER BY	IDProduit
----------------------Liste Produit non commandé
SELECT IDProduit,LibelleCourtProduit,LibelleLongProduit
FROM	Produit
WHERE IDProduit NOT IN (SELECT	LC.IDProduit 
						From LigneCommande LC 
						JOIN Commande C ON  C.IDCommande = LC.IDCommande
						WHERE C.EtatCommande > 2)
--------------------- Liste des commandes pour un client (date, ref client, montant)
SELECT		C.IDClient,C.DateCommande,SUM(P.PrixUniteProduit*LC.QuantiteProduit) as 'Adition'
FROM		Commande C
JOIN		LigneCommande LC ON LC.IDCommande = C.IDCommande
JOIN		Produit P ON P.IDProduit = LC.IDProduit
WHERE		C.EtatCommande > 2 --AND C.IDClient = 9
GROUP BY    C.IDClient,C.DateCommande
ORDER BY	C.IDClient
--------------------- Répartition du chiffre d'affaire par type de client
SELECT		CC.ParticulierContactClient, SUM(P.PrixUniteProduit*LC.QuantiteProduit) as 'Adition'
FROM		ContactClient CC
JOIN		Client CLI ON CLI.IDContactClient = CC.IDContactClient
JOIN		Commande C ON C.IDClient = CLI.IDClient
JOIN		LigneCommande LC ON LC.IDCommande = C.IDCommande
JOIN		Produit P ON P.IDProduit = LC.IDProduit
WHERE		C.EtatCommande > 2
GROUP BY	CC.ParticulierContactClient

--------------------- Lister les commandes en cours de livraison.
SELECT	*
FROM	COMMANDE
WHERE	EtatCommande > 3 AND DateReceptionCommande is null


--2. Exportez les tables principales (entité) vers des tableaux d’un tableur de votre
--choix ainsi que le contenu du résultat de vos requêtes.
--Ces tableaux devront apparaitre dans votre dossier final.



--Programmer des procédures stockées sur le SGBD


--Créez une procédure stockée qui sélectionne les commandes non soldées (en cours
--de livraison), puis une autre qui renvoie le délai moyen entre la date de commande
--et la date de facturation.

CREATE PROC CommandeNonSolde
AS 

SELECT		*
FROM		Commande C
WHERE		C.EtatCommande > 3 AND C.DateReceptionCommande is null

Exec		CommandeNonSolde

CREATE PROC	DelaiMoyenLivraison
AS

SELECT		AVG(DATEDIFF(day, DateExpeditionCommande, DateReceptionCommande))AS 'Temps moyen de livraison'
FROM		Commande C

Exec		DelaiMoyenLivraison

--Gérer les vues


--Créez une vue correspondant à la jointure Produits - Fournisseurs :
CREATE VIEW JointureFourniProduit
AS
SELECT	P.*,F.NomFournisseur
FROM	Produit P
JOIN	Fournisseur F ON F.IDFournisseur = P.IDFournisseur

SELECT		* 
FROM		JointureFourniProduit