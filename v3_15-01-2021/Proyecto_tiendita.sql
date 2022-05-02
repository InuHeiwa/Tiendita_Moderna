--13-01-21v1
drop database Tiendita_Moderna_v1;

create database Tiendita_Moderna_v1;

use Tiendita_Moderna_v1;

-----------------------------------------------Catalogos--------------------------------------------------
--Catalogo de puestos
create table cat_puestos(
	id_puesto tinyint identity (1, 1) primary key,
	pues_puesto nvarchar(15) not null,
	suel_puesto decimal(7,2)
);
--Insercin de catalogo puestos
insert into cat_puestos values('Gerente', 8000.00);
insert into cat_puestos values('Empleado', 6000.00);

--Catalogo de estados de pedidos
create table cat_estados_pedidos(
	id_estado tinyint identity(1,1) primary key,
	estado nvarchar(13) not null
);
--Insercin de catalogo de estados de pedidos
insert into cat_estados_pedidos values('Registrado');
insert into cat_estados_pedidos values('En camino');
insert into cat_estados_pedidos values('Entregado');
insert into cat_estados_pedidos values('Cancelado');

--Catalogo de tipos de pedidos
create table cat_tipo_pedido(
	id_tip_ped tinyint identity(1,1) primary key,
	tipo_ped nvarchar(10)
);
--Insercin de catlogo de tipos de pedidos
insert into cat_tipo_pedido values('Especial');
insert into cat_tipo_pedido values('Normal');

--Catalogo estatus empleados
create table cat_estatus_emp(
	id_estatus tinyint identity(1, 1) primary key,
	estatus nvarchar(15)
);
--Insercin de catalogo de estatus de empleados
insert into cat_estatus_emp values('Activo');
insert into cat_estatus_emp values('Inactivo');
insert into cat_estatus_emp values('Despedido');

--Catalogo de impuestos
create table cat_impuestos(
	id_impuesto tinyint identity(1,1) primary key,
	impuesto nvarchar(7) not null,
	porcentaje decimal(3,2) not null
);
--Insercin de catalogo impuestos
insert into cat_impuestos values ('IVA', 0.16);
insert into cat_impuestos values ('ISR', 0.6);
insert into cat_impuestos values ('IMSS', 0.20);

---------------------------------------------------------Tablas----------------------------------------------------------
--Tabla de empleados
create table empleados(
	id_emp smallint identity (1, 1) primary key,
	nom_emp nvarchar(30) not null,
	appat_emp nvarchar(20) not null,
	apmat_emp nvarchar(20) not null,
	sexo_emp char,
	fnac_emp date not null,
	tel_emp nvarchar(10) not null,
	con_eme_emp nvarchar(10),
	rfc_emp nvarchar(13) not null,
	pues_emp tinyint not null,
	muni_emp nvarchar(20) not null,
	calle_emp nvarchar(20) not null,
	cpos_emp nvarchar(5) not null,
	nint_emp nvarchar(4),
	next_emp nvarchar(4) not null,
	estatus_emp tinyint not null,
	foreign key (pues_emp) references cat_puestos(id_puesto),
	foreign key (estatus_emp) references cat_estatus_emp(id_estatus)
);

--Tabla de cuentas
create table cuentas(
	id_emp smallint not null,
	clave varbinary(max) not null,
	llave nvarchar(15) not null,
	foreign key (id_emp) references empleados(id_emp)
);

--Tabla de inventario
create table inventario(
	codigo smallint primary key,
	nom_prod nvarchar(50) not null,
	prec_com_prod decimal(7,2),
	prec_ven_prod decimal(7,2),
	fec_cad_prod date,
	cant_prod smallint
);

--Tabla de proveedores
create table proveedores(
	id_prov smallint identity(1, 1) primary key,
	nom_prov nvarchar(30) not null,
	muni_prov nvarchar(30) not null,
	calle_prov nvarchar(30) not null,
	cp_prov nvarchar(5) not null,
	num_ext_prov nvarchar(4) not null,
	tel_prov nvarchar(10) not null,
	rfc_prov nvarchar(13) not null,
	nom_rep nvarchar(40)
);

