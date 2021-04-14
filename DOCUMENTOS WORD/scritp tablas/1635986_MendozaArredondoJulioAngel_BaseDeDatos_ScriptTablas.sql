--create database BD_PROYECTO_JM

--use BD_PROYECTO_JM


create table Administrador(
id_admin int identity (0,1) primary key,
admin_nombre varchar (20) not null,
admin_pass   varbinary(15) not null,
);

create table Categoria(
id_catego int identity(0,1) primary key,
catego_descripcion varchar(20) not null,
Catego_id_admin int not null

constraint FK_CATEGO_idAdmin
foreign key (Catego_id_admin) references Administrador(id_admin)
);

create table Producto(
id_producto int identity (0,1) primary key,
prod_descipcion varchar (35) not null,
prod_stock int not null,
prod_precio float not null,
prod_Punto_RE int not null,
prod_Cantidad_RE int not null,
prod_Fecha_RE date default getdate(),
prod_Fecha_Alta date default getdate(),
prod_id_admin int not null,
prod_Catego int not null

constraint FK_Prod_id_admin
foreign key (prod_id_admin) references Administrador(id_admin),
constraint FK_Prod_Catego
foreign key (prod_Catego) references Categoria(id_catego)
);

create table Vendedor(
V_RFC			varchar(13) primary key not null,
V_nombre		varchar(30) not null,
V_AP			varchar(20) not null,
V_AM			varchar(20) not null,
V_CURP			varchar(20) not null,
V_Pass			varbinary(15) not null,
V_id_admin		int not null,
V_No_Nomina		varchar(15) not null UNIQUE

constraint FK_V_id_admin
foreign key (V_id_admin) references Administrador(id_admin)
);

create table Cliente(
C_RFC				varchar(13) primary key not null,
C_nombre			varchar(20) not null,
C_AP				varchar(15) not null,
C_AM				varchar(15) not null,
C_RFC_V				varchar(13) not null default 'MEAJ970706HNL',
C_Fecha_Nacimiento	DATE 

constraint FK_Cliente_C_RFC_V
foreign key (C_RFC_V) references Vendedor(V_RFC) on delete set default
);

-----------------NORMALIZACION TABLAS NORMALES

create table Cliente_Correo(
id_correo	int identity (0,1) not null,
C_email		varchar(50) not null,
C_C_RFC		varchar(13) not null

constraint FK_C_C_RFC
foreign key(C_C_RFC) references Cliente(C_RFC) ON DELETE CASCADE
);

create table Cliente_Telefono(
id_telefono		int identity(0,1) primary key,
T_telefono		varchar(10) not null,
T_RFC_C			varchar(13) not null

constraint FK_T_RFC_C
foreign key (T_RFC_C) references Cliente(C_RFC) ON DELETE CASCADE

);

create table Cliente_Domicilio(
id_domicilio		int identity(0,1) primary key,
D_direccion			varchar(30) not null,
D_Codigo_Postal		int not null,
D_RFC_C				varchar(13) not null

constraint FK_D_RFC_C
foreign key (D_RFC_C) references Cliente(C_RFC) ON DELETE CASCADE
);

-----------------NORMALIZACION TABLAS M-M
create table Forma_Pago(
id_pago			int identity(0,1) primary key,
FP_descripcion	varchar(20) not null,
);

create table Motivo(
id_motivo		int identity(0,1) primary key,
M_descripcion	varchar(25) not null
);

----------------RELACIONES M-M
create table Venta(
V_NoVenta varchar(13) primary key not null,
V_Fecha_Compra date default getdate(),
V_Cantidad_Articulos int,
V_Total float,
V_V_Comision float,
V_Caja int,
V_V_RFC varchar(13) not null default 'MEAJ970706HNL',
V_C_RFC varchar(13) not null default 'GIG800216XXXX',
V_Forma_Pago	int not null default 0,
V_IVA			int default 16
constraint FK_V_V_RFC
foreign key (V_V_RFC) references Vendedor(V_RFC) on delete set default,
constraint FK_V_C_RFC 
foreign key (V_C_RFC) references Cliente(C_RFC) on delete set default,
constraint FK_V_Forma_pago
foreign key (V_Forma_pago) references Forma_Pago(id_pago) on delete set default
);

create table Detalle_Venta(
id_DV int identity(0,1) not null primary key,
DV_id_prod int not null default 0,
DV_cantidad int not null,
DV_precio float not null,
DV_SubTotal float,
DV_NoVenta varchar(13) not null

constraint FK_DV_NoVenta
foreign key (DV_NoVenta) references Venta(V_NoVenta) ON DELETE CASCADE,
constraint FK_DV_id_prod 
foreign key (DV_id_prod) references Producto(id_producto) on delete set default
);

create table Devolucion(
id_devolucion int identity (0,1) primary key,
D_id_venta		varchar(13) not null,
D_Fecha			date default getdate(),
D_id_cliente	varchar(13) not null default 'GIG800216XXXX'

constraint FK_D_id_venta
foreign key (D_id_venta) references Venta(V_NoVenta)on delete cascade,

constraint FK_D_id_cliente
foreign key (D_id_cliente) references Cliente(C_RFC) on delete set default
);

create table Detalle_Devolucion(
DD_id int identity (0,1) primary key,
DD_id_devolucion int not null,
DD_id_prod int not null default 0,
DD_cantidad int not null,
DD_motivo int not null,

constraint FK_DD_id_devolucion
foreign key (DD_id_devolucion) references Devolucion(id_devolucion) on delete cascade,
constraint FK_DD_motivo
foreign key (DD_motivo) references Motivo(id_motivo),
constraint FK_DD_id_prod
foreign key (DD_id_prod) references Producto(id_producto) on delete set default
);

----EXTRA
create table Producto_Eliminado(
id_PE					int identity (0,1) primary key,
PE_nombre				varchar(35) not null,
PE_Categoria			int not null,
PE_Fecha_Eliminado		date default getdate(),
PE_Fecha_Creacion		date not null


constraint fk_PE_Categoria
foreign key (PE_Categoria) references Categoria(id_catego) on delete cascade
);

