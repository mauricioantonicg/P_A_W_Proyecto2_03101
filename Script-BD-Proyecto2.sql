
create database BD_Proyecto2_PAW_03101
go 

use BD_Proyecto2_PAW_03101
go

create table marcaAvion(
idMarcaAvion int primary key identity,
nombreMarcaAvion varchar(45) not null
) 
go

create table modeloAvion(
idModeloAvion int primary key identity,
nombreModeloAvion varchar(45) not null,
anchoAvion decimal(5,2) not null,
altoAvion decimal(5,2) not null,
largoAvion decimal(5,2) not null,
distanciaCombustibleAvion decimal(5,2) not null
) 
go

create table tipoAvion(
idTipoAvion int primary key identity,
idMarcaAvio int references marcaAvion(idMarcaAvion) not null,
idModeloAvio int references modeloAvion(idModeloAvion) not null,
cantidadAviones int not null
) 
go

create table avion(
numAvion int identity,
serieAvion varchar(45) primary key not null,
nombreFantasiaAvion varchar(45) not null,
idTipoAvio int references tipoAvion(idTipoAvion) not null,
estadoAvionRetOActivo bit not null
) 
go

create table registroAvion(
idOrdenRegistroAvion int primary key identity,
serieAvio varchar(45) references avion(serieAvion) not null,
nombreTecnicoRegistraAvion varchar(100) not null,
fechaRegistroAvion date not null,
horaRegistroAvion time not null,
consecutivoOrdenRegistroAvion int not null
) 
go

create table retiroAvion(
idOrdenRetiroAvion int primary key identity,
serieAvionn varchar(45) references avion(serieAvion) not null,
nombreTecnicoRetiraAvion varchar(100) not null,
fechaRetiroAvion date not null,
horaRetiroAvion time not null,
detalleRetiroAvion varchar (200) not null,
consecutivoOrdenRetiroAvion int not null
) 
go

create table despegueAvionRegistro(
CCCCCDespegueAvion int primary key identity,
AAAADespegueAvionn date not null,
DEDespegueAvion varchar(5) not null,
fechaDespegueAvion date not null,
horaDespegueAvion time not null,
nombreTecnicoEncargDespegue varchar (100) not null,
nombreMision varchar (100) not null,
consecutivoCCCCCDespAvion int not null
) 
go

create table listaAvionDespAterrizaje(
CCCCCDespAvion int references despegueAvionRegistro(CCCCCDespegueAvion) not null,
serieAvi varchar (45) references avion(serieAvion) not null,
nombrePilotoAvion varchar(100) not null,
nombreEncargadoAvion varchar(100) not null,
estadoAvionDespOAterrizo bit not null,
detallesDespegueAvion varchar(200),
fechaAterrizajeAvion date,
horaAterrizajeAvion time,
avionPerdidoEnMision bit,
avionRequiereRescate bit,
avionPerdidasHumanas bit,
detallesAterrizajeAvion varchar (200) not null
) 
go




create proc sp_AgregarEncuesta(
@nombrePersona varchar,
@apellido1 varchar,
@idPais int,
@idRolPersona int,
@idLenguajeProgPrimario int,
@idLenguajeProgSecundario int
)
as
begin
   insert into persona(nombrePersona, apellido1, idPais, idRolPersona, idLenguajeProgPrimario, idLenguajeProgSecundario) 
        values (@nombrePersona, @apellido1, @idPais, @idRolPersona, @idLenguajeProgPrimario, @idLenguajeProgSecundario)
end

create proc sp_PuntuarLenguaje(
@idLenguajeProgram int,
@puntuacionLenguaje decimal (7,2)
)
as
begin
   UPDATE lenguajeProgramacion SET puntuacionLenguaje = @puntuacionLenguaje WHERE idLenguajeProgram = @idLenguajeProgram
end


select * from lenguajeProgramacion order by puntuacionLenguaje desc

select * from persona