--Tabla de clientes
create table clientes(
	id_client smallint identity(1, 1) primary key,
	nom_client nvarchar(40) not null,
	calle_client nvarchar(20) not null,
	next_client nvarchar(4) not null,
	nint_client nvarchar(4),
	telf_client nvarchar(10) not null
);

--Tabla de compras
create table compras(
	id_comp smallint identity(1, 1) primary key,
	prov_comp smallint not null,
	emp_comp smallint not null,
	fec_comp date not null,
	iva_comp decimal(7,2) not null,
	total_comp decimal(7,2) not null,
	estado_compra tinyint not null,
	foreign key (prov_comp) references proveedores(id_prov),
	foreign key (emp_comp) references empleados(id_emp),
	foreign key (estado_compra) references cat_estados_pedidos(id_estado)
);

--Tabla de ventas
create table ventas(
	id_vent smallint identity(1, 1) primary key,
	fec_vent date not null,
	emp_vent smallint not null,
	iva_vent decimal(7,2) not null,
	total_vent decimal(7,2) not null,
	foreign key (emp_vent) references empleados(id_emp)
);

--Tabla de corte
create table corte(
	id_corte smallint identity(1,1) primary key,
	ing_corte decimal(7,2) not null,
	egr_corte decimal(7,2) not null,
	fec_corte date not null,
	sal_corte decimal(7,2) not null
);

--Tabla de pedidos
create table pedidos(
	id_ped smallint identity(1, 1) primary key,
	client_ped smallint not null,
	fec_ped date not null,
	id_emp smallint not null,
	estado_ped tinyint not null,
	tip_ped tinyint not null,
	iva_ped decimal(7,2) not null,
	total_ped decimal(7,2) not null,
	fec_ent date,
	foreign key (client_ped) references clientes(id_client),
	foreign key (estado_ped) references cat_estados_pedidos(id_estado),
	foreign key (tip_ped) references cat_tipo_pedido(id_tip_ped),
	foreign key (id_emp) references empleados(id_emp)
);


--Tabla de pago a empleados
create table pagos_emp(
	id_pago smallint identity(1,1) primary key,
	fecha date not null,
	total decimal(7,2) not null
);

--Tabla de historial de movimientos
create table historial(
	id_pago smallint,
	id_pedido smallint,
	id_compra smallint,
	id_venta smallint,
	producto smallint,
	cantidad smallint,
	subtotal decimal(7,2) not null,
	foreign key (id_pago) references pagos_emp(id_pago),
	foreign key (producto) references inventario(codigo),
	foreign key (id_pedido) references pedidos(id_ped),
	foreign key (id_compra) references compras(id_comp),
	foreign key (id_venta) references ventas(id_vent),
);

--Tabla de productos/proveedores
create table productos(
	id_prod smallint not null,
	id_prov smallint not null,
	foreign key (id_prod) references inventario(codigo),
	foreign key (id_prov) references proveedores(id_prov)
);

--Tabla caja
create table caja(
	id_caja smallint identity(1,1) primary key,
	saldo_inicial decimal(7,2) not null,
	saldo_corte decimal(7,2),
	saldo_final decimal(7,2),
	empleado smallint,
	fecha date not null,
	foreign key (empleado) references empleados(id_emp)
);

----------------------------------------------------------------Procedures-----------------------------------------------------
--Declaramos el proceso para encriptar la contrasea
create procedure sp_Clave_encript
(@nomU nvarchar(40), @clavU nvarchar(15), @keyU nvarchar(15))
as
declare
	@pswB varbinary(max),
	@idU tinyint
begin
	set @pswB = ENCRYPTBYPASSPHRASE(@keyU, @clavU);
	select @idU = id_emp from empleados where @nomU = nom_emp
	insert into cuentas values(@idU, @pswB, @keyU);
