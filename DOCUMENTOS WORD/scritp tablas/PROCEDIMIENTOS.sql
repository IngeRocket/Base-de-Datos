use BD_PROYECTO_JM
GO

--Drop procedure SP_LOGIN
create procedure SP_LOGIN(@Usu varchar(13),@Pass varchar(15),@opcion int)
as
begin

--regresa nombre vendedor / administrador

declare @contra varbinary(15)
set @contra = convert(varbinary,@Pass)

if @opcion=1
select CONCAT(v_nombre,' ',V_AP,' ',V_AM) as Nombre, V_CURP, V_No_Nomina from Vendedor where V_RFC=@Usu and V_Pass=@contra
else
select admin_nombre from Administrador where admin_nombre=@Usu and admin_pass=@contra

end

GO
--CREADO
create procedure SP_CATEGORIAS
as
begin 
select catego_descripcion as Categoria from Categoria
end

GO
--CREADO
--drop procedure SP_ADD_DEL_PRODUCTO
create procedure SP_ADD_DEL_PRODUCTO( @nombre varchar(35), @Categoria varchar(20), @Cantidad_Stock int, @CANTIDAD_RE int, @Punto_RE int, @precio float, @opcion int, @N_Orig varchar(35), @C_Orig varchar(20))
as
begin
--1 añadir
--2 borrar
--3 update
declare @ID_CATEGORIA int
declare @ID_PRODUCTO int 

set nocount on
select @ID_CATEGORIA = id_catego from Categoria where catego_descripcion = @Categoria --id de caegoria segun el nombre
select @ID_PRODUCTO = id_producto from Producto where prod_descipcion = @nombre and prod_Catego = @ID_CATEGORIA -- id del producto segun la categoria y nombre del producto
set nocount off

if @opcion = 1 --añadir producto a Categoria
begin
insert into Producto (prod_descipcion,prod_stock, prod_precio, prod_Punto_RE, prod_Cantidad_RE, prod_id_admin, prod_Catego)
values
(@nombre, @Cantidad_Stock, @precio, @Punto_RE, @CANTIDAD_RE,0,@ID_CATEGORIA)
end

if @opcion=2 --eliminar producto
begin
delete from Producto where prod_Catego = @ID_CATEGORIA and prod_descipcion = @nombre 
end

if @opcion=3 --editar valores de producto
begin

declare @Id_Update		int 
declare @Id_C_Update	int
select @Id_C_Update = id_catego from Categoria where catego_descripcion = @C_Orig
select @Id_Update = id_producto from Producto where prod_descipcion = @N_Orig and prod_Catego = @Id_C_Update --busqueda de registro segun su nombre y categoria

UPDATE Producto
set prod_descipcion		=	isnull(@nombre,prod_descipcion),
	prod_stock			=	isnull(@Cantidad_Stock,prod_stock),
	prod_precio			=	isnull(@precio,prod_precio),
	prod_Punto_RE		=	isnull(@Punto_RE,prod_Punto_RE),
	prod_Cantidad_RE	=	isnull(@CANTIDAD_RE,prod_Cantidad_RE),
	prod_Catego			=	isnull(@ID_CATEGORIA,prod_Catego)
where id_producto = @Id_Update																				--Referencia de la llave encontrada
end



end
GO

--Creado

--drop procedure SP_ADD_DEL_VENDEDOR
create procedure SP_ADD_DEL_VENDEDOR( @V_RFC varchar(13), @nombre varchar(30), @V_AP varchar(20), @V_AM varchar(20),@contra varchar(15),@CURP varchar(20), @No_Nomina varchar(15) ,@opcion int)
AS
BEGIN
set nocount on
declare @pass varbinary(15)
select	@pass= convert(VARBINARY,@contra)
set nocount off

if @opcion=1 --agregar vendedor
begin
insert into Vendedor(V_RFC,V_nombre,V_AP,V_AM,V_CURP,V_Pass,V_id_admin,V_No_Nomina)
values
(@V_RFC, @nombre, @V_AP, @V_AM, @CURP, @pass,0,@No_Nomina)
end

if @opcion=2
begin
delete from Vendedor where V_RFC = @V_RFC and V_RFC <> 'MEAJ970706HNL'
end

