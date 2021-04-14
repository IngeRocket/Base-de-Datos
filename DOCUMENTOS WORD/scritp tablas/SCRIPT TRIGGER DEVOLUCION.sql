
use Devol

create table Producto(
id_producto int identity (0,1) primary key,
prod_descipcion varchar (35) not null,
prod_stock int not null,
prod_precio float not null,
prod_Punto_RE int not null,
prod_Cantidad_RE int not null,
prod_Fecha_RE date default getdate(),
prod_Fecha_Alta date default getdate(),
prod_Catego varchar(15) not null

);


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

);

create table Detalle_Devolucion(
DD_id int identity (0,1) primary key,
DD_id_devolucion int not null,
DD_id_prod int not null default 0,
DD_cantidad int not null,
DD_motivo int not null,

constraint FK_DD_id_devolucion
foreign key (DD_id_devolucion) references Devolucion(id_devolucion) on delete cascade,

constraint FK_DD_id_prod
foreign key (DD_id_prod) references Producto(id_producto) on delete set default
);

--productos

insert into Producto(prod_descipcion,prod_precio, prod_stock, prod_Punto_RE, prod_Cantidad_RE,prod_Catego) values('Jabon',50,10,20,50,'Higiene')
insert into Producto(prod_descipcion,prod_precio, prod_stock, prod_Punto_RE, prod_Cantidad_RE,prod_Catego) values('Shampoo',48.50,10,20,50,'Higiene')
insert into Producto(prod_descipcion,prod_precio, prod_stock, prod_Punto_RE, prod_Cantidad_RE,prod_Catego) values('Desodorante',65,10,20,50,'Higiene')
insert into Producto(prod_descipcion,prod_precio, prod_stock, prod_Punto_RE, prod_Cantidad_RE,prod_Catego) values('Antitranspirante',60,10,20,50,'Higiene')
insert into Producto(prod_descipcion,prod_precio, prod_stock, prod_Punto_RE, prod_Cantidad_RE,prod_Catego) values('Cepillo',20,10,20,50,'Higiene')
select * from Producto


declare @Folio1 varchar(13)
declare @Folio2 varchar(13)
declare @Folio3 varchar(13)

set @Folio1 = '2505150918042'
set @Folio2 = '2606151020123'
set @Folio3 = '0107151220001'
/*
insert into Venta(V_NoVenta,V_C_RFC,V_V_RFC,V_Caja,V_Cantidad_Articulos,V_Forma_Pago,V_IVA,V_Total)
values (@Folio1,'SEVE970801HNL','MEAJ970706HNL',2,10,1,16,500)

insert into Venta(V_NoVenta,V_C_RFC,V_V_RFC,V_Caja,V_Cantidad_Articulos,V_Forma_Pago,V_IVA,V_Total)
values (@Folio2,'LUSD99001HNL','MEAJ970706HNL',3,8,1,16,400)

insert into Venta(V_NoVenta,V_C_RFC,V_V_RFC,V_Caja,V_Cantidad_Articulos,V_Forma_Pago,V_IVA,V_Total)
values (@Folio3,'MEAJ970706HNL','SEVE970801HNL',1,6,1,16,300)
select * from Venta
*/

insert into Detalle_Venta(DV_NoVenta,DV_id_prod,DV_precio,DV_cantidad,DV_SubTotal)
values(@Folio1,0,50,2,100)
insert into Detalle_Venta(DV_NoVenta,DV_id_prod,DV_precio,DV_cantidad,DV_SubTotal)
values(@Folio1,3,50,4,200)
insert into Detalle_Venta(DV_NoVenta,DV_id_prod,DV_precio,DV_cantidad,DV_SubTotal)
values(@Folio1,4,50,2,100)
insert into Detalle_Venta(DV_NoVenta,DV_id_prod,DV_precio,DV_cantidad,DV_SubTotal)
values(@Folio1,2,50,2,100)


insert into Detalle_Venta(DV_NoVenta,DV_id_prod,DV_precio,DV_cantidad,DV_SubTotal)
values(@Folio2,3,50,4,200)
insert into Detalle_Venta(DV_NoVenta,DV_id_prod,DV_precio,DV_cantidad,DV_SubTotal)
values(@Folio2,1,50,4,200)


insert into Detalle_Venta(DV_NoVenta,DV_id_prod,DV_precio,DV_cantidad,DV_SubTotal)
values(@Folio3,0,50,6,300)

select * from Detalle_Venta

update venta
set V_V_Comision = V_Total * 0.03


select * from venta
go


INSERT INTO Devolucion (D_id_venta,D_id_cliente) VALUES ('2505150918042','MEAJ970706HNL')
SELECT * FROM VENTA WHERE V_NoVenta = '2505150918042'
SELECT * FROM Detalle_Venta