end;

--Acceso al punto de venta
create procedure sp_comp_clave
(@nomE nvarchar(40), @clve nvarchar(10))
as
declare
	@id tinyint,
	@clave nvarchar(10),
	@bandera bit
begin
	select @id=id_emp from empleados where @nomE=nom_emp
	select @clave = CONVERT(nvarchar(max), DECRYPTBYPASSPHRASE(llave, clave))
	from cuentas where @id = id_emp;
	if(@clave = @clve)
	begin
		select id_emp, nom_emp, pues_emp from empleados where nom_emp=@nomE
	end
	else
	begin
		select 0
	end
end;

--Mostrar datos de los empleados
create procedure sp_emp as
begin
select	id_emp as ID,
		nom_emp as Nombre,
		appat_emp as Apellido_Paterno,
		apmat_emp as Apellido_Materno,
		sexo_emp as Sexo,
		fnac_emp as Fecha_Nacimiento,
		tel_emp as Telefono,
		con_eme_emp as Telefono_Emergencias,
		rfc_emp as RFC,
		P.pues_puesto as Puesto,
		muni_emp as Municipio,
		calle_emp as Calle,
		cpos_emp as CP,
		next_emp as No_Exterior,
		nint_emp as No_Interior,
		EP.estatus as Estatus from empleados E, cat_puestos P, cat_estatus_emp EP
		where E.pues_emp = P.id_puesto and E.estatus_emp = EP.id_estatus
end;

--Procedimiento de manejo de empleados
create procedure sp_manejo_empleados(@opcion smallint, @id_emp smallint,
		@nom_emp nvarchar(40), @appat_emp nvarchar(20), @apmat_emp nvarchar(20), @sexo_emp char, @fnac_emp date, @tel_emp nvarchar(10),
		@con_eme_emp nvarchar(10), @rfc_emp nvarchar(13), @pues_emp tinyint, @muni_emp nvarchar(20), @calle_emp nvarchar(20), @cpos_emp nvarchar(6),
		@next_emp nvarchar(8), @nint_emp nvarchar(8), @estatus_emp tinyint, @clave nvarchar(15), @llave nvarchar) as
begin  if(@opcion=1)
	begin
		insert into empleados values(@nom_emp, @appat_emp, @apmat_emp, @sexo_emp, @fnac_emp, @tel_emp, @con_eme_emp, 
		@rfc_emp, @pues_emp, @muni_emp, @calle_emp, @cpos_emp, @next_emp, @nint_emp, @estatus_emp);

		exec sp_Clave_encript @nom_emp, @clave, @llave;
	end
	else if(@opcion=2)
	begin
		update empleados set nom_emp = @nom_emp, appat_emp=@appat_emp, apmat_emp=@apmat_emp, sexo_emp=@sexo_emp, fnac_emp=@fnac_emp, 
		tel_emp=@tel_emp, con_eme_emp=@con_eme_emp, rfc_emp=@rfc_emp, pues_emp=@pues_emp, muni_emp=@muni_emp, calle_emp=@calle_emp, cpos_emp=@cpos_emp, 
		next_emp=@next_emp, nint_emp=@nint_emp, estatus_emp=@estatus_emp 
		where @id_emp=id_emp;
	end
end;

--Listar empleados en login
create procedure sp_lista_emp
as
begin
	select nom_emp from empleados
end;

--Mostrar datos del cliente
create procedure sp_mostrar_datos_cliente
as
begin
    select id_client as ID, nom_client as Nombre, calle_client as Calle, next_client as No_Exterior, nint_client as No_Interior, telf_client as Telefono
	from clientes
end;

--Procedimiento para manejo de clientes
create procedure sp_maneja_client
    (@opcion smallint, @id_client smallint, @nom_client nvarchar(40), @calle_client nvarchar(20), @next_client nvarchar(4), 
    @nint_client nvarchar(4), @telf_client nvarchar(10))