if @opcion=3
begin
update Vendedor
set V_nombre	= isnull(@nombre,V_nombre),
	V_AP		= isnull(@V_AP,V_AP), 
	V_AM		= isnull(@V_AM,V_AM), 
	V_Pass		= isnull(@pass,V_Pass), 
	V_No_Nomina = isnull(@No_Nomina,V_No_Nomina),
	V_CURP		= isnull(@CURP,V_CURP)
where V_RFC = @V_RFC

end

END

GO
--CREADO
--Drop procedure SP_ADD_DEL_CLIENTE

create procedure SP_ADD_DEL_CLIENTE (@RFC_V varchar (13), @nombre varchar(20), @C_AP varchar(15), @C_AM varchar(15) ,@RFC_C varchar(13), @opcion int, @telefono varchar(10), @correo varchar(50), @domicilio varchar(30), @CP int)
as
begin
if @opcion=1 --agregar cliente
begin
declare @Cumple date
select @Cumple = dbo.FN_Cumple(@RFC_C)
insert into Cliente(C_RFC,C_nombre,C_AP,C_AM, C_RFC_V, C_Fecha_Nacimiento)
values
(@RFC_C, @nombre, @C_AP, @C_AM, @RFC_V, @Cumple)

insert into Cliente_Correo(C_email,C_C_RFC)values(@correo,@RFC_C)
insert into Cliente_Domicilio(D_direccion,D_Codigo_Postal,D_RFC_C)values(@domicilio,@CP,@RFC_C)
insert into Cliente_Telefono(T_telefono,T_RFC_C)values(@telefono,@RFC_C)

end

if @opcion=2 --borrar cliente
begin 
delete from Cliente where C_RFC = @RFC_C AND C_RFC <> 'GIG800216XXXX'
end

if @opcion=3 --update
begin
update Cliente
set		C_nombre	= isnull(@nombre,C_nombre),
		C_AP		= isnull(@C_AP,C_AP),
		C_AM		= isnull(@C_AM,C_AM)	
		where C_RFC = @RFC_C and C_RFC <> 'GIG800216XXXX'

		Update Cliente_Correo
		set C_email = isnull(@correo, C_email)
		where C_C_RFC = @RFC_C

		update Cliente_Telefono
		set T_telefono = isnull(@telefono,T_telefono)
		where T_RFC_C = @RFC_C

		update Cliente_Domicilio
		set D_direccion = isnull(@domicilio, D_direccion),
		D_Codigo_Postal = isnull(@cp,D_Codigo_Postal)
		where D_RFC_C = @RFC_C

end

end
GO
--CREADO PROCEDIMINETO FOLIO VENTA


--CREADO
create procedure SP_FORMA_PAGO
as
begin
select FP_descripcion as Forma from Forma_Pago
where FP_descripcion <> 'Descontinuado'
end

GO
--vista Elementos de Productos
create view V_Producto as
select P.prod_descipcion Producto, p.prod_stock Stock, p.prod_precio Precio, C.catego_descripcion Categoria, p.prod_Punto_RE [Punto Reorden], p.prod_Cantidad_RE [Cantidad Reorden], p.prod_Fecha_RE [Fecha Reorden], p.prod_Fecha_Alta [Fecha Alta] from Producto as P
join Categoria as C
on C.id_catego = P.prod_Catego
where p.prod_descipcion <> 'Descontinuado'
GO

create procedure SP_Productos_Descontinuados
as
begin
select PE.PE_nombre [Nombre Producto], C.catego_descripcion [Categoria], PE.PE_Fecha_Creacion [Fecha de Creacion], PE.PE_Fecha_Eliminado [Fecha de Eliminacion] from Producto_Eliminado as PE
join Categoria as C
ON PE.PE_Categoria = c.id_catego
end

go
--drop trigger trg_BorradoProd
create trigger trg_BorradoProd on Producto after delete
as
begin

declare @nombre varchar(35)
declare @Fecha_Creacion date
declare @Categoria int

select @nombre			= prod_descipcion from deleted
select @Fecha_Creacion	= prod_Fecha_Alta from deleted
select @Categoria		= prod_Catego from deleted

