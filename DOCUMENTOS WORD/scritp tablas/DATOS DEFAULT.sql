use BD_PROYECTO_JM
--ya se ejcutaron
--alter table Administrador drop column admin_pass
--alter table Vendedor drop column V_No_Nomina

--alter table Administrador add admin_pass varbinary(15)
--alter table Vendedor add V_No_Nomina varchar(15) not null UNIQUE
--fin de ejecutados
--SELECT * FROM Administrador

--datos default
--CONVERTIR DATO
insert into Administrador(admin_nombre,admin_pass) values ('Julio Mendoza',CONVERT(VARBINARY,'250515'))
--DESCIFRAR
--SELECT CONVERT(VARCHAR, 0x323530353135)

--categorias
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Bebidas',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Botana',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Carnes Frias',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Cocina',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Comidas',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Computo',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Electrodomesticos',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Electronica',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Ferreteria',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Higiene',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Jardin',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Juguetes',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Lacteos',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Licoreria',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Linea Blanca',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('Papeleria',0)
Insert into Categoria (catego_descripcion,Catego_id_admin) values ('VideoJuegos',0)

/*
update Categoria
set catego_descripcion = 'VideoJuegos' where catego_descripcion= 'videojuegos'

select C.catego_descripcion as Categoria, A.admin_nombre as Administrador from Categoria as C
join Administrador A
on C.Catego_id_admin=A.id_admin
*/
--producto default Nombre (Descontinuado)
insert into Producto(prod_descipcion, prod_stock, prod_precio, prod_Punto_RE, prod_Cantidad_RE, prod_Catego, prod_id_admin) 
values	('Descontinuado',0,0,0,0,0,0)

--Vendedor default
insert into Vendedor(V_nombre,V_AP,V_AM,V_CURP,V_PASS,V_id_admin,V_No_Nomina,V_RFC) values ('Julio Angel','Mendoza','Arredondo','MEAJ970706HNLR005',CONVERT(VARBINARY,'19970706'),0,'123456789','MEAJ970706HNL')
SELECT * FROM Vendedor
--Cliente default
insert into Cliente (C_nombre,C_AP,C_AM,C_Fecha_Nacimiento,C_RFC,C_RFC_V) values ('GIGANTE', 'S.A','C.V','19800206','GIG800216XXXX','MEAJ970706HNL')
select * from cliente
--Formas de Pago
alter table Forma_Pago alter column FP_descripcion varchar(20) not null

insert into Forma_Pago(FP_descripcion) values('Descontinuado')
insert into Forma_Pago(FP_descripcion) values('Efectivo')
insert into Forma_Pago(FP_descripcion) values('Tarjeta de Debito')
insert into Forma_Pago(FP_descripcion) values('Tarjeta de Credito')
insert into Forma_Pago(FP_descripcion) values('PayPal')
insert into Forma_Pago(FP_descripcion) values('Vales de Despensa')
insert into Forma_Pago(FP_descripcion) values('Puntos Infonavit')
insert into Forma_Pago(FP_descripcion) values('BitCoin')
insert into Forma_Pago(FP_descripcion) values('Oro')
insert into Forma_Pago(FP_descripcion) values('Escrituras de casa')

--Motivos Reembolso

insert into Motivo(M_descripcion) values('Producto Incompleto')
insert into Motivo(M_descripcion) values('Producto Dañado')
insert into Motivo(M_descripcion) values('No Gusto')
insert into Motivo(M_descripcion) values('Producto Equivocado')


select * from categoria