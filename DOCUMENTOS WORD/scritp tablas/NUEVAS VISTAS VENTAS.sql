use BD_PROYECTO_JM

--creado
--CREADO
CREATE VIEW V_VENTAS 
AS
SELECT V.V_NoVenta [FOLIO],  V.V_Fecha_Compra AS [FECHA COMPRA], C.C_nombre +' '+C.C_AP+' '+ C.C_AM AS CLIENTE, VE.V_nombre+' '+VE.V_AP+' '+VE.V_AM AS VENDEDOR, V.V_Cantidad_Articulos [CANTIDAD DE ARTICULOS], V.V_Total [TOTAL], V.V_V_Comision [COMISION DE VENDEDOR 3%], V.V_Caja [CAJA], FP.FP_descripcion [FORMA DE PAGO], V.V_IVA [IVA] FROM VENTA AS V
JOIN Forma_Pago AS FP
ON V.V_Forma_Pago = FP.id_pago
JOIN CLIENTE AS C
ON V.V_C_RFC = C.C_RFC
JOIN VENDEDOR AS VE
ON V.V_V_RFC = VE.V_RFC


GO
--CREADO
--WHERE V.V_NoVenta = @FOLIO
/*
SELECT DV.DV_NoVenta [FOLIO DE VENTA],P.prod_descipcion [PRODUCTO] ,DV.DV_PRECIO [PRECIO UNITARIO], DV.DV_cantidad [CANTIDAD] ,DV.DV_SubTotal [SUBTOTAL]  FROM Detalle_Venta AS DV
JOIN PRODUCTO AS P
ON DV.DV_id_prod = P.id_producto
--WHERE DV.DV_NoVenta = @FOLIO


go
*/
--CREADO
create view V_D_VENTA
AS
SELECT DV.DV_NoVenta [FOLIO DE VENTA],P.prod_descipcion [PRODUCTO] ,DV.DV_PRECIO [PRECIO UNITARIO], DV.DV_cantidad [CANTIDAD] ,DV.DV_SubTotal [SUBTOTAL]  FROM Detalle_Venta AS DV
JOIN PRODUCTO AS P
ON DV.DV_id_prod = P.id_producto

GO

--sin crear
create procedure SP_V_VENTAS(@RFC_C varchar(13), @RFC_V varchar(13), @caja int, @F1 VARCHAR(13), @F2 VARCHAR(13) ,@opcion int)
as
begin
DECLARE @NOMBRE_COMPLETO VARCHAR(60)
select @NOMBRE_COMPLETO= V_nombre+' '+V_AP+' '+V_AM  from Vendedor where V_RFC = @RFC_V

--OPCION 0 TODAS MIS VENTAS (PANTALLA PRINCIPAL)
if @opcion=0
begin
SELECT  [FECHA COMPRA], CLIENTE,VENDEDOR,[CANTIDAD DE ARTICULOS],TOTAL,CAJA,[FORMA DE PAGO] from V_VENTAS
where VENDEDOR = @NOMBRE_COMPLETO
ORDER BY [FECHA COMPRA],FOLIO
end


--opcion 1 TODAS MIS VENTAS EN CAJAS ESPECIFICAS
if @opcion=1
begin
SELECT [FECHA COMPRA], CLIENTE,VENDEDOR,[CANTIDAD DE ARTICULOS],TOTAL,CAJA,[FORMA DE PAGO] from V_VENTAS
where VENDEDOR = @NOMBRE_COMPLETO and CAJA=@caja
ORDER BY [FECHA COMPRA], FOLIO
end

--OPCION 2 BUSCAR VENTAS DE VENDEDOR EN RANGO DE FECHAS
if @opcion=2
BEGIN
declare @fecha1 date
declare @fecha2 date

set @fecha1 = convert(date,@F1)
set @fecha2 = convert(date,@F2)

SELECT  [FECHA COMPRA], CLIENTE,VENDEDOR,[CANTIDAD DE ARTICULOS],TOTAL,CAJA,[FORMA DE PAGO] from V_VENTAS
where VENDEDOR = @NOMBRE_COMPLETO AND [FECHA COMPRA] BETWEEN @fecha1 AND @fecha2
ORDER BY [FECHA COMPRA],FOLIO


END
--OPCION 3 TODAS


--OPCION 4 CLIENTE ES LA TIENDA

end
select * from V_Vendedor

go
/*
update Venta
set V_V_Comision = CONVERT (decimal(10,2), V_V_Comision)

select * from cliente

select * from venta
select * from Detalle_Venta

delete from venta
*/
GO