insert into Producto_Eliminado(PE_nombre,PE_Categoria,PE_Fecha_Creacion) values (@nombre,@Categoria,@Fecha_Creacion)

end
GO

--CREADO FUNCION FECHA NACIMIENTO, FALTA MODIFICAR SP_ADD_CLIENTE
-- drop function FN_Cumple
create function FN_Cumple(@RFC varchar(13))
RETURNS date
as 
begin
declare @Dato varchar(13)

set @Dato = substring(@RFC,5,6)
declare @Fecha date
Set @Fecha=convert(date,@Dato)
		 return @Fecha
end


GO
--CREADO
--drop function dbo.FN_FolioVenta
create function FN_FolioVenta(@Caja int,@opcion int,@FechaP varchar(13))
RETURNS varchar(13)
as 
begin
declare @Dato varchar(13)

if @opcion = 0
	begin
						--fecha de sistema
						set @Dato = replace(FORMAT(GETDATE(),'dd/MM/yy/HH/mm/ss'),'/','')+CONVERT(VARCHAR,@Caja)
	end
else
	begin
						--fecha personalizada, solo obtener hora				
						set @FechaP=(convert(varchar,FORMAT(convert(date,@FechaP),'dd/MM/yyyy')))		--llega con formato yyyy-mm-dd	 de sistema				
						set @FechaP = replace (@FechaP,'/','')
						set @FechaP = SUBSTRING(@FechaP,1,2) + SUBSTRING(@FechaP,3,2)+ SUBSTRING(@FechaP,7,2)	
						set @Dato= @FechaP + replace(FORMAT(GETDATE(),'HH/mm/ss'),'/','')+CONVERT(VARCHAR,@Caja)
	end
		 return @Dato
end

go
--DROP FUNCTION FN_COMISION
GO
CREATE function FN_COMISION(@Total float, @porcentaje int)
returns float
as
begin
declare @Final float

set @Final = ((@Total * @porcentaje)/100)

return convert(decimal(10, 2), @Final);
end

go

--VALIDAR RFC
--CREADO, PROPOSITO SABER SI EXISTE EL CLIENTE/VENDEDOR O SI ESTA OCUPADO EL RFC O NOMINA
--drop procedure SP_VALIDAR_RFC
create procedure SP_VALIDAR_RFC (@RFC varchar(13),@opcion int)
as
begin

if @opcion=1
select C_RFC from Cliente where C_RFC = @RFC



end

GO

create view V_Vendedor 
as
select V.V_nombre Nombre, V.V_AP AP, V.V_AM AM, V.V_CURP CURP, CONVERT (varchar,V.V_Pass) Pass, V.V_No_Nomina Nomina, V_RFC RFC from Vendedor as V
where V.V_RFC <> 'MEAJ970706HNL'

GO
--visualizacion de daos de vendedor
--drop procedure SP_CONSULTA_VENDEDOR

create procedure SP_CONSULTA_VENDEDOR (@RFC varchar(13),@nomina varchar(15) ,@opcion int)
as
begin 
if @opcion = 1 --consulta para ventanas edit
select Nombre, AP, AM, CURP, Pass, Nomina, RFC from V_Vendedor where RFC = @RFC

if @opcion=2 --consulta de vendedor especifico MOSTRAR DATOS ANTES DE BORRAR EN VENTANA
select Nombre, AP, AM, CURP, Nomina, RFC from V_Vendedor where RFC = @RFC

if @opcion=3 --consultar todos mis vendedores
select Nombre, AP, AM, CURP, Nomina, RFC from V_Vendedor
Order by Nombre, AP, AM

if @opcion=4				--didponibilidad de RFC
begin
if @RFC = 'MEAJ970706HNL'
Select @RFC
else
select RFC from V_Vendedor where RFC=@RFC
end


if @opcion=5				--disponibilidad de nomina
begin
if @nomina = '123456789'
select @nomina
else
select Nomina from V_Vendedor where Nomina = @nomina

end

end
GO
--exec SP_CONSULTA_VENDEDOR @RFC = 'asdc123456', @opcion = 2

--GO
--CREADO
--drop procedure SP_CONSULTA_PRODUCTO

create procedure SP_CONSULTA_PRODUCTO (@nombre varchar(35), @categoria varchar(20), @opcion int) as
begin
declare @id_categoria  int 
declare @id_producto  int
	set nocount on
