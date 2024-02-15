# Test INVENTEK 

<p align="center">
  <img src="https://i.ibb.co/N2Dh8S3/img-impresion.png" alt="muestra modulo impresión" />
</p>

## Declaración de variables y precios predeterminados
Se definen variables para los precios de diferentes productos y opciones de entrega, así como para el subtotal, impuestos y total de la factura.

## Inicialización del formulario y manejo de eventos
Se inicializa el formulario y se manejan los eventos de los botones y opciones de entrega.

## Métodos para añadir y quitar elementos de la factura
`AddItemToInvoice` agrega un elemento a la factura, mientras que `RemoveDeliveryFromInvoice` elimina opciones de entrega seleccionadas previamente.

## Cálculo del total
Se calcula el subtotal, impuestos y total de la factura, actualizando los campos correspondientes en la interfaz de usuario.

## Impresión de la factura
Cuando se presiona el botón de imprimir, se genera un documento PDF que contiene los detalles de la factura, incluidos los productos, cantidades y precios.

## Guardar y cargar transacciones
Se implementa la funcionalidad para guardar y cargar transacciones en formato XML, lo que permite al usuario guardar el estado actual de la factura y cargarlo más tarde.

## Clases de transacción
Se definen las clases `TransactionItem` y `Transaction` para representar los elementos individuales de la factura y la factura en sí misma, respectivamente.
