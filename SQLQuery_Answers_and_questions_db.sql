create database ANSWERS_AND_QUESTIONS
use ANSWERS_AND_QUESTIONS

create table PLAYER
(id_account int identity(1,1)not null,
NickName varchar(18) primary key,
Nombres varchar(45)not null,
Apellidos varchar(45)not null,
Premio_Acumulado int not null)


select PLAYER.NickName,PLAYER.Nombres, PLAYER.Apellidos, ACCUMULATED_PRIZE.PuntosAcumulados
from PLAYER
inner join ACCUMULATED_PRIZE
on PLAYER.NickName = ACCUMULATED_PRIZE.NickName
order by ACCUMULATED_PRIZE.PuntosAcumulados desc