select @id_categoria =  id_catego from categoria where catego_descripcion = @categoria
select @id_producto = id_producto from producto where prod_Catego = @id_categoria and prod_descipcion = @nombre 
	set nocount off

	if @opcion = 1 --consultar un producto
	begin
	select Producto, Stock, Precio, Categoria,[Punto Reorden],[Cantidad Reorden],[Fecha Reorden],[Fecha Alta]  from V_Producto
	where
	Producto = @nombre and Categoria = @categoria
	end

	if @opcion = 2	--consultar todos los productos de una categoria en especifico
	begin
	select Producto, Stock, precio, categoria,[Punto Reorden],[Cantidad Reorden],[Fecha Reorden],[Fecha Alta]  from V_Producto
	where
	Categoria = @categoria
	order by Producto
	end

	if @opcion = 3	--consultar todos los productos de todas las categorias
	begin
		select P.Producto, P.Stock, P.Precio, P.Categoria,P.[Punto Reorden],P.[Cantidad Reorden],P.[Fecha Reorden],P.[Fecha Alta]  from V_Producto as P
	order by P.Categoria,P.Producto
	end

	--PARA VENTAS
		if @opcion = 4	--consultar todos los productos de una de las categorias
	begin
		select P.Producto, P.Precio, P.Stock  from V_Producto as P
		where P.Categoria = @categoria
	order by P.Producto, P.Precio
	
	end

		if @opcion = 5	--consultar todos los productos de todas las categorias
	begin
		select P.Producto, P.Precio  from V_Producto as P
	order by P.Categoria,P.Producto,P.Precio
	end
end

GO
--creado trigger agregar/modificar stock en producto
create trigger trg_Producto_Reorden on Producto
after insert, update
as
begin
declare @id int
declare @stock int
declare @CA_RE int
declare @P_RE int

select @id = id_producto from inserted
select @stock = prod_stock from inserted
select @P_RE = prod_Punto_RE from inserted
select @CA_RE = prod_Cantidad_RE from inserted

if @stock <= @P_RE
begin
update Producto
set prod_stock = prod_stock + @CA_RE,
prod_Fecha_RE= getDate()
where id_producto = @id and @id <> 0
end

end
GO
/*
select * from Producto
select * from V_Producto
select * from Venta

GO
*/
--procedimiento detalle venta
--DROP  trigger trg_Prod_Venta_C

create trigger trg_Prod_Venta_C on Detalle_Venta 
instead of insert
as
begin

declare @id int
declare @NumeroCompra varchar(13)


declare @id_producto int
declare @id_producto2 int							--clave de producto a vaciar
declare @precio float								--precio del producto original

select @precio = DV_precio from inserted
select @id_producto = DV_id_prod from inserted		--clave del producto
select @NumeroCompra = DV_NoVenta from inserted		--clave de la compra

select @id_producto2 = DV_id_prod from Detalle_Venta where DV_NoVenta = @NumeroCompra and DV_id_prod = @id_producto        --la clave vacia de producto = clade de producto donde se encuentre el mismo folio de venta y el producto sea el mismo


if @id_producto2 = @id_producto
	begin
--si ya existe el producto
		update Detalle_Venta
		set DV_cantidad = DV_cantidad + 1,
		DV_SubTotal=DV_SubTotal+DV_precio
		where DV_NoVenta = @NumeroCompra and DV_id_prod = @id_producto  
		end

		else
			begin
		insert into Detalle_Venta(DV_id_prod, DV_cantidad, DV_precio, DV_SubTotal, DV_NoVenta)values(@id_producto,1,@precio,@precio,@NumeroCompra)
			end
			--para cada producto
			update Producto
		set prod_stock = prod_stock-1
		where id_producto = @id_producto and id_producto <> 0
end

GO
/*
alter table Detalle_Venta add 
id_DV int identity(0,1) primary key 

alter table Detalle_Venta drop column DV_NoVenta 
alter table VENTA drop column V_NoVenta 

GO
--insert into Venta(V_NoVenta, V_C_RFC, V_V_RFC, V_Caja, V_IVA, V_Forma_Pago,V_Total,V_V_Comision) values ('2201191414063','GIG800216XXXX','SEVE970801HNL',1,16,1,60,20)
go
*/
go

