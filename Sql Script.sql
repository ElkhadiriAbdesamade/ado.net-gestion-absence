create database OfpptAbsence
go 
use OfpptAbsence



create table Stagiaire
(
CefStagiaire varchar(100) primary key,
NomStagiaire varchar(100),
PrenomStagiaire varchar(100),
GroupStagiaire varchar(100),
CinStagiaire varchar(100),
NombreAbsenceJust int,
NombreAbsenceNonJust int,
NombreRetard int
)

create table Utilisateur
(
NomUtilisateur varchar(100),
Login varchar(100) primary key,
Password varchar(100),
TypeUser varchar(100)
)

create table Absence
(
IdAbsence int identity(1,1) primary key,
CefStagiaire varchar(100) foreign key references stagiaire(CefStagiaire),
DateAbss dateTime,
TypeAbss varchar(100),
DocumentDeJustification varchar(200),
EtatSanction01 int,
EtatSanction02 int,
EtatSanction03 int,
EtatSanction04 int,
EtatSanction05 int,
EtatSanction06 int,
EtatSanction07 int,
EtatSanction08 int
)

delete from Utilisateur
select * from Utilisateur

select * from Absence 
delete from absence
select * from Stagiaire
delete from Stagiaire

 
insert into Stagiaire values('1234','aa','aa','C202','xxx',0,0,0)
insert into Utilisateur values('SimoU','user','user','U')
insert into Utilisateur values('SimoA','Admin','Admin','A')











SELECT FORMAT (getdate(), 'dd/MM/yyyy ') as date


create proc ajouterAbsNonJustNormal (@cef varchar(100),@dateAbs date,@typeAbs varchar(100))
as
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,0,0,0,0,0,0,0)


exec ajouterAbsNonJustNormal '1999072800079', '06/20/2020','Absence Non Justifier'




create proc ajouterAbsNonJustSanction (@cef varchar(100),@dateAbs date,@typeAbs varchar(100),@Sanction varchar(100))
as
if(@Sanction like'EtatSanction01')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,1,0,0,0,0,0,0,0)
end
if(@Sanction like'EtatSanction02')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,1,0,0,0,0,0,0)
end
if(@Sanction like'EtatSanction03')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,0,1,0,0,0,0,0)
end
if(@Sanction like'EtatSanction04')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,0,0,1,0,0,0,0)
end
if(@Sanction like'EtatSanction05')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,0,0,0,1,0,0,0)
end
if(@Sanction like'EtatSanction06')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,0,0,0,0,1,0,0)
end
if(@Sanction like'EtatSanction07')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,0,0,0,0,0,1,0)
end
if(@Sanction like'EtatSanction08')
begin
insert into Absence values(@cef,@dateAbs, @typeAbs,null,0,0,0,0,0,0,0,1)
end




create trigger SupprimerAbsence
On Absence for Delete
as
declare @CefStagiaire varchar(100),@TypeAbs varchar(100)
set @CefStagiaire =( select CefStagiaire from deleted)
set @TypeAbs =(select TypeAbss from deleted)
if(@TypeAbs ='Absence Justifier')
begin 
Update Stagiaire set NombreAbsenceJust=NombreAbsenceJust - 1 where CefStagiaire=@CefStagiaire 
end
if(@TypeAbs ='Absence Non Justifier')
begin 
Update Stagiaire set NombreAbsenceNonJust=NombreAbsenceNonJust - 1 where CefStagiaire=@CefStagiaire 
end


create trigger UpdateStagiaire
On Absence for Insert
as
declare @CefStagiaire varchar(100),@TypeAbs varchar(100)
set @CefStagiaire =( select CefStagiaire from inserted)
set @TypeAbs =(select TypeAbss from inserted)
if(@TypeAbs ='Absence Justifier')
begin 
Update Stagiaire set NombreAbsenceJust=NombreAbsenceJust + 1 where CefStagiaire=@CefStagiaire 
end
if(@TypeAbs ='Absence Non Justifier')
begin 
Update Stagiaire set NombreAbsenceNonJust=NombreAbsenceNonJust + 1 where CefStagiaire=@CefStagiaire 
end
if(@TypeAbs ='Retard')
begin 
Update Stagiaire set NombreRetard=NombreRetard + 1 where CefStagiaire=@CefStagiaire 
end

select Distinct GroupStagiaire from stagiaire order by GroupStagiaire asc

select * from Stagiaire