as
begin
    if(@opcion = 1)
    begin
        insert into clientes values (@nom_client, @calle_client, @next_client, @nint_client, @telf_client);
    end
    else if(@opcion = 2)
    begin
        update clientes set nom_client=@nom_client, calle_client=@calle_client, next_client=@next_client, 
        nint_client=@nint_client, telf_client=@telf_client
        where id_client = @id_client
    end
end;

--Mostrar lista de proveedores
create procedure sp_mostrar_proveedores
as
begin
    select id_prov as ID,  nom_prov as Proveedor, muni_prov as Municipio, calle_prov as Calle, cp_prov as CP,
            num_ext_prov as Numero, tel_prov as Telefono, rfc_prov as RFC, nom_rep as Representante
    from proveedores
end;


--Modificar lista de proveedores
create procedure sp_maneja_proveedores(@opcion smallint,@id_prov smallint, @nom_prov nvarchar(30), @muni_prov nvarchar(30), @calle_prov nvarchar(30), 
    @cp_prov nvarchar(5), @num_ext_prov nvarchar(4), @tel_prov nvarchar(10), @rfc_prov nvarchar(13), @nom_rep nvarchar(40))
as
begin
    if(@opcion=1)
    begin
        insert into proveedores values (@nom_prov, @muni_prov, @calle_prov, @cp_prov, @num_ext_prov, @tel_prov, @rfc_prov, @nom_rep);
    end
    else if(@opcion=2)
    begin
        update proveedores set nom_prov=@nom_prov, muni_prov=@muni_prov, calle_prov=@calle_prov, 
        cp_prov=@cp_prov, num_ext_prov=@num_ext_prov, tel_prov=@tel_prov, rfc_prov=@rfc_prov, nom_rep=@nom_rep
        where id_prov=@id_prov
    end
end;

--Mostrar lista de productos del inventario
create procedure sp_mostrar_inventario
as
begin
    select codigo as Codigo, nom_prod as Producto, prec_com_prod as Compra, prec_ven_prod as Venta,
    fec_cad_prod as Caducidad, cant_prod as Cantidad
    from inventario
end;

--Mostrar lista de Compras
create procedure sp_mostrar_compras
as
begin
    select id_comp as ID, PR.nom_prov as Proveedor, EM.nom_emp as Empleado, fec_comp as Fecha, 
    iva_comp as IVA, total_comp as Total, estado as Estado
    from compras CO, cat_estados_pedidos CA, empleados EM, proveedores PR
	where CO.estado_compra = CA.id_estado and PR.id_prov=CO.prov_comp and EM.id_emp=Co.emp_comp  
end;

--Modificar lista de productos del inventario
create procedure sp_modificar_inventario (@opcion smallint, @codigo smallint, @nom_prod nvarchar(50), 
    @prec_com_prod decimal(7,2), @prec_ven_prod decimal(7,2), @fec_cad_prod date, @cant_prod smallint)
as
begin
    if(@opcion = 1)
    begin
        insert into inventario values (@codigo, @nom_prod, @prec_com_prod, @prec_ven_prod, @fec_cad_prod, @cant_prod)
    end
    else if(@opcion = 2)
    begin
        update inventario set codigo=@codigo, nom_prod=@nom_prod, prec_com_prod=@prec_com_prod, prec_ven_prod=@prec_ven_prod, 
        fec_cad_prod=@fec_cad_prod, cant_prod=@cant_prod
        where codigo=@codigo
    end
end;

--Mostrar la lista de productos en proveedores
create procedure sp_mostrar_productos (@id_prov smallint)
as
begin
    select I.nom_prod as Producto 
    from productos P, inventario I
    where I.codigo = P.id_prod and @id_prov=P.id_prov 
end;

--Mostrar solo proveedores
create procedure sp_listar_proveedores
as
begin
	select nom_prov,id_prov
	from proveedores
end;

--Mostrar productos de provedor
create procedure sp_listar_productos_proveedores(@proveedor smallint)
as
begin
	select I.nom_prod, P.id_prod
	from productos P, inventario I
	where I.codigo = P.id_prod and @proveedor = P.id_prov