--use BD_PROYECTO_JM
--drop procedure SP_FOLIO
create procedure SP_FOLIO(@RFC_C varchar(13), @RFC_V varchar(13), @Fecha varchar(13), @Caja int, @Total float, @FormaPago varchar(20))
as 
begin 
declare @folio varchar(13)
declare @comision float
declare @id_forma int
declare @Total2 decimal (10,2)

set @Total2 = @Total

select @id_forma = id_pago from Forma_Pago where FP_descripcion = @FormaPago
set @comision = dbo.FN_COMISION(@total,3) 

if @RFC_C = ''
select @RFC_C = C_RFC from Cliente where C_RFC = 'GIG800216XXXX'
else
select @RFC_C = C_RFC from Cliente where C_RFC = @RFC_C

if @Fecha = ''
begin
set @folio= dbo.FN_FolioVenta(@Caja,0,@Fecha)
insert into dbo.Venta(V_NoVenta, V_Total, V_V_Comision, V_Caja, V_V_RFC, V_C_RFC, V_Forma_Pago, V_IVA,V_Cantidad_Articulos)
values
(@folio, @Total2, @Comision, @Caja, @RFC_V,@RFC_C, @id_Forma, 16,0)
end
else
begin
set @folio= dbo.FN_FolioVenta(@Caja,1,@Fecha)
insert into Venta(V_NoVenta, V_Fecha_Compra, V_Total, V_V_Comision, V_Caja, V_V_RFC, V_C_RFC, V_Forma_Pago, V_IVA,V_Cantidad_Articulos)
values
(@folio, @Fecha, @Total2, @Comision, @Caja, @RFC_V, @RFC_C, @id_Forma, 16,0)
end







select @folio			--Regresa Numero Venta

end
GO
--drop procedure SP_ENVIO_PRODUCTO
create procedure SP_ENVIO_PRODUCTO(@FolioVenta varchar(13),@producto varchar(35),@precio float)
as
begin
declare @id_Categoria int
declare @id_producto int
declare @precio_prod float

select @id_Categoria = prod_Catego from Producto where prod_descipcion = @producto	and prod_precio = @precio									--adquirir llave de categoria
select @id_producto = id_producto from Producto where prod_precio = @precio and prod_Catego=@id_Categoria	--adquirir id del producto que coincida con la categoria y nombre del producto

insert into Detalle_Venta(DV_id_prod, DV_cantidad, DV_precio, DV_SubTotal, DV_NoVenta) VALUES (@id_producto, 0, @precio, @precio,@FolioVenta)

update Venta
set V_Cantidad_Articulos = V_Cantidad_Articulos + 1
where V_NoVenta = @FolioVenta

end

GO
/*
select * from venta
select * from Detalle_Venta

update Venta
set V_Cantidad_Articulos = 4
where V_NoVenta = '2304190035152'

GO
*/
create procedure SP_CLIENTE_INFO (@RFC varchar(13)) as
begin

select C.C_nombre, C.C_AP, C.C_AM, C_D.D_direccion, C_D.D_Codigo_Postal, C_T.T_telefono, C_C.C_email, C_Fecha_Nacimiento from cliente as C
join Cliente_Telefono as C_T
on C_T.T_RFC_C = C.C_RFC
join Cliente_Correo as C_C
on C_C.C_C_RFC = C.C_RFC
join Cliente_Domicilio as C_D
on C_D.D_RFC_C = C.C_RFC
where C.C_RFC = @RFC

end
GO
select * from motivo
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

--opciones de devolucion (Motivos) (2- no fue de agrado al cliente (No esta roto), 3- producto equivocado (el compro algo que no queria, No esta roto))
if @motivo=2 Or @motivo=3
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
begin
delete from Detalle_Venta where DV_NoVenta = @Venta_Folio and DV_id_prod = @producto --asegurarme de borrar el registro del producto que tenga la cantidad vacia
update Venta
set V_V_Comision = 0.0,
V_Total = 0.0
where V_NoVenta = @Venta_Folio
end
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


-- drop procedure SP_VENTA_PRODUCTO
--CREEADO
create procedure SP_VENTA_PRODUCTO(@Folio varchar(13))
AS
BEGIN

