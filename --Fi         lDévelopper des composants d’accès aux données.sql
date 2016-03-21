--D�velopper des composants d�acc�s aux donn�es




--Formaliser des requ�tes � l'aide du langage SQL


--1. Pour chacune des interrogations demand�es (voir cahier des charges), cr�ez un
--script contenant la ou les requ�tes n�cessaires. 


----------------------Chiffre d'affaire g�n�r� pour l'ensemble et par fournisseur	
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
--------------------- Liste des produits command�s (ref produit, qte command�)
SELECT		 IDProduit,SUM(QuantiteProduit) as 'Adition'
FROM		LigneCommande LC
JOIN		Commande C ON C.IDCommande = LC.IDCommande
WHERE		C.EtatCommande > 2
GROUP BY	IDProduit
ORDER BY	IDProduit
----------------------Liste Produit non command�
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
--------------------- R�partition du chiffre d'affaire par type de client
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


--2. Exportez les tables principales (entit�) vers des tableaux d�un tableur de votre
--choix ainsi que le contenu du r�sultat de vos requ�tes.
--Ces tableaux devront apparaitre dans votre dossier final.



--Programmer des proc�dures stock�es sur le SGBD


--Cr�ez une proc�dure stock�e qui s�lectionne les commandes non sold�es (en cours
--de livraison), puis une autre qui renvoie le d�lai moyen entre la date de commande
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

--G�rer les vues


--Cr�ez une vue correspondant � la jointure Produits - Fournisseurs :
CREATE VIEW JointureFourniProduit
AS
SELECT	P.*,F.NomFournisseur
FROM	Produit P
JOIN	Fournisseur F ON F.IDFournisseur = P.IDFournisseur

SELECT		* 
FROM		JointureFourniProduit