use master;
go
drop database if exists edunovawp4;
go
create database edunovawp4;
go
use edunovawp4;
create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null ,
trajanje int,
cijena decimal(18,2),
izvodiseod datetime,
verificiran bit
);