select P.prod_descipcion [Articulo], DV.DV_cantidad [Cantidad], DV.DV_precio [Precio], convert (decimal (10,2),DV.DV_SubTotal) [SubTotal] from Detalle_Venta as DV
join producto as P
on DV.DV_id_prod = P.id_producto
WHERE
DV.DV_NoVenta = @Folio

END

go
--CREADO CONSULTA FOLIO Y NOMBRE
create procedure SP_CONSULTA_FOLIO (@Folio varchar(13)) as
begin

declare @Vendedor varchar (60)
declare @Cliente varchar (60)

select @Vendedor = V_V_RFC from Venta where V_NoVenta = @Folio --leer RFC
select @Cliente =  V_C_RFC from Venta where V_NoVenta = @Folio --leer RFC


if @Cliente = 'GIG800216XXXX'
set @CLIENTE = 'VENTA EN CAJA'
else
select @Cliente = C_nombre+' '+C_AP+' '+C_AM from cliente where C_RFC = @Cliente


if @Vendedor = 'MEAJ970706HNL'
set @Vendedor = 'GIGANTE'
else
select @Vendedor = V_nombre+' '+V_AP+' '+V_AM from Vendedor

select  V.V_Fecha_Compra [FECHA], V.V_Total [TOTAL], @Vendedor [VENDEDOR], @Cliente [CLIENTE] from venta as V
where V.V_NoVenta=@Folio
end

/*
go
select * from Cliente
select * from venta
*/
go
--DROP PROCEDURE SP_COMBO_MOTIVO
create procedure SP_COMBO_MOTIVO
AS 
BEGIN 
SELECT M_descripcion as MOTIVO FROM MOTIVO
END
select * from V_VENTAS

select * from Detalle_Venta where DV_NoVenta = '0605191202521'

select * from Devolucion
go
--CREADO
create procedure SP_FOLIO_DEVOLUCION (@Folio varchar(13))
as 
begin
declare @RFC_C varchar(13)
select @RFC_C = V_C_RFC from Venta where V_NoVenta = @Folio

insert into devolucion (D_id_venta,D_id_cliente) values (@Folio,@RFC_C)

--retorna folio de devolucion creado
select top(1) id_devolucion  from devolucion 
order by id_devolucion desc

end
go
--creado
create procedure SP_DEVOLUCION_PRODUCTO(@clave int, @producto varchar(35), @motivo varchar(25))
as
begin
declare @id_prod int
declare @id_motivo int

select @id_prod = id_producto from Producto where prod_descipcion = @producto
select @id_motivo =id_motivo from motivo where M_descripcion = @motivo

insert into Detalle_Devolucion (DD_id_devolucion,DD_id_prod,DD_motivo,DD_cantidad) values(@clave,@id_prod,@id_motivo,1)
end
go

/*
GO

select * from venta where V_V_RFC='SEVE970801HNL'
select * from Devolucion
select * from Detalle_Devolucion

go

select * from V_D_VENTA				--vista de detalle de venta
select * from V_Producto
select * from V_Vendedor			--otra cosa, seleccion de informacion para editar vendedores
select * from V_VENTAS				--vista de ventas


go
select * from V_D_VENTA
select * from V_VENTAS
*/
--order by [FECHA COMPRA],FOLIO
GO
--drop function dbo.FN_SUBTOTAL_COMPRAS
create function FN_SUBTOTAL_COMPRAS(@FOLIO VARCHAR(13))
RETURNS DECIMAL(10,2)
BEGIN
DECLARE @SUBTOTAL DECIMAL(10,2)
SELECT @SUBTOTAL = SUM(SUBTOTAL) FROM V_D_VENTA WHERE [FOLIO DE VENTA] = @folio

RETURN @SUBTOTAL
END

GO
--CREADO
create view V_DEVOL
AS
select D.id_devolucion [FOLIO], D.D_id_venta [FOLIO VENTA], D.D_Fecha [FECHA DE DEVOLUCION], (C.C_nombre + ' '+ C.C_AP + ' '+C.C_AM) [CLIENTE] from devolucion AS D
JOIN CLIENTE AS C
ON D.D_id_cliente = C.C_RFC