INSERT INTO Detalle_Devolucion(DD_id_devolucion,DD_id_prod,DD_cantidad,DD_motivo) VALUES (2,0,1,0)
INSERT INTO Detalle_Devolucion(DD_id_devolucion,DD_id_prod,DD_cantidad,DD_motivo) VALUES (2,3,1,1)
INSERT INTO Detalle_Devolucion(DD_id_devolucion,DD_id_prod,DD_cantidad,DD_motivo) VALUES (2,4,1,1)
INSERT INTO Detalle_Devolucion(DD_id_devolucion,DD_id_prod,DD_cantidad,DD_motivo) VALUES (2,2,1,0)
SELECT * FROM Detalle_Devolucion
SELECT * FROM Producto
SELECT * FROM VENTA
GO
--DROP TRIGGER TRG_DEVOLUCION
create trigger trg_Devolucion on Detalle_Devolucion
instead of insert
as
begin


declare @cantidad int				--mismas unidades regresadas (Siempre es 1)
declare @motivo int					--0,1,2,3,4
declare @producto int				--obtener
declare @precio float				--obtener de la venta folio
declare @Venta_Folio varchar(13)	--folio		

declare @id int						-- id de devolucion

declare @Cantidad_Origen int		--obtener el numero de piezas de la Venta


select @id= DD_id_devolucion from inserted
select @producto = DD_id_prod from inserted
select @cantidad = DD_Cantidad from inserted
select @motivo = DD_motivo from inserted
select @Venta_Folio = D_id_venta from Devolucion where id_devolucion = @id

--opciones de devolucion (Motivos) (0- no fue de agrado al cliente (No esta roto), 3- producto equivocado (el compro algo que no queria, No esta roto))
if @motivo=0 Or @motivo=3
begin
--regresar a stock producto
update Producto
set prod_stock=prod_stock + 1
where id_producto = @producto
end

----GENERAL (TODOS LOS ARTICULOS)

--descontar unidad de la informacion de venta
update Venta
set V_Cantidad_Articulos = V_Cantidad_Articulos - 1
where V_NoVenta=@Venta_Folio

--descontar unidad del detalle de venta
--descontar precio del producto al subtotal (cuando hay mas de un producto o 1 en Cantidad)
update Detalle_Venta
set DV_cantidad = DV_cantidad - 1,
DV_SubTotal = DV_SubTotal - DV_precio
where DV_NoVenta = @Venta_Folio and DV_id_prod = @producto


--obtener precio del producto para descontar (aun si ya esta descontinuado)
select @precio = DV_precio from Detalle_venta where DV_id_prod = @producto and DV_NoVenta = @Venta_Folio

set @precio = @precio * 1.16							--obtener el precio del producto con iva para descontar del gantotal (Total en Venta)
declare @Descontar_comision decimal(10,2)				--descontar devolucion de la venta del vendedor
select @Descontar_comision = @precio * 0.03

update venta
set V_Total=V_Total - @precio,
V_V_Comision=V_V_COMISION - @Descontar_comision
where V_NoVenta = @Venta_Folio

--verificar que en la lista no queden productos con 0 cantidades
declare @prod_cantidad int
select @prod_cantidad = DV_cantidad from detalle_venta where DV_id_prod = @producto

if @prod_cantidad = 0 --ya no hay productos comprados en este por la devolucion
delete from Detalle_Venta where DV_NoVenta = @Venta_Folio and DV_id_prod = @producto --asegurarme de borrar el registro del producto que tenga la cantidad vacia

--ANTERIOR ES EN BASE A DEVOLUCION
--MINIMIZAR DATOS DE DEVOLUCION

declare @producto2 int
--seguridad en contra de producto 0
set @producto2 = -1
--si se encunetra un producto con las siguientes caracteriticas, ya se ha hecho una devolucion de este tipo
select @producto2 = DD_id_prod from Detalle_Devolucion where DD_id_prod = @producto and DD_id_devolucion = @id and DD_motivo = @motivo


if @producto2 =-1
begin
--no existe un producto con misma descripcion a insertar
insert into Detalle_Devolucion (DD_id_devolucion,DD_id_prod,DD_cantidad,DD_motivo) values (@id,@producto,1,@motivo)
end
else
begin
-- agregar cantidad a producto ya existente en devolucion
update Detalle_Devolucion
set DD_cantidad = DD_cantidad+1
where DD_id_devolucion = @id and DD_id_prod = @producto and DD_motivo = @motivo
end

end

GO



select * from Detalle_Devolucion
select * from Devolucion

UPDATE VENTA
SET v_v_COMISION = v_TOTAL * 0.03
WHERE V_NOvENTA = '0107151220001'