USE [MataSanossBD]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCama]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ActualizarCama]
(
@IdCama bigint,
@fkPlanta bigint
)
As 
 Begin
		Update tCama Set fkPlanta=@fkPlanta
		Where IdCama=@IdCama
		End



GO
/****** Object:  StoredProcedure [dbo].[ActualizarCamaAPaciente]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ActualizarCamaAPaciente]
(
@IdPacienteCama bigint,
@fechaAsignacion varchar (50),
@fkCama bigint,
@fkHistoria bigint)
As 
 Begin
		Update tPacienteCama Set fechaAsignada=@fechaAsignacion,fkCama=@fkCama,fkHistoria=@fkHistoria
		Where IdPacienteCama=@IdPacienteCama
		End


GO
/****** Object:  StoredProcedure [dbo].[ActualizarMedico]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ActualizarMedico]
(
@IdMedico bigint,
@imagen image,
@nombre varchar (50),
@apellido varchar (50),
@especialidad varchar (50),
@nombreUsuario varchar (50),
@contrasena varchar (50),
@fkPlanta bigint
)
As 
 Begin
		Update tMedico Set imagen=@imagen,nombre=@nombre,apellido=@apellido,especialidad=@especialidad,nombreUsuario=@nombreUsuario,contrasena=@contrasena,fkPlanta=@fkPlanta
		Where contrasena=@contrasena
		End



GO
/****** Object:  StoredProcedure [dbo].[ActualizarPaciente]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[ActualizarPaciente]
(
@IdNumeroSeguro bigint,
@dni varchar (50),
@nombre varchar (50),
@apellido varchar (50),
@fechaNacimiento varchar (50),
@estado varchar (50)
)
As 
 Begin
		Update tPaciente Set dni=@dni,nombre=@nombre,apellido=@apellido,fechaNacimiento=@fechaNacimiento,estado=@estado
		Where IdNumeroSeguro=@IdNumeroSeguro
		End

GO
/****** Object:  StoredProcedure [dbo].[ActualizarPlanta]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ActualizarPlanta]
(
@IdPlanta bigint,
@nombre varchar(50),
@numeroCamas int)
As 
 Begin
		Update tPlanta Set nombre=@nombre,numeroCamas=@numeroCamas
		Where IdPlanta=@IdPlanta
		End



GO
/****** Object:  StoredProcedure [dbo].[AgregarCama]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AgregarCama]
(
@fkPlanta bigint
)
As Begin
		Insert tCama Values(@fkPlanta)
		End



GO
/****** Object:  StoredProcedure [dbo].[AgregarCamaAPaciente]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AgregarCamaAPaciente]
(
@fechaAsignacion varchar (50),
@fkCama bigint,
@fkHistoria bigint)
As Begin
		Insert tPacienteCama Values(@fechaAsignacion,@fkCama,@fkHistoria)
		End


GO
/****** Object:  StoredProcedure [dbo].[AgregarHistorial]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[AgregarHistorial]
(
@FechaEntrada Varchar(50),
@FechaAlta Varchar(50),
@fkNumeroSeguro bigint)
As Begin
		Insert tHistoria Values(@FechaEntrada,@FechaAlta,@fkNumeroSeguro)
		End


GO
/****** Object:  StoredProcedure [dbo].[AgregarMedico]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AgregarMedico]
(
@imagen image,
@nombre varchar (50),
@apellido varchar (50),
@especialidad varchar (50),
@nombreUsuario varchar (50),
@contrasena varchar (50),
@fkPlanta bigint,
@Mensaje Varchar(50) Output
)
As Begin
If(Exists(Select * From tMedico Where nombreUsuario=@nombreUsuario))
		Set @Mensaje='El Nombre de Usuario: '+@nombreUsuario+' No está Disponible'+'Por Favor Elija Otro'
	Else Begin
		Insert tMedico Values(@imagen,@nombre,@apellido,@especialidad,@nombreUsuario,@contrasena,@fkPlanta)
		Set @Mensaje='Medico Registrado.'
		End
		End



GO
/****** Object:  StoredProcedure [dbo].[AgregarPaciente]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AgregarPaciente]
(
@dni varchar (50),
@nombre varchar (50),
@apellido varchar (50),
@fechaNacimiento varchar (50),
@estado varchar (50),
@Mensaje Varchar(50) Output
)
As Begin
If(Exists(Select * From tPaciente Where dni=@dni))
		Set @Mensaje='El Paciente Ya Esta Registrado.'
	Else Begin
		Insert tPaciente Values(@dni,@nombre,@apellido,@fechaNacimiento,@estado)
		Set @Mensaje='Paciente Registrado.'
		End
		End



GO
/****** Object:  StoredProcedure [dbo].[AgregarPlanta]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AgregarPlanta]
(
@nombre varchar(50),
@numeroCamas int,
@Mensaje Varchar(50) Output
)
As Begin
	If(Exists(Select * From tPlanta Where nombre=@nombre))
		Set @Mensaje='El Edificio Ya Esta Registrado.'
	Else Begin
		Insert tPlanta Values(@nombre,@numeroCamas)
		Set @Mensaje='Ingresado Correctamente.'
		End
	End


GO
/****** Object:  StoredProcedure [dbo].[AgregarVisita]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AgregarVisita]
(
@FechaVisita varchar (50),
@HoraVisita varchar (50),
@Diagnostico varchar (200),
@fkMedico bigint,
@fkPacienteCama bigint
)
As Begin
		Insert tVisitaMedica Values(@FechaVisita,@HoraVisita,@Diagnostico,@fkMedico,@fkPacienteCama)
		End



GO
/****** Object:  StoredProcedure [dbo].[BuscarCamas]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarCamas]
(
@fkPlanta bigint
)
As Begin
	Select * From tCama where fkPlanta=@fkPlanta
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarEnfermera]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[BuscarEnfermera]
@DUI varchar (50)
As Begin
	Select * From Enfermera Where DUI=@DUI
End

GO
/****** Object:  StoredProcedure [dbo].[BuscarHistorial]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarHistorial]
@dni varchar (50)
As Begin
	Select H.*, P.nombre,P.apellido,P.dni
	From tPaciente P Inner Join tHistoria 
	H On H.fkNumeroSeguro=P.IdNumeroSeguro where P.dni=@dni
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarHistorialPorFechaAlta]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarHistorialPorFechaAlta]
@FechaAlta varchar (50)
as
begin
select * from tHistoria where FechaAlta=@FechaAlta
end


GO
/****** Object:  StoredProcedure [dbo].[BuscarHistorialPorFechaEntrada]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarHistorialPorFechaEntrada]
@FechaEntrada varchar(50)
as
begin
select * from tHistoria where FechaEntrada=@FechaEntrada
end


GO
/****** Object:  StoredProcedure [dbo].[BuscarMedicoApellido]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarMedicoApellido]
(
@apellido varchar (50)
)
As Begin
	Select * From tMedico where apellido=@apellido
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarMedicoEspecialidad]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarMedicoEspecialidad]
(
@especialidad varchar (50)
)
As Begin
	Select * From tMedico where especialidad=@especialidad
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarPacientePordni]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarPacientePordni]
(
@dni varchar (50)
)
As Begin
	Select * From tPaciente where dni=@dni
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarPacientePorEstado]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarPacientePorEstado]
(
@estado varchar (50)
)
As Begin
	Select * From tPaciente where estado=@estado
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarPlanta]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarPlanta]
(
@nombre varchar (50)
)
As Begin
	Select * From tPlanta where nombre=@nombre
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarPorFechaAsignacion]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BuscarPorFechaAsignacion]
(
@fechaAsignacion varchar (50)
)
As Begin
	Select * From tPacienteCama where fechaAsignada=@fechaAsignacion
End



GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[BuscarUsuario]
@IdUsuario bigint
As Begin
	Select * From usuario Where IdUsuario=@IdUsuario
End


GO
/****** Object:  StoredProcedure [dbo].[BuscarVisita]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarVisita]
@fkPacienteCama varchar(50)
as
begin
select * from tVisitaMedica where fkPacienteCama=@fkPacienteCama
end


GO
/****** Object:  StoredProcedure [dbo].[BuscraCamaPacientePorFecha]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscraCamaPacientePorFecha]
@fechaAsignacion varchar (50)
as
begin
select * from tPacienteCama where fechaAsignada=@fechaAsignacion
end

GO
/****** Object:  StoredProcedure [dbo].[EliminarCama]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarCama]
@IdCama bigint
as
begin
delete tCama where IdCama=@Idcama
end


GO
/****** Object:  StoredProcedure [dbo].[EliminarCamaAPaciente]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[EliminarCamaAPaciente]
(
@IdPacienteCama bigint
)
As 
 Begin
		delete tPacienteCama
		Where IdPacienteCama=@IdPacienteCama
		End



GO
/****** Object:  StoredProcedure [dbo].[EliminarEnfermeras]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[EliminarEnfermeras]
(
@DUI Varchar(50)
)
As Begin
		delete Enfermera
		Where DUI=@DUI
		End


GO
/****** Object:  StoredProcedure [dbo].[EliminarMedico]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[EliminarMedico]
(
@IdMedico bigint
)
As 
 Begin
		delete tMedico Where IdMedico=@IdMedico
		End



GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[EliminarUsuario]
(
@IdUsuario bigint
)
As Begin
		delete usuario
		Where IdUsuario=@IdUsuario
		End

GO
/****** Object:  StoredProcedure [dbo].[EliminarVisita]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[EliminarVisita]
(
@fkPacienteCama bigint
)
As 
 Begin
		delete tVisitaMedica
		Where fkPacienteCama=@fkPacienteCama
		End



GO
/****** Object:  StoredProcedure [dbo].[IniciarSesion]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[IniciarSesion]
@usuario Varchar(50),
@contrasena Varchar(50)
As 
Begin
	Select usuario,contrasena From usuario Where Usuario=@Usuario And contrasena=@contrasena		
   End

GO
/****** Object:  StoredProcedure [dbo].[ModificarEnfermeras]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[ModificarEnfermeras]
(
@DUI Varchar(50),
@nombre Varchar(50),
@apellido Varchar(50)
)
As Begin
		Update Enfermera Set nombre=@nombre,apellido=@apellido 
		Where DUI=@DUI
		End

GO
/****** Object:  StoredProcedure [dbo].[ModificarHistorial]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ModificarHistorial]
(
@IdHistorial bigint,
@FechaEntrada Varchar(50),
@FechaAlta Varchar(50),
@fkNumeroSeguro bigint
)
As Begin
		Update tHistoria Set FechaEntrada=@FechaEntrada,FechaAlta=@FechaAlta,fkNumeroSeguro=@fkNumeroSeguro 
		Where IdHistoria=@IdHistorial
		End



GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[ModificarUsuario]
(
@usuario Varchar(50),
@contrasena Varchar(50),
@Mensaje Varchar(50) Out
)
As Begin
			If(Exists(Select * From usuario Where usuario=@Usuario))
				Set @Mensaje='El Usuario: '+@Usuario+' No está Disponible'+'Por Favor Elija Otro'
			Else Begin
		Update usuario Set usuario=@usuario,@contrasena=@contrasena 
		end
		end

GO
/****** Object:  StoredProcedure [dbo].[MostraPlantas]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MostraPlantas]
As Begin
	Select * From tPlanta
End



GO
/****** Object:  StoredProcedure [dbo].[MostrarCamas]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MostrarCamas]
As Begin
	Select * From tCama
End



GO
/****** Object:  StoredProcedure [dbo].[MostrarEnfermeras]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[MostrarEnfermeras]
As Begin
	Select * From Enfermera 
   End

GO
/****** Object:  StoredProcedure [dbo].[MostrarHistorial]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarHistorial]
as
begin
Select H.*, P.nombre,P.apellido,P.dni
	From tPaciente P Inner Join tHistoria 
	H On H.fkNumeroSeguro=P.IdNumeroSeguro
end



GO
/****** Object:  StoredProcedure [dbo].[MostrarMedico]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MostrarMedico]
As Begin
	Select * From tMedico
End



GO
/****** Object:  StoredProcedure [dbo].[MostrarPaciente]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MostrarPaciente]
As Begin
	Select * From tPaciente
End



GO
/****** Object:  StoredProcedure [dbo].[MostrarPacienteCama]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MostrarPacienteCama]
As Begin
	Select * From tPacienteCama
End



GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuarios]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[MostrarUsuarios]
As Begin
	Select * From usuario
End


GO
/****** Object:  StoredProcedure [dbo].[MostrarVisita]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MostrarVisita]
As Begin
	Select * From tVisitaMedica
End



GO
/****** Object:  StoredProcedure [dbo].[RegistrarUsuario]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[RegistrarUsuario]
@usuario Varchar(50),
@contrasena Varchar(50),
@FDUI Varchar(50),
@Mensaje Varchar(50) Out
As Begin
			If(Exists(Select * From usuario Where usuario=@Usuario))
				Set @Mensaje='El Usuario: '+@Usuario+' No está Disponible'+'Por Favor Elija Otro'
			Else Begin
				Insert usuario Values(@Usuario,@contrasena,@FDUI)
					Set @Mensaje='Usuario Registrado Correctamente.'
				 End
		 End
GO
/****** Object:  StoredProcedure [dbo].[ReguistraEnfermero]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[ReguistraEnfermero]
(
@DUI Varchar(50),
@nombre Varchar(50),
@apellido Varchar(50),
@Mensaje Varchar(50) Output
)
As Begin
	If(Exists(Select * From Enfermera Where DUI=@DUI))
		Set @Mensaje='Los Datos ya Existen.'
	Else Begin
		Insert Enfermera Values(@DUI,@nombre,@apellido)
		Set @Mensaje='Registrado/a Correctamente.'
		End
	End

GO
/****** Object:  StoredProcedure [dbo].[Validar]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Validar]
(
@nombreUsuario varchar(50),
@contrasena varchar (50)
)
as
begin
select nombreUsuario,contrasena from tMedico where nombreUsuario=@nombreUsuario and contrasena=@contrasena
end



GO
/****** Object:  Table [dbo].[Enfermera]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Enfermera](
	[DUI] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DUI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tCama]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCama](
	[IdCama] [bigint] IDENTITY(111,1) NOT NULL,
	[fkPlanta] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tHistoria]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tHistoria](
	[IdHistoria] [bigint] IDENTITY(111,1) NOT NULL,
	[FechaEntrada] [varchar](50) NOT NULL,
	[FechaAlta] [varchar](50) NULL,
	[fkNumeroSeguro] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHistoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tMedico]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tMedico](
	[IdMedico] [bigint] IDENTITY(111,1) NOT NULL,
	[Imagen] [image] NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[especialidad] [varchar](50) NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](50) NOT NULL,
	[fkPlanta] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPaciente]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPaciente](
	[IdNumeroSeguro] [bigint] IDENTITY(111,1) NOT NULL,
	[dni] [varchar](80) NULL,
	[nombre] [varchar](80) NOT NULL,
	[apellido] [varchar](80) NOT NULL,
	[fechaNacimiento] [varchar](50) NOT NULL,
	[estado] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNumeroSeguro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPacienteCama]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPacienteCama](
	[IdPacienteCama] [bigint] IDENTITY(111,1) NOT NULL,
	[fechaAsignada] [varchar](50) NOT NULL,
	[fkCama] [bigint] NOT NULL,
	[fkHistoria] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPacienteCama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPlanta]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPlanta](
	[IdPlanta] [bigint] IDENTITY(111,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[numeroCamas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPlanta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tVisitaMedica]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tVisitaMedica](
	[FechaVisita] [varchar](50) NOT NULL,
	[HoraVisita] [varchar](50) NOT NULL,
	[DiagnosticoEnfermedad] [varchar](200) NOT NULL,
	[fkMedico] [bigint] NOT NULL,
	[fkPacienteCama] [bigint] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 24/10/2017 11:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[IdUsuario] [bigint] IDENTITY(111,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](50) NOT NULL,
	[FDUI] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tCama]  WITH CHECK ADD  CONSTRAINT [FK_tCama_tPlanta] FOREIGN KEY([fkPlanta])
REFERENCES [dbo].[tPlanta] ([IdPlanta])
GO
ALTER TABLE [dbo].[tCama] CHECK CONSTRAINT [FK_tCama_tPlanta]
GO
ALTER TABLE [dbo].[tHistoria]  WITH CHECK ADD  CONSTRAINT [FK_tHistoria_tPaciente] FOREIGN KEY([fkNumeroSeguro])
REFERENCES [dbo].[tPaciente] ([IdNumeroSeguro])
GO
ALTER TABLE [dbo].[tHistoria] CHECK CONSTRAINT [FK_tHistoria_tPaciente]
GO
ALTER TABLE [dbo].[tMedico]  WITH CHECK ADD  CONSTRAINT [FK_tMedico_tPlanta] FOREIGN KEY([fkPlanta])
REFERENCES [dbo].[tPlanta] ([IdPlanta])
GO
ALTER TABLE [dbo].[tMedico] CHECK CONSTRAINT [FK_tMedico_tPlanta]
GO
ALTER TABLE [dbo].[tPacienteCama]  WITH CHECK ADD  CONSTRAINT [FK_tPacienteCama_tCama] FOREIGN KEY([fkCama])
REFERENCES [dbo].[tCama] ([IdCama])
GO
ALTER TABLE [dbo].[tPacienteCama] CHECK CONSTRAINT [FK_tPacienteCama_tCama]
GO
ALTER TABLE [dbo].[tPacienteCama]  WITH CHECK ADD  CONSTRAINT [FK_tPacienteCama_tHistoria] FOREIGN KEY([fkHistoria])
REFERENCES [dbo].[tHistoria] ([IdHistoria])
GO
ALTER TABLE [dbo].[tPacienteCama] CHECK CONSTRAINT [FK_tPacienteCama_tHistoria]
GO
ALTER TABLE [dbo].[tVisitaMedica]  WITH CHECK ADD  CONSTRAINT [FK_tVisitaMedica_tMedico] FOREIGN KEY([fkMedico])
REFERENCES [dbo].[tMedico] ([IdMedico])
GO
ALTER TABLE [dbo].[tVisitaMedica] CHECK CONSTRAINT [FK_tVisitaMedica_tMedico]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_Enfermera] FOREIGN KEY([FDUI])
REFERENCES [dbo].[Enfermera] ([DUI])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_Enfermera]
GO