go

create procedure SP_V_FACTURAS (@opcion int, @fecha1 varchar(13), @fecha2 varchar(13))
as
begin
set @Fecha1=(convert(varchar,FORMAT(convert(date,@Fecha1),'yyyy/MM/dd')))				
set @Fecha2=(convert(varchar,FORMAT(convert(date,@Fecha2),'yyyy/MM/dd')))				
						
declare @f1 date
declare @f2 date
set @f1 = @fecha1
set	@f2 = @fecha2
if @opcion=1
begin
--consulta de compras


select FOLIO, [FECHA COMPRA], VENDEDOR,CLIENTE,[CANTIDAD DE ARTICULOS], DBO.FN_SUBTOTAL_COMPRAS(FOLIO) [SUBTOTAL],TOTAL,IVA,[FORMA DE PAGO] from V_VENTAS
WHERE [CANTIDAD DE ARTICULOS] > 0 and ([FECHA COMPRA] between @f1 and @f2)

end
else
begin
--CONSULTA DE DEVOLUCIONES
select FOLIO, [FOLIO VENTA], [FECHA DE DEVOLUCION],CLIENTE from V_DEVOL
WHERE ([FECHA DE DEVOLUCION] between @f1 and @f2) or([FECHA DE DEVOLUCION] in (@f1,@f2) )  
end

end
go

--drop procedure SP_V_FACTURAS_D
select * from venta
create procedure SP_V_FACTURAS_D(@opcion int, @folio varchar(13))
as
begin
if @opcion = 1 --visualizar detalle de venta
begin
select PRODUCTO, [PRECIO UNITARIO], CANTIDAD, convert(decimal(10,2),SUBTOTAL) [SUBTOTAL] from V_D_VENTA
where [FOLIO DE VENTA] = @folio
end
else
begin
declare @numero int
set @numero = convert(int,@folio)
select PRODUCTO, CANTIDAD, MOTIVO from V_DEVOL_D 
WHERE DEVOLUCION = @numero
end
end

go


select * from V_VENTAS
--drop view V_DEVOL_D
go
--creado
create view V_DEVOL_D as
select DD.DD_id_devolucion [DEVOLUCION],P.prod_descipcion [PRODUCTO], dd.DD_Cantidad [CANTIDAD], M.M_descripcion [MOTIVO] from Detalle_Devolucion as DD
join motivo as M
on DD.DD_motivo = M.id_motivo
join Producto as P
on DD.DD_id_prod = P.id_producto
go

--creado
-- drop function FN_SUMA_REPORTES
create function FN_SUMA_REPORTES (@opcion int, @producto varchar(35))
returns decimal(10,2)
begin
declare @resultado decimal(10,2)
set @resultado = 0

if @opcion = 1 --CANTIDAD DE PRODUCTOS
select  @resultado = SUM(CANTIDAD) from V_D_VENTA where PRODUCTO = @producto

if @opcion = 2
select  @resultado = SUM(SUBTOTAL) from V_D_VENTA where PRODUCTO = @producto

if @opcion = 3
begin
select  @resultado = SUM(SUBTOTAL) from V_D_VENTA where PRODUCTO = @producto
set @resultado = @resultado * 1.16
end

if @opcion = 4
begin
--0 o 1 productos merma
set @resultado=0
select @resultado = SUM(CANTIDAD) from V_DEVOL_D
where Producto=@producto and (motivo = 'Producto Incompleto' or motivo = 'Producto Dañado')
end

return @resultado
end

go

--creado
--USE BD_PROYECTO_JM
--drop procedure SP_REPORTE_INVENTARIO
create procedure SP_REPORTE_INVENTARIO(@Categoria varchar(30))
AS
BEGIN
declare @idCategoria int
select @idCategoria = id_catego from categoria where catego_descripcion = @Categoria

select prod_descipcion [PRODUCTO], prod_stock [EXISTENCIA], CONVERT(INT,ISNULL(dbo.FN_SUMA_REPORTES(4,prod_descipcion),0)) [MERMA] from Producto
where id_producto <> 0 and prod_Catego =@idCategoria
order by prod_descipcion, prod_stock

END
go

select * from V_DEVOL_D
select * from Producto_Eliminado