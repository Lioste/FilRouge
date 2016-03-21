--Fil_Rouge_Requete_InterrogationAprevoir


-- Chiffre d'affaire généré pour l'ensemble et par fournisseur


--Par Ligne de commande--

SELECT		IDLigneCommande,Sum

--Par ID Fournisseur 

SELECT		P.IDFournisseur ,Sum(LC.QuantiteProduit*P.PrixUniteProduit)
FROM		LigneCommande LC
JOIN		Produit P ON P.IDProduit = LC.IDProduit
GROUP BY 	P.IDFournisseur
			--- Avec Pourcentage

SELECT		P.IDFournisseur ,Sum(LC.QuantiteProduit*P.PrixUniteProduit) as 'Chiffre d''affaire par Fournisseur',
100*Sum(LC.QuantiteProduit*P.PrixUniteProduit)/(SELECT		Sum(LC.QuantiteProduit*P.PrixUniteProduit)
FROM		LigneCommande LC
JOIN		Produit P ON P.IDProduit = LC.IDProduit)  As 'Pourcentage Du total'

FROM		LigneCommande LC
JOIN		Produit P ON P.IDProduit = LC.IDProduit
GROUP BY 	P.IDFournisseur


--GENERAL--

SELECT		Sum(LC.QuantiteProduit*P.PrixUniteProduit)
FROM		LigneCommande LC
JOIN		Produit P ON P.IDProduit = LC.IDProduit

/*SELECT		LC.IDLigneCommande,Sum(LC.QuantiteProduit*P.PrixUniteProduit)
FROM		Produit P,LIgneCommande LC
GROUP BY	LC.IDLigneCommande


SELECT		P.IDFournisseur,Sum(LC.QuantiteProduit*P.PrixUniteProduit)
FROM		Produit P,LIgneCommande LC
GROUP BY	P.IDFournisseur

SELECT		Sum(LC.QuantiteProduit*P.PrixUniteProduit)
FROM		Produit P,LIgneCommande LC*/

--- Liste des produits commandés (ref produit, qte commandé)

SELECT	P.IDProduit,Sum(LC.QuantiteProduit)
FROM	Produit P
JOIN	LigneCommande LC ON P.IDProduit = LC.IDProduit
GROUP	BY P.IDProduit 

--Liste de produit non commandé

SELECT IDProduit
FROM	Produit
WHERE IDProduit NOT IN (SELECT	IDProduit From LigneCommande)


--- Liste des commandes pour un client (date, ref client, montant)

SELECT		C.DateCommande,C.IDClient,SUM(LC.QuantiteProduit*P.PrixUniteProduit) as 'Total de la commande',COUNT(*)
FROM		Commande C
JOIN		LigneCommande LC ON C.IDCommande = LC.IDCommande
JOIN		Produit P ON LC.IDProduit = P.IDProduit
--WHERE		C.IDClient = 7
GROUP BY	C.IDClient,C.DateCommande
ORDER BY	C.IDClient

-- Répartition du chiffre d'affaire par type de client

/*SELECT 		SUM(LC.QuantiteProduit*P.PrixUniteProduit)as 'Chiffre D''affaire par type client',CC.ParticulierContactClient
FROM 		LigneCommande LC, ContactClient CC,Produit P
GROUP BY	CC.ParticulierContactClient */

SELECT 		SUM(LC.QuantiteProduit*P.PrixUniteProduit) + Sum(P.StockProduit*P.PrixUniteProduit) as 'Chiffre D''affaire par type client',CC.ParticulierContactClient
FROM 		ContactClient CC,Produit P
JOIN		LigneCommande LC ON P.IDProduit = LC.IDProduit	
JOIN		Commande C ON LC.IDCommande = C.IDClient
--WHERE		C.EtatCommande > 4
GROUP BY	CC.ParticulierContactClient

--- Lister les commandes en cours de livraison$

SELECT		*
FROM		Commande
WHERE		DateReceptionCommande is null

