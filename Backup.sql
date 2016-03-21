use master
go

exec sp_addumpdevice 'disk','savPap5','C:\Backup\Filrouge5.bak'
go

backup database Fil_Rouge to savPap5
go

restore database Fil_Rouge from savPap5 with replace

/* 
--RESTAURATION FAIL
-liberer base => mode exclusif
alter database Fil_Rouge set restricted_user with rollback immediate
-remettre base en mode multi utilisateur
alter database Fil_Rouge set multi_user */