end;

--Mostrar ltima compra
create procedure sp_ultima_compra
as
begin
	select max(id_comp)
	from compras
end;

--Agregar una operacin a historial
create procedure sp_historial(@operacion smallint, @id_op smallint, @id_prod smallint, @cantidad smallint, @subtotal decimal(7,2)) as
begin if(@operacion=0)
	begin
		insert into historial values (@id_op, null, null, null, @id_prod, @cantidad, @subtotal);
	end
	else if(@operacion=1)
	begin
		insert into historial values (null, @id_op, null, null, @id_prod, @cantidad, @subtotal);
	end
	else if(@operacion=2)
	begin
		insert into historial values (null, null, @id_op, null, @id_prod, @cantidad, @subtotal);
	end
	else if(@operacion=3)
	begin
		insert into historial values (null, null, null, @id_op, @id_prod, @cantidad, @subtotal);
	end
end;

--Procedimiento Registrar venta
create procedure sp_venta_historial(@fec_vent date, @id_emp smallint, @iva_vent decimal(7,2), @total decimal(7,2)) as
begin 
	insert into ventas values(@fec_vent, @id_emp, @iva_vent, @total);
end;

--Procedimiento Registrar pedido
create procedure sp_pedido_historial(@id_client smallint, @fec_ped date, @id_emp smallint, @estado_ped tinyint, @tip_ped tinyint,
									@iva_comp decimal(7,2), @total decimal(7,2), @fec_ent date) as
begin 
	insert into pedidos values(@id_client, @fec_ped, @id_emp, @estado_ped, @tip_ped, @iva_comp, @total, @fec_ent);
end;

--Procedimiento Registrar compra
create procedure sp_compra_historial(@opcion smallint, @id_comp smallint, @id_prov smallint, 
									@id_emp smallint, @fec_comp date, @iva_comp decimal(7,2), @total decimal(7,2), @estado smallint) as
begin if(@opcion=0)
	begin
		insert into compras values(@id_prov, @id_emp, @fec_comp, @iva_comp, @total, @estado);
	end
	else if (@opcion=1)
	begin
		update compras set estado_compra=@estado
		where id_comp=@id_comp;
	end
end;

--Procedimiento para finalizar compra
create procedure sp_finalizar_compra (@id_compra smallint)
as
begin

    update compras set estado_compra=3 where id_comp = @id_compra;

    create table #Temp(id smallint identity(1,1), producto smallint, cantidad smallint, subtotal decimal(7,2))

    insert into #Temp 
    select  producto, cantidad, subtotal from historial
    where id_compra = @id_compra

    Update inventario set cant_prod = i.cant_prod + t.cantidad, prec_com_prod = t.subtotal/t.cantidad
    from inventario i, #Temp t 
    where codigo = t.producto 
end;

--Procedimiento para Mostrar pedidos
create procedure sp_mostrar_pedidos
as
begin
	select P.id_ped as ID, C.nom_client as Cliente, P.fec_ped as Fecha, E.nom_emp+E.appat_emp+E.apmat_emp as Empleado,
	ES.estado as Estado, T.tipo_ped as Pedido, P.iva_ped as IVA, P.total_ped as Total, P.fec_ent as Fecha_entrega	
	from pedidos P, clientes C, empleados E, cat_estados_pedidos ES, cat_tipo_pedido T
	where P.client_ped = C.id_client and P.id_emp = E.id_emp and P.estado_ped = ES.id_estado and P.tip_ped=T.id_tip_ped;
end;

--Procedimiento para mostrar detalles de un pedido
create procedure sp_mostrar_detalles_pedido(@id_pedido smallint)
as
begin 
	select H.id_pedido as ID, I.nom_prod as Producto, H.cantidad, H.subtotal
	from pedidos P, historial H, inventario I
	where P.id_ped = H.id_pedido and H.producto=I.codigo and H.id_pedido=@id_pedido;

