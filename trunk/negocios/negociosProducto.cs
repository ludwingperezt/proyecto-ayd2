using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace negocios
{
    /// <summary>
    /// Clase para el manejo de productos, metadatos, no detalles de facturas (lotes)
    /// </summary>
    public class negociosProducto
    {
        private int liIdProducto;
        private string lsNombre;
        private string lsCodigo;
        private double lduCantidad;
        private decimal ldecPrecioCompra;
        private decimal ldecPrecioVenta;
        private string lsColor;
        private bool lboActivo;

        #region constructores
        /// <summary>
        /// Constructor por defecto del objeto negociosProducto
        /// </summary>
        public negociosProducto()
        { 
        }
        /// <summary>
        /// Constructor sobrecargado del objeto negociosProducto
        /// </summary>
        /// <param name="liIdProducto">int: id del producto</param>
        /// <param name="lsNombre">string: nombre del producto</param>
        /// <param name="lsCodigo">string: código del producto</param>
        /// <param name="lduStock">double: cantidad disponible del producto</param>
        /// <param name="ldecPrecioCompra">decimal: precio de compra del producto</param>
        /// <param name="ldecPrecioVenta">decimal: precio de venta del producto</param>
        /// <param name="lsColor">string: color del producto</param>
        /// <param name="lboActivo">bool: campo que indica si el producto está activo en la base de datos o fue eliminado</param>
        public negociosProducto(int liIdProducto, string lsNombre, string lsCodigo, double lduStock, decimal ldecPrecioCompra, decimal ldecPrecioVenta, string lsColor, bool lboActivo)
        {
            this.liIdProducto = liIdProducto;
            this.lsCodigo = lsCodigo;
            this.lsNombre = lsNombre;
            this.lduCantidad = lduStock;
            this.ldecPrecioCompra = ldecPrecioCompra;
            this.ldecPrecioVenta = ldecPrecioVenta;
            this.lsColor = lsColor;
            this.lboActivo = lboActivo;
        }
        #endregion
        #region métodos accesores y modificadores
        /// <summary>
        /// Método que accede al Id del producto
        /// </summary>
        /// <returns>int: el ID del producto</returns>
        public int getIdProducto()
        {
            return this.liIdProducto;
        }
        /// <summary>
        /// Método que accede al Nombre del producto
        /// </summary>
        /// <returns>string: el nombre del producto</returns>
        public string getNombre()
        {
            return this.lsNombre;
        }
        /// <summary>
        /// Método que accede al Codigo del producto
        /// </summary>
        /// <returns>string: el código del producto</returns>
        public string getCodigo()
        {
            return this.lsCodigo;
        }
        /// <summary>
        /// Método que accede a la cantidad almacenada del producto en bodega
        /// </summary>
        /// <returns>double: la cantidad existente del producto en bodega</returns>
        public double getStock()
        {
            return this.lduCantidad;
        }
        /// <summary>
        /// Método que accede al ultimo precio de compra de un producto
        /// </summary>
        /// <returns>decimal: el precio de compra de un producto</returns>
        public decimal getPrecioCompra()
        {
            return this.ldecPrecioCompra;
        }
        /// <summary>
        /// Método que accede al precio de venta de un producto
        /// </summary>
        /// <returns>decimal: el precio de venta de un producto</returns>
        public decimal getPrecioVenta()
        {
            return this.ldecPrecioVenta;
        }
        /// <summary>
        /// Método que accede al color de un producto
        /// </summary>
        /// <returns>string: color del producto</returns>
        public string getColor()
        {
            return this.lsColor;
        }
        /// <summary>
        /// Método que accede al campo de activado o desactivado de un producto
        /// </summary>
        /// <returns>bool: True si el producto está activo en la base de datos, False si fue eliminado</returns>
        public bool getActivo()
        {
            return this.lboActivo;
        }
        /// <summary>
        /// Método modificador del campo ID de un producto
        /// </summary>
        /// <param name="liIdProducto">int: el nuevo ID del producto</param>
        public void setIdProducto(int liIdProducto)
        {
            this.liIdProducto = liIdProducto;
        }
        /// <summary>
        /// Método modificador del campo Nombre del producto
        /// </summary>
        /// <param name="lsNombre">string: el nuevo nombre del producto</param>
        public void setNombre(string lsNombre)
        {
            this.lsNombre = lsNombre;
        }
        /// <summary>
        /// Método modificador del campo Código del producto
        /// </summary>
        /// <param name="lsCodigo">string: el nuevo código del producto</param>
        public void setCodigo(string lsCodigo)
        {
            this.lsCodigo = lsCodigo;
        }
        /// <summary>
        /// Método modificador del campo stock del producto
        /// </summary>
        /// <param name="lduStock">double: la nueva cantidad disponible en bodega</param>
        public void setStock(double lduStock)
        {
            this.lduCantidad = lduStock;
        }
        /// <summary>
        /// Método modificador del campo de precio de venta del producto
        /// </summary>
        /// <param name="ldecPrecioVenta">decimal: el nuevo precio de venta del producto</param>
        public void setPrecioVenta(decimal ldecPrecioVenta)
        {
            this.ldecPrecioVenta = ldecPrecioVenta;
        }
        /// <summary>
        /// Método modificador del campo de precio de compra del producto
        /// </summary>
        /// <param name="ldecPrecioCompra">decimal: el nuevo precio de compra del producto</param>
        public void setPrecioCompra(decimal ldecPrecioCompra)
        {
            this.ldecPrecioCompra = ldecPrecioCompra;
        }
        /// <summary>
        /// Método modificador del campo color del producto
        /// </summary>
        /// <param name="lsColor">string: el nuevo color del producto</param>
        public void setColor(string lsColor)
        {
            this.lsColor = lsColor;
        }
        /// <summary>
        /// Método modificador del campo de activación/desactivación del producto
        /// </summary>
        /// <param name="lboActivo">bool: True para activar el producto en la base de datos, False para eliminarlo</param>
        public void setActivo(bool lboActivo)
        {
            this.lboActivo = lboActivo;
        }
        #endregion
        #region Métodos de comunicación con la base de datos
        /// <summary>
        /// Método que inserta un nuevo producto a la base de datos. Éste método solo inserta la descripción del producto, no los detalles de compras o ventas, es decir que no se debe utilizar este método para la actualización de existencias, para ello utilice los métodos aumentarExistenciaProducto y disminuirExistenciaProducto.
        /// Los datos que se envían a la base de datos son los que se encuentran contenidos actualmente en éste objeto.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsInsertarDescripcionProducto()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.insertarProducto(this.lsCodigo, this.lsNombre, this.lduCantidad, this.ldecPrecioCompra, this.ldecPrecioVenta, this.lsColor);
                return "La inserción del producto en la base de datos se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        /// <summary>
        /// Método que inserta un nuevo producto a la base de datos. Éste método solo inserta la descripción del producto, no los detalles de compras o ventas, es decir que no se debe utilizar este método para la actualización de existencias, para ello utilice los métodos aumentarExistenciaProducto y disminuirExistenciaProducto.
        /// Los datos que se envían a la base de datos son los que se encuentran contenidos actualmente en éste objeto.
        /// </summary>
        public void fnvdInsertarDescripcionProducto()
        {           
                negociosAdaptadores.gAdaptadorDeConsultas.insertarProducto(this.lsCodigo, this.lsNombre, this.lduCantidad, this.ldecPrecioCompra, this.ldecPrecioVenta, this.lsColor);
        }
        /// <summary>
        /// Método que modifica la descripción de un producto. Los datos que se utilizan para la modificación son los que se encuentran almacenados en el objeto actual.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsModificarDescripcionProducto()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarProducto((short)this.liIdProducto, this.lsCodigo, this.lsNombre, this.lduCantidad, this.ldecPrecioCompra, this.ldecPrecioVenta, this.lsColor);
                return "La modificación de los datos del producto se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Método que modifica la descripción de un producto. Los datos que se utilizan para la modificación son los que se encuentran almacenados en el objeto actual.
        /// </summary>
        public void fnvdModificarDescripcionProducto()
        {
                negociosAdaptadores.gAdaptadorDeConsultas.modificarProducto((short)this.liIdProducto, this.lsCodigo, this.lsNombre, this.lduCantidad, this.ldecPrecioCompra, this.ldecPrecioVenta, this.lsColor);
        }
        /// <summary>
        /// Método que elimina un producto de la base de datos. Éste producto seguirá apareciendo en el historial de la base de datos pero no estará disponible para futuras consultas.
        /// </summary>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsEliminarProducto()
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.eliminarProducto((short)this.liIdProducto);
                return "La eliminación del producto en la base de datos se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Método que elimina un producto de la base de datos. Éste producto seguirá apareciendo en el historial de la base de datos pero no estará disponible para futuras consultas.
        /// </summary>
        public void fnvdEliminarProducto()
        {
                negociosAdaptadores.gAdaptadorDeConsultas.eliminarProducto((short)this.liIdProducto);
        }
        /// <summary>
        /// Método que aumenta la existencia del producto que representa éste objeto en la cantidad específicada.
        /// </summary>
        /// <param name="cantidad">double: cantidad que se desea agregar a la cantidad actual de producto en bodega</param>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsAumentarExistenciaProducto(double cantidad)
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.aumentarStockProducto((short)this.liIdProducto, cantidad);
                return "La operación de actualización de existencia se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Método que aumenta la existencia del producto que representa éste objeto en la cantidad específicada.
        /// </summary>
        /// <param name="cantidad">double: cantidad que se desea agregar a la cantidad actual de producto en bodega</param>
        public void fnvdAumentarExistenciaProducto(double cantidad)
        {
                negociosAdaptadores.gAdaptadorDeConsultas.aumentarStockProducto((short)this.liIdProducto, cantidad);
        }
        /// <summary>
        /// Método que disminuye la existencia del producto que representa éste objeto en la cantidad específicada.
        /// </summary>
        /// <param name="cantidad">double: cantidad que se desea disminuir a la cantidad actual de producto en bodega</param>
        /// <returns>string: mensaje de confirmación o error de la operación</returns>
        public string fnsDisminuirExistenciaProducto(double cantidad)
        {
            try
            {
                negociosAdaptadores.gAdaptadorDeConsultas.disminuirStockProducto((short)this.liIdProducto, cantidad);
                return "La operación de actualización de existencia se llevó a cabo con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Método que disminuye la existencia del producto que representa éste objeto en la cantidad específicada.
        /// </summary>
        /// <param name="cantidad">double: cantidad que se desea disminuir a la cantidad actual de producto en bodega</param>
        public void fnvdDisminuirExistenciaProducto(double cantidad)
        {
                negociosAdaptadores.gAdaptadorDeConsultas.disminuirStockProducto((short)this.liIdProducto, cantidad);
        }
        /// <summary>
        /// Función que verifica las existencias de éste producto en bodega para cubrir el pedido especificado.
        /// </summary>
        /// <param name="cantidad">double: cantidad con la cual se desea comparar la existencia del producto (cantidad solicitada en un pedido)</param>
        /// <returns>bool: True si la cantidad de producto almacenada en bodega es mayor o igual a la cantidad pedida especificada como parámetro; False si no hay suficiente producto</returns>
        public bool fnboVerificarCantidadExistenteProducto(double cantidad)
        {
            return (bool)negociosAdaptadores.gAdaptadorDeConsultas.verificarExistencia((short)this.liIdProducto, cantidad);
        }
        
        #endregion
        #region accesos estáticos
        /// <summary>
        /// Función de acceso estático. Verifica si la cantidad existente en bodega de un producto especificado está disponible para cubrir la cantidad solicitada.
        /// </summary>
        /// <param name="liIdProducto">short: id del producto solicitado</param>
        /// <param name="cantidad">double: cantidad solicitada del producto</param>
        /// <returns>bool: True si hay existencias del producto, False si no hay existencias</returns>
        public static bool fnboVerificarCantidadExistenteProducto(short liIdProducto, double cantidad)
        {
            return (bool)negociosAdaptadores.gAdaptadorDeConsultas.verificarExistencia(liIdProducto, cantidad);
        }
        /// <summary>
        /// Función de acceso estático. Disminuye la cantidad en bodega del producto especificado.
        /// </summary>
        /// <param name="lshIdProducto">shor: el ID del producto</param>
        /// <param name="cantidad">double: cantidad que se desea disminuir del stock en bodega</param>
        public static void fnvdDisminuirExistenciaProducto(short lshIdProducto ,double cantidad)
        {
            negociosAdaptadores.gAdaptadorDeConsultas.disminuirStockProducto(lshIdProducto, cantidad);
        }
        /// <summary>
        /// Función de acceso estático. Aumenta la cantidad en bodega del producto espercificado
        /// </summary>
        /// <param name="lshIdProducto">short: Id del producto</param>
        /// <param name="cantidad">double: cantidad que se desea aumentar del stock en bodega</param>
        public static void fnvdAumentarExistenciaProducto(short lshIdProducto,double cantidad)
        {
            negociosAdaptadores.gAdaptadorDeConsultas.aumentarStockProducto(lshIdProducto, cantidad);
        }
        /// <summary>
        /// Función que muestra todos los productos disponibles en la base de datos.
        /// </summary>
        /// <returns>DataTable: lista de los productos activos en la base de datos.</returns>
        public static DataTable fnDTlistarProductos()
        {
            return negociosAdaptadores.gAdaptadorListaProductos.GetData();
        }
        /// <summary>
        /// Funcion que devuelve la lista completa de productos en la base de datos
        /// </summary>
        /// <returns>List: lista de los productos</returns>
        public static List<negociosProducto> fnlstListarProductos()
        {
            List<negociosProducto> llstNegociosProductos = new List<negociosProducto>();
            DataTable ldtProductos = negociosProducto.fnDTlistarProductos();
            object[] elementos;
            for (int i = 0; i < ldtProductos.Rows.Count; i++)
            {
                elementos = ldtProductos.Rows[i].ItemArray;
                negociosProducto localProducto = new negociosProducto();
                localProducto.setIdProducto(Convert.ToInt32(elementos[0]));
                localProducto.setCodigo(Convert.ToString(elementos[1]));
                localProducto.setNombre(Convert.ToString(elementos[2]));
                localProducto.setStock(Convert.ToDouble(elementos[3]));
                localProducto.setPrecioCompra(Convert.ToDecimal(elementos[4]));
                localProducto.setPrecioVenta(Convert.ToDecimal(elementos[5]));
                localProducto.setColor(Convert.ToString(elementos[6]));
                llstNegociosProductos.Add(localProducto);
            }
            return llstNegociosProductos;
        }

        public static List<negociosProducto> fnPaginacionProductos(int liSizePagina, int liNumeroPagina)
        {
            return negociosProducto.construirLista(negociosAdaptadores.gAdaptadorPaginacionProductos.GetData(liSizePagina, liNumeroPagina));
        }
        public static List<negociosProducto> fnFiltrarProductosPorCodigo(string codigo)
        {
            return negociosProducto.construirLista(negociosAdaptadores.gAdaptadorProductoPorCodigo.GetData(codigo));
        }
        public static List<negociosProducto> fnFiltrarProductosPorNombre(string nombre)
        {
            return negociosProducto.construirLista(negociosAdaptadores.gAdaptadorProductoPorNombre.GetData(nombre));
        }
        public static List<negociosProducto> fnBuscarProductosPorCodigoNombre(string criterio)
        {
            return negociosProducto.construirLista(negociosAdaptadores.gAdaptadorBusquedaExactaAmbosCriterios.GetData(criterio,criterio));
        }
        public static negociosProducto fnObtenerProductoPorId(int idProducto)
        {
            List<negociosProducto> tmp = negociosProducto.construirLista(negociosAdaptadores.gAdaptadorProductoPorId.GetData((short)idProducto));
            if (tmp.Count == 0)
                return null;
            else
                return tmp[0];
        }
        public static negociosProducto fnObtenerProductoPorCodigo(string codigo)
        {
            List<negociosProducto> tmp = negociosProducto.construirLista(negociosAdaptadores.gAdaptadorObtenerProductoPorCodigo.GetData(codigo));
            if (tmp.Count == 0)
                return null;
            else
                return tmp[0];
        }
        public static negociosProducto fnObtenerProductoPorNombre(string nombre)
        {
            List<negociosProducto> tmp = negociosProducto.construirLista(negociosAdaptadores.gAdaptadorObtenerProductoPorNombre.GetData(nombre));
            if (tmp.Count == 0)
                return null;
            else
                return tmp[0];
        }
        /// <summary>
        /// Funcion que construye una lista con los elementos de un dataTable
        /// </summary>
        /// <param name="ldtProductos">DataTable: resultado de una consulta</param>
        /// <returns>list: lista de objetos de tipo negociosProducto</returns>
        protected static List<negociosProducto> construirLista(DataTable ldtProductos)
        {
            List<negociosProducto> llstNegociosProductos = new List<negociosProducto>();
            object[] elementos;
            for (int i = 0; i < ldtProductos.Rows.Count; i++)
            {
                elementos = ldtProductos.Rows[i].ItemArray;
                negociosProducto localProducto = new negociosProducto();
                localProducto.setIdProducto(Convert.ToInt32(elementos[0]));
                localProducto.setCodigo(Convert.ToString(elementos[1]));
                localProducto.setNombre(Convert.ToString(elementos[2]));
                localProducto.setStock(Convert.ToDouble(elementos[3]));
                localProducto.setPrecioCompra(Convert.ToDecimal(elementos[4]));
                localProducto.setPrecioVenta(Convert.ToDecimal(elementos[5]));
                localProducto.setColor(Convert.ToString(elementos[6]));
                llstNegociosProductos.Add(localProducto);
            }
            return llstNegociosProductos;
        }
        #endregion
    }
}
