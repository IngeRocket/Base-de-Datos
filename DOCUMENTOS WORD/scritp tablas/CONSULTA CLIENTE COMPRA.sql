use BD_PROYECTO_JM
select * from Detalle_Venta
SELECT * FROM V_VENTAS
SELECT * FROM V_DEVOL
--CLIENTES
GO
--drop procedure SP_V_CLIENTE
CREATE PROCEDURE SP_V_CLIENTE (@RFC_C VARCHAR(13),@CATEGORIA VARCHAR(20),@FECHA1 VARCHAR(13), @FECHA2 VARCHAR(13))
AS
BEGIN
DECLARE @Categoriaid int
DECLARE @F1 date
DECLARE @F2 date

select @Categoriaid = id_catego from Categoria where catego_descripcion = @CATEGORIA
set @F1 = @FECHA1
set @F2 = @FECHA2 

Select p.prod_descipcion [PRODUCTO], DV.DV_precio [PRECIO PRODUCTO],convert(int ,SUM(DV.DV_cantidad)) [PRODUCTOS COMPRADOS], convert(decimal(10,2),SUM(DV.DV_SubTotal)) [SUBTOTAL], CONVERT(DECIMAL(10,2),SUM(DV.DV_SubTotal)*1.16) [IVA] from Detalle_Venta DV
join Venta as V
on V.V_NoVenta = DV.DV_NoVenta
join Producto as P
on P.id_producto = DV.DV_id_prod
WHERE
V.V_C_RFC = @RFC_C and
P.prod_Catego = @Categoriaid and
V.V_Fecha_Compra between @F1 and @F2
group by p.prod_descipcion,dv.DV_precio
order by p.prod_descipcion
END

SELECT * FROM V_D_VENTA
select * from V_Producto where producto like 'DES%'
select * from categoria

--VENDEDORES
GO
--SELECT NAME FROM SYSOBJECTS WHERE XTYPE='P'
--drop procedure SP_V_VENDEDOR
CREATE PROCEDURE SP_V_VENDEDOR(@RFC_V VARCHAR(13),@CATEGORIA VARCHAR(20),@FECHA1 VARCHAR(13), @FECHA2 VARCHAR(13),@CAJA INT)
AS
BEGIN

DECLARE @Categoriaid int
DECLARE @F1 date
DECLARE @F2 date

select @Categoriaid = id_catego from Categoria where catego_descripcion = @CATEGORIA

set @F1 = @FECHA1
set @F2 = @FECHA2
if @caja = 0
begin
Select p.prod_descipcion [PRODUCTO], SUM(DV.DV_cantidad) [CANTIDAD VENDIDA], CONVERT(DECIMAL(10,2),SUM(DV.DV_SubTotal)) [SUBTOTAL], CONVERT(DECIMAL(10,2),SUM(DV.DV_SubTotal)*1.16) [IVA], CONVERT(DECIMAL(10,2),SUM(DV.DV_SUBTOTAL)*0.0348) [COMISION], V.V_Caja [CAJA] from Detalle_Venta DV
join Venta as V
on V.V_NoVenta = DV.DV_NoVenta
join Producto as P
on P.id_producto = DV.DV_id_prod
WHERE
V.V_V_RFC = @RFC_V and
P.prod_Catego = @Categoriaid and
V.V_Fecha_Compra between @F1 and @F2
group by p.prod_descipcion, V.V_Caja
order by V.V_Caja, p.prod_descipcion
end
else
begin
Select p.prod_descipcion [PRODUCTO], SUM(DV.DV_cantidad) [CANTIDAD VENDIDA], CONVERT(DECIMAL(10,2),SUM(DV.DV_SubTotal)) [SUBTOTAL], CONVERT(DECIMAL(10,2),SUM(DV.DV_SubTotal)*1.16) [IVA], CONVERT(DECIMAL(10,2),SUM(DV.DV_SUBTOTAL)*0.0348) [COMISION] from Detalle_Venta DV
join Venta as V
on V.V_NoVenta = DV.DV_NoVenta
join Producto as P
on P.id_producto = DV.DV_id_prod
WHERE
V.V_Caja = @CAJA AND
V.V_V_RFC = @RFC_V and
P.prod_Catego = @Categoriaid and
V.V_Fecha_Compra between @F1 and @F2
group by p.prod_descipcion
order by p.prod_descipcion
end

END

go

select * from V_Ventas
select * from Detalle_Venta
go