end;

--Devolver productos que no pertencen a un proveedor
create procedure sp_producto_no_proveedor (@id_prov smallint) as
begin

select p.id_prod, i.nom_prod from productos p, inventario i
where p.id_prov<>@id_prov and i.codigo = p.id_prod 
except
select p.id_prod, i.nom_prod from productos p, inventario i
    where p.id_prov=@id_prov and i.codigo = p.id_prod;
end;

--Agregar un nuevo producto a un proveedor
create procedure sp_producto_con_proveedor (@id_prod smallint, @id_prov smallint) as
begin
    insert into productos values (@id_prod,@id_prov)
end;

--Procedimiento mostrar estados de pedido
create procedure sp_mostrar_estados
as
begin
	select id_estado, estado
	from cat_estados_pedidos;
end;

--Procedimiento para actualizar estado de pedido
create procedure sp_manejar_estados_pedidos(@id_pedido smallint, @id_estado smallint)
as
begin
	if(@id_estado = 2 or @id_estado = 4)
	begin
		update pedidos set estado_ped=@id_estado 
		where @id_pedido=id_ped;
	end
	else if(@id_estado = 3)
	begin
		update pedidos set estado_ped=@id_estado 
		where @id_pedido=id_ped;

		create table #Temporal(id smallint identity(1,1), producto smallint, cantidad smallint)

		insert into #Temporal
		select  producto, sum(cantidad) from historial h
		group by h.cantidad, h.producto, h.id_pedido
		having id_pedido=@id_pedido

		update inventario set cant_prod = i.cant_prod - t.cantidad
		from inventario i, #Temporal t 
		where codigo = t.producto
	end
end;

--Procedimiento para obtener todos los productos
create procedure sp_obtener_productos
as
begin
	select codigo, nom_prod, prec_ven_prod
	from inventario;
end;

--Procedimiento para obtener todos los clientes
create procedure sp_obtener_clientes
as
begin
	select id_client, nom_client
	from clientes;
end;

--Procedimiento de Mostrar ltima venta
create procedure sp_ultima_venta
as
begin
	select max(id_vent)
	from ventas
end;

--Procedimiento de Mostrar ltimo pedido
create procedure sp_ultimo_pedido
as
begin
	select max(id_ped)
	from pedidos
end;

--Procedimiento para mostrar los ingresos y egresos
create procedure sp_ingresos_egresos(@ocpion smallint)
as
begin
    if(@ocpion = 0)
    begin
        select id_ped as ID_operacion, total_ped as Total, 'Pedido' as Tipo from pedidos where estado_ped=3 and fec_ent>(select max(fecha) from caja)
		union all
		select id_vent, total_vent, 'Venta' as Tipo from ventas
    end
    if(@ocpion = 1)
    begin
        select id_comp as ID_operacion, total_comp as Total, 'Compra' as Tipo from compras where estado_compra=3 and fec_comp>(select max(fecha) from caja)
		union all
		select id_pago, total, 'Pago' as Tipo from pagos_emp
	end
end;


--Procedimiento para obtener el total de ingresos
create procedure sp_total_ingresos
as
begin
	select (select sum(total_vent) from ventas where fec_vent>(select max(fecha) from caja)) + 
	(select sum(total_ped) from pedidos	where estado_ped = 3 and fec_ent>(select max(fecha) from caja))
end;


--Procedimiento para obtener el total de egresos
create procedure sp_total_egresos
as
begin
    select (select sum(total) from pagos_emp where fecha>(select max(fecha) from caja)) + 
	(select sum(total_comp) from compras where estado_compra = 3 and fec_comp>(select max(fecha) from caja))
end;

--Procedimiento para obtener el catalogo de puestos
create procedure sp_mostrar_puestos
as
begin
    select id_puesto, pues_puesto, suel_puesto
    from cat_puestos
end;

