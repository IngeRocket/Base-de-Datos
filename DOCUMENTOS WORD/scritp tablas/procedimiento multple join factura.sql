USE BD_PROYECTO_JM
go
create PROCEDURE SP_FORMATO_FACTURA(@NoVenta varchar(13))
as
begin

select V.V_Fecha_Compra [FECHA COMPRA],V.V_Cantidad_Articulos [CANTIDAD ARTICULOS],dbo.FN_SUBTOTAL_COMPRAS(V_NoVenta) [SUBTOTAL],V.V_Total [TOTAL + IVA], VE.V_nombre + ' '+ VE.V_AP+' '+VE.V_AM [VENDEDOR], V.V_Caja [CAJA], FP.FP_descripcion [FORMA PAGO], 
CL.C_nombre+ ' '+CL.C_AP+' '+ CL.C_AM [CLIENTE], CT.T_telefono [TELEFONO], CD.D_direccion+' '+CONVERT(VARCHAR,CD.D_Codigo_Postal) [DIRECCION], CO.C_email [CORREO] from Venta as V
join Forma_Pago FP
on FP.id_pago = V.V_Forma_Pago
join Vendedor VE
on VE.V_RFC = V.V_V_RFC
join Cliente CL
on CL.C_RFC = V.V_C_RFC
join Cliente_Telefono CT
on CT.T_RFC_C = V.V_C_RFC
join Cliente_Domicilio CD
on CD.D_RFC_C = V.V_C_RFC
join Cliente_Correo CO
on CO.C_C_RFC = V.V_C_RFC
WHERE V.V_NoVenta = @NoVenta and V_Cantidad_Articulos > 0
end
go

select * from venta


select * from venta
select dbo.FN_SUBTOTAL_COMPRAS('1005190103311')