--drop procedure SP_VENDEDOR_COMISION
create procedure SP_VENDEDOR_COMISION(@FECHA1 varchar(13), @FECHA2 varchar(13),@nombre varchar(60), @CAJA int)
as
begin
declare @F1 date
declare @F2 date
set @F1 = @FECHA1
set @f2 = @FECHA2
if @CAJA = 0

BEGIN
select FOLIO, [FECHA COMPRA], CLIENTE,[CANTIDAD DE ARTICULOS], TOTAL [TOTAL + IVA], [COMISION DE VENDEDOR 3%], CAJA FROM V_VENTAS
where
VENDEDOR = @NOMBRE AND
[CANTIDAD DE ARTICULOS] > 0 and
[FECHA COMPRA] between @f1 and @f2
order by [FECHA COMPRA], FOLIO ,CAJA
END
ELSE
BEGIN
select FOLIO, [FECHA COMPRA], CLIENTE,[CANTIDAD DE ARTICULOS], TOTAL [TOTAL + IVA], [COMISION DE VENDEDOR 3%], CAJA FROM V_VENTAS
WHERE CAJA = @CAJA and
[CANTIDAD DE ARTICULOS] > 0 and
VENDEDOR = @NOMBRE AND
[FECHA COMPRA] between @f1 and @f2
order by [FECHA COMPRA], FOLIO
END
end


go

--drop PROCEDURE SP_VENDEDOR_VENTA	
create procedure SP_VENDEDOR_VENTA(@nombre varchar(60), @CAJA int)
as
begin

if @CAJA = 0
BEGIN
select FOLIO, [FECHA COMPRA], CLIENTE,[CANTIDAD DE ARTICULOS], TOTAL [TOTAL + IVA], CAJA FROM V_VENTAS
where
VENDEDOR = @NOMBRE and
[CANTIDAD DE ARTICULOS] > 0
order by [FECHA COMPRA], FOLIO ,CAJA
END
ELSE
BEGIN
select FOLIO, [FECHA COMPRA], CLIENTE,[CANTIDAD DE ARTICULOS], TOTAL [TOTAL + IVA] FROM V_VENTAS
WHERE CAJA = @CAJA and
VENDEDOR = @NOMBRE and
[CANTIDAD DE ARTICULOS] > 0
order by [FECHA COMPRA], FOLIO
END
end


go

select * from venta
sp_helptext 'SP_VENDEDOR_VENTA'

go
create procedure SP_DG_CLIENTES
AS
begin
select C_RFC [RFC], C_nombre + ' '+ C_AP +' '+C_AM [NOMBRE] from Cliente
ORDER BY C_RFC, NOMBRE
end
go

create procedure SP_DG_VENDEDOR
AS
begin
select V_RFC [RFC], v_nombre + ' '+ v_AP +' '+v_AM [NOMBRE] from Vendedor
ORDER BY V_RFC, NOMBRE
end

go

CREATE PROCEDURE SP_ADMIN_PRINCIPAL(@cantidad int)
as
begin
select PRODUCTO,STOCK, convert(decimal(10,2),PRECIO) [PRECIO],CATEGORIA,[PUNTO REORDEN],[CANTIDAD REORDEN], [FECHA REORDEN], [FECHA ALTA] from V_Producto
where (stock - @cantidad) <= [Punto Reorden]
order by Categoria,Producto
end

go 
--DROP PROCEDURE SP_VENTA_USUARIO
CREATE PROCEDURE SP_VENTA_USUARIO (@RFC varchar(13), @FECHA1 varchar(13), @FECHA2 varchar(13), @opcion int)
as
begin
declare @f1 date
declare @f2 date
set @f1 =convert(date,@fecha1)
set @f2 =convert(date,@fecha2)

if @opcion=1 --cliente
begin
select V.V_NoVenta [FOLIO], V.V_Fecha_Compra [FECHA COMPRA], V.V_Cantidad_Articulos [CANTIDAD DE ARTICULOS], dbo.FN_SUBTOTAL_COMPRAS(V.V_NoVenta) [SUBTOTAL],V.V_TOTAL [TOTAL + IVA], FP.FP_descripcion [FORMA PAGO],
(VE.V_nombre +' '+VE.V_AP+' '+VE.V_AM) [VENDEDOR] from Venta as V
join Forma_Pago as FP
on FP.id_pago = V.V_Forma_Pago
join Vendedor as VE
on V.V_V_RFC = VE.V_RFC
WHERE V_C_RFC = @RFC AND 
V.V_Cantidad_Articulos > 0 AND
v.V_Fecha_Compra between @F1 and @F2
ORDER BY V_Fecha_Compra, V.V_NoVenta
end
else
begin
select V.V_NoVenta [FOLIO], V.V_Fecha_Compra [FECHA COMPRA], V.V_Cantidad_Articulos [CANTIDAD DE ARTICULOS],dbo.FN_SUBTOTAL_COMPRAS(V.V_NoVenta) [SUBTOTAL] ,V.V_TOTAL [TOTAL + IVA], FP.FP_descripcion [FORMA PAGO],
(C.C_nombre +' '+C.C_AP+' '+C.C_AM) [CLIENTE] from Venta as V
join Forma_Pago as FP
on FP.id_pago = V.V_Forma_Pago
join Cliente as C
on V.V_C_RFC = C_RFC
WHERE V_V_RFC = @RFC AND 
V.V_Cantidad_Articulos > 0 AND
v.V_Fecha_Compra between @F1 and @F2
ORDER BY V_Fecha_Compra, V.V_NoVenta
end