--Procedimiento para obtener el catalogo de puestos
create procedure sp_actualizar_sueldo(@id_puesto smallint, @suel_puesto decimal(7,2))
as
begin
    update cat_puestos set suel_puesto = @suel_puesto
    where id_puesto = @id_puesto;
end;


--Procedimiento para quitar ventas del inventario
create procedure sp_quitar_ventas (@id_venta smallint)
as
begin
		create table #Tempora(id smallint identity(1,1), producto smallint, cantidad smallint)

		insert into #Tempora
		select  producto, sum(cantidad) from historial h
		group by h.cantidad, h.producto, h.id_venta
		having id_venta=@id_venta

		update inventario set cant_prod = i.cant_prod - t.cantidad
		from inventario i, #Tempora t 
		where codigo = t.producto
end;

--Procedimiento para agregar pago a empleados al historial
create procedure sp_pagar_empleados
as
begin
	insert into pagos_emp values (getdate(), (select sum(C.suel_puesto) from cat_puestos C, empleados E where C.id_puesto = E.pues_emp));
	insert into historial values ((select max(id_pago) from pagos_emp), null, null, null, null, null, (select sum(C.suel_puesto) from cat_puestos C, empleados E where C.id_puesto = E.pues_emp))
end;

--Procedimiento para mostrar pagos a empleados
create procedure sp_mostrar_pagos_empleados
as
begin
	select id_pago as ID, fecha as Fecha, total as Total
	from pagos_emp;
end;

--Mostrar la mayor compra
create procedure sp_compra_mas
as
begin
        select  top 1 c.nom_client as ID, sum(total_ped) as Total from pedidos, clientes c
        group by client_ped ,estado_ped, id_client, nom_client
        having estado_ped=3 and id_client = client_ped
        order by Total desc
end;

--Procedimiento para hacer corte
create procedure sp_ingresar_corte(@ingresos decimal(7,2), @egresos decimal(7,2), @saldo decimal(7,2), @id_emp smallint)
as
begin
	insert into corte values(@ingresos, @egresos, GETDATE(), @saldo);
	insert into caja values(
							(select saldo_final from caja where id_caja=(select max(id_caja) from caja)),
							@saldo, (select saldo_final from caja where id_caja=(select max(id_caja) from caja))-@saldo, @id_emp, getdate());
end;

--Procedimiento para mostrar valor en caja
create procedure sp_saldo_caja
as
begin
	select saldo_inicial from caja where id_caja=(select max(id_caja) from caja)
end;
-----------------------------------------------Agregar datos a base de datos-----------------------------------
--Agregar empleados
insert into empleados values('Adan', 'Hernandez', 'Lozada', 'H', '14-07-1998', '5520408438', '5520408438', 'HELA980724HDF', 1, 'Milpa Alta',
							'Morelos', '12400', null, '168', 1);
insert into empleados values('Pedro', 'Navajo', 'Perez', 'H', '14-07-1998', '5520408438', '5520408438', 'HELA980724HDF', 2, 'Xochimilco',
							'Hidalg', '15400', null, '45', 1);

--Agregar cuenta (Nombre, contrasea, clave)
exec sp_Clave_encript 'Adan','123','hola';
exec sp_Clave_encript 'Pedro','pedro','hola';

--Agregar caja caja(inicial, corte, final, empleado, fecha)
insert into caja values (20000, 0, 20000, 1, '01-01-2021');


--Agregar corte corte(ingresos, egresos, fecha, saldo de corte)
insert into corte values (1000, 1000, GETDATE(), 0);

--Agregar clientes (Nombre, calle, # interior, # exterior, telefono)
insert into clientes values('Pedro Ramirez', 'Hidalgo', '2', '1', '5520413698');
insert into clientes values('Juan Ramirez', 'LaCalle', '45', '10', '5578946231');

--Agregar inventario (codigo, producto, p. compra, p, venta, ,caducidad, cantidad)
insert into inventario values(1234,'Fanta 600ml', 0.0, 0.0, '20-01-2021', 0);
insert into inventario values(2345,'Sprite 600ml', 0.0, 0.0, '01-01-2022', 0);
insert into inventario values(3456,'Coca cola light 600ml', 0.0, 0.0, '01-01-2022', 0);
insert into inventario values(4567,'Paquetaxo 100gr', 0.0, 0.0, '01-01-2022', 0);
insert into inventario values(5678,'Doritos 100gr', 0.0, 0.0, '01-01-2022', 0);
insert into inventario values(6789,'Chiclepaleta 10gr', 0.0, 0.0, '01-01-2022', 0);
insert into inventario values(1478,'Chiclosoide 5gr', 0.0, 0.0, '01-01-2022', 0);

--Agregar proveedores (Proveedor, municipio, calle, codigo postal, numero, telefono, rfc, representante)
insert into proveedores values('Coca cola', 'Zapata', 'Hidalgo', '12400', '155', '5598675432', 'RTESG123SR463', 'Juana Martinez');
insert into proveedores values('Sabritas', 'Jalapa', 'Ixtapa', '52420', '14', '5584756231', 'YTSH36EG45HMN', 'Roberto Juarez');
insert into proveedores values('Sonrix', 'Chatumal', 'Josefa Ortiz', '28400', '2', '5565859732', 'BSFTRS45TY342', 'Gabriel Perez');

--Agregar productos/proveedores (id producto, id proveedor)
insert into productos values(1234,1);
insert into productos values(2345,1);
insert into productos values(3456,1);
insert into productos values(1478,3);
insert into productos values(6789,3);
insert into productos values(4567,2);
insert into productos values(5678,2);


--Agregar compras (id proveedor, id empleado, fecha de compra, iva, total, estado de compra)
insert into compras values(1,1, getdate(), 320.00 , 2100.00, 1);
insert into compras values(2,1, getdate(), 128.00 , 800.00, 1);
insert into compras values(3,1, getdate(), 81.60 , 510.00, 1);

--Agregar pedido pedidos(id cliente, fecha de pedido, id empleado, estado del pedido, tipo de pedido, iva, total, fecha de entrega)
insert into pedidos values(1, getdate(), 1, 1, 1, 16.00 ,100.00, '30-11-2021');

--Agregar ventas ventas(fecha de venta, id empleado, iva, total)
insert into ventas values(GETDATE(), 1, 16.00, 100.00);

--Agregar pago a empleados pagos_emp(fecha de pago, total)
insert into pagos_emp values ('15-01-2021', 14000.00);

--Agregar a historial (id pago emp, id pedido, id compra, id venta, producto, cantidad, subtotal)
insert into historial values(null, null, 1, null, 1234, 10, 700.00);
insert into historial values(null, null, 1, null, 2345, 10, 700.00);
insert into historial values(null, null, 1, null, 3456, 10, 700.00);
insert into historial values(null, null, 2, null, 4567, 40, 400.00);
insert into historial values(null, null, 2, null, 5678, 40, 400.00);
insert into historial values(null, null, 3, null, 1478, 40, 205.00);
insert into historial values(null, null, 3, null, 6789, 60, 305.00);
insert into historial values(null, 1, null, null, 6789, 2, 50.00);
insert into historial values(null, 1, null, null, 1478, 2, 50.00);
insert into historial values(null, null, null, 1, 2345, 2, 50.00);
insert into historial values(null, null, null, 1, 1234, 2, 50.00);
insert into historial values(1, null, null, null, null, null, 1400.00);


-----------------------------------------------------------------------Seleccin de tablas----------------------------------------
--Seleccin de calatogos
select * from cat_estados_pedidos;
select * from cat_estatus_emp;
select * from cat_impuestos;
select * from cat_puestos;
select * from cat_tipo_pedido;

--Seleccion de tablas
select * from caja;
select * from clientes;
select * from compras;
select * from corte;
select * from cuentas;
select * from empleados;
select * from historial;
select * from inventario;
select * from pagos_emp;
select * from pedidos;
select * from productos;
select * from proveedores;
select * from ventas;