end
GO

select dbo.FN_SUBTOTAL_COMPRAS('1005190103311')
go


-- drop procedure SP_DESCONTAR_UNIDAD
 CREATE PROCEDURE SP_DESCONTAR_UNIDAD(@producto varchar(35),@categoria varchar(20)) AS
 BEGIN
 --si cambio la cantidad de reorde a -1 puedo bajar hasta el producto 0, al final ejecutar el rollback para deshacer esto
 IF not exists (select 1 from sysobjects where xtype='U' and name = 'Temporal') 
 begin
  create table Temporal(
  t_id_prod int primary key,
  t_stock int,
  t_PE int
  ); 
  end
 

 declare @indice int
 declare @indice_prod int
 declare @Stock_origin int
 declare @PE_origin int

 set @indice_prod = -1 --por si no encunetra nada
 select @indice = id_catego from Categoria where catego_descripcion = @categoria -- id categoria
 select @indice_prod = id_producto from Producto where prod_Catego = @indice and prod_descipcion = @producto --id produtcto
 select @Stock_origin = prod_stock from producto where id_producto= @indice_prod
 select @PE_origin = prod_Punto_RE from producto where id_producto= @indice_prod

 --LA TABLA SIGUE SIN MODIFICAR SI SU PE <> - 1
 if @PE_origin <> - 1
 begin
 --cappturar datos originales
 insert into Temporal(t_id_prod,t_stock,t_PE) values (@indice_prod,@Stock_origin,@PE_origin)
 --hacer modificacion para que no interfiera el trigger
  update Producto
 set prod_stock = prod_stock - 1,
 prod_Punto_RE = -1					--con esto evito que interfiera el trigger de reorden
 where id_producto = @indice_prod
 end
 else
 begin
 --solo se decrementa el stock casi a llegar a 0
 update Producto
 set prod_stock = prod_stock - 1					--con esto evito que interfiera el trigger de reorden
 where id_producto = @indice_prod
 end

 END
 GO

 --drop procedure SP_AGREGAR_UNIDAD
 CREATE PROCEDURE SP_AGREGAR_UNIDAD(@producto varchar(35),@precio_origen float) as
 begin
 declare @id_producto int
 declare @categoria int
 set @id_producto = -1
 set @categoria = -1
 select @id_producto = id_producto from Producto where prod_descipcion = @producto and prod_precio = @precio_origen
 select @categoria = prod_Catego from Producto where prod_descipcion = @producto and prod_precio = @precio_origen

 if @categoria = -1 Or @id_producto = -1
 begin
 --no hacer nada, se necesita hacer algo para que no marque error el begin end del if
set @categoria = -1
set @id_producto = -1
 end
 else
 begin
 update Producto
 set prod_stock = prod_stock + 1
 where id_producto = @id_producto and prod_Catego = @categoria 
 end
 end
 go
 go

 GO

 --drop PROCEDURE SP_ROLLBACK
 create procedure SP_ROLLBACK
 AS 
 BEGIN

 if exists (select 1 from sysobjects where xtype='U' and name = 'Temporal')
 begin
 --existe la tabla, si se intento comprar
 UPDATE
    Producto
SET
   prod_stock = A.t_stock,
   prod_Punto_RE = A.t_PE
FROM Temporal AS A
 JOIN Producto AS P
 ON P.id_producto = A.t_id_prod
WHERE
 p.id_producto = A.t_id_prod


	--despues de regresar los datos a su origen se borrara la tabla
	delete Temporal;
	drop table Temporal;

 end



 END
 go

 select * from Producto
 update producto
 set prod_stock = 2,
 prod_Punto_RE = 1
 where id_producto = 29

 select * from Producto
 where prod_Punto_RE < 0