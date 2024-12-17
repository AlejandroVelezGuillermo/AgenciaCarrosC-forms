using Microsoft.Data.SqlClient;
using System.Data;

namespace AgenciaCarrosC_Forms
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DESKTOP-ECO5SNR\SQLEXPRESS;Database=AgenciaCarros;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarAgencia_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO agencias (nombre, direccion, telefono, email) VALUES (@nombre, @direccion, @telefono, @email)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", txtNombreAgencia.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccionAgencia.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoAgencia.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailAgencia.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Agencia agregada con éxito.");
            }
        }

        private void btnCargarAgencias_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM agencias";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAgencias.DataSource = dt;
            }
        }

        private void btnActualizarAgencia_Click(object sender, EventArgs e)
        {
            string query = "UPDATE agencias SET nombre = @nombre, direccion = @direccion, telefono = @telefono, email = @email WHERE id_agencia = @id_agencia";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgencia.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombreAgencia.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccionAgencia.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoAgencia.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailAgencia.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Agencia actualizada con éxito.");
            }
        }

        private void btnEliminarAgencia_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM agencias WHERE id_agencia = @id_agencia";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgencia.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Agencia eliminada con éxito.");
            }
        }

        private void btnAgregarCarro_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO carros (modelo, marca, anio, precio, id_agencia) VALUES (@modelo, @marca, @anio, @precio, @id_agencia)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@modelo", txtModeloCarro.Text);
                cmd.Parameters.AddWithValue("@marca", txtMarcaCarro.Text);
                cmd.Parameters.AddWithValue("@anio", txtAnioCarro.Text);
                cmd.Parameters.AddWithValue("@precio", txtPrecioCarro.Text);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgenciaCarro.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Carro agregado con éxito.");
            }
        }

        private void btnCargarCarros_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM carros";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCarros.DataSource = dt;
            }
        }

        private void btnActualizarCarro_Click(object sender, EventArgs e)
        {
            string query = "UPDATE carros SET modelo = @modelo, marca = @marca, anio = @anio, precio = @precio, id_agencia = @id_agencia WHERE id_carro = @id_carro";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_carro", txtIdCarro.Text);
                cmd.Parameters.AddWithValue("@modelo", txtModeloCarro.Text);
                cmd.Parameters.AddWithValue("@marca", txtMarcaCarro.Text);
                cmd.Parameters.AddWithValue("@anio", txtAnioCarro.Text);
                cmd.Parameters.AddWithValue("@precio", txtPrecioCarro.Text);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgenciaCarro.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Carro actualizado con éxito.");
            }
        }

        private void btnEliminarCarro_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM carros WHERE id_carro = @id_carro";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_carro", txtIdCarro.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Carro eliminado con éxito.");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clientes (nombre, apellido, telefono, email, direccion) VALUES (@nombre, @apellido, @telefono, @email, @direccion)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                cmd.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailCliente.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado con éxito.");
            }
        }

        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM clientes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            string query = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, telefono = @telefono, email = @email, direccion = @direccion WHERE id_cliente = @id_cliente";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                cmd.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailCliente.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado con éxito.");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM clientes WHERE id_cliente = @id_cliente";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado con éxito.");
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ventas (id_cliente, id_carro, id_empleado, total) VALUES (@id_cliente, @id_carro, @id_empleado, @total)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", txtIdClienteVenta.Text);
                cmd.Parameters.AddWithValue("@id_carro", txtIdCarroVenta.Text);
                cmd.Parameters.AddWithValue("@id_empleado", txtIdEmpleadoVenta.Text);
                cmd.Parameters.AddWithValue("@total", txtTotalVenta.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venta agregada con éxito.");
            }
        }

        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ventas";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVentas.DataSource = dt;
            }
        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ventas SET id_cliente = @id_cliente, id_carro = @id_carro, id_empleado = @id_empleado, total = @total WHERE id_venta = @id_venta";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_venta", txtIdVenta.Text);
                cmd.Parameters.AddWithValue("@id_cliente", txtIdClienteVenta.Text);
                cmd.Parameters.AddWithValue("@id_carro", txtIdCarroVenta.Text);
                cmd.Parameters.AddWithValue("@id_empleado", txtIdEmpleadoVenta.Text);
                cmd.Parameters.AddWithValue("@total", txtTotalVenta.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venta actualizada con éxito.");
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ventas WHERE id_venta = @id_venta";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_venta", txtIdVenta.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venta eliminada con éxito.");
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO empleados (nombre, apellido, puesto, salario, id_agencia) VALUES (@nombre, @apellido, @puesto, @salario, @id_agencia)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text);
                cmd.Parameters.AddWithValue("@apellido", txtApellidoEmpleado.Text);
                cmd.Parameters.AddWithValue("@puesto", txtPuestoEmpleado.Text);
                cmd.Parameters.AddWithValue("@salario", txtSalarioEmpleado.Text);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgenciaEmpleado.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado agregado con éxito.");
            }
        }

        private void btnCargarEmpleados_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM empleados";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmpleados.DataSource = dt;
            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            string query = "UPDATE empleados SET nombre = @nombre, apellido = @apellido, puesto = @puesto, salario = @salario, id_agencia = @id_agencia WHERE id_empleado = @id_empleado";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_empleado", txtIdEmpleado.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text);
                cmd.Parameters.AddWithValue("@apellido", txtApellidoEmpleado.Text);
                cmd.Parameters.AddWithValue("@puesto", txtPuestoEmpleado.Text);
                cmd.Parameters.AddWithValue("@salario", txtSalarioEmpleado.Text);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgenciaEmpleado.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado actualizado con éxito.");
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM empleados WHERE id_empleado = @id_empleado";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_empleado", txtIdEmpleado.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado con éxito.");
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO servicios (descripcion, costo) VALUES (@descripcion, @costo)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionServicio.Text);
                cmd.Parameters.AddWithValue("@costo", txtCostoServicio.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Servicio agregado con éxito.");
            }
        }

        private void btnCargarServicios_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM servicios";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvServicios.DataSource = dt;
            }
        }

        private void btnActualizarServicio_Click(object sender, EventArgs e)
        {
            string query = "UPDATE servicios SET descripcion = @descripcion, costo = @costo WHERE id_servicio = @id_servicio";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_servicio", txtIdServicio.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionServicio.Text);
                cmd.Parameters.AddWithValue("@costo", txtCostoServicio.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Servicio actualizado con éxito.");
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM servicios WHERE id_servicio = @id_servicio";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_servicio", txtIdServicio.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Servicio eliminado con éxito.");
            }
        }

        private void btnAgregarHistorialServicio_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO historial_servicios (id_carro, id_servicio, costo) VALUES (@id_carro, @id_servicio, @costo)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_carro", txtIdCarroHistorial.Text);
                cmd.Parameters.AddWithValue("@id_servicio", txtIdServicioHistorial.Text);
                cmd.Parameters.AddWithValue("@costo", txtCostoHistorial.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Historial de servicio agregado con éxito.");
            }
        }

        private void btnCargarHistorialServicios_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM historial_servicios";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHistorialServicios.DataSource = dt;
            }
        }

        private void btnActualizarHistorialServicio_Click(object sender, EventArgs e)
        {
            string query = "UPDATE historial_servicios SET id_carro = @id_carro, id_servicio = @id_servicio, costo = @costo WHERE id_historial = @id_historial";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_historial", txtIdHistorial.Text);
                cmd.Parameters.AddWithValue("@id_carro", txtIdCarroHistorial.Text);
                cmd.Parameters.AddWithValue("@id_servicio", txtIdServicioHistorial.Text);
                cmd.Parameters.AddWithValue("@costo", txtCostoHistorial.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Historial de servicio actualizado con éxito.");
            }
        }

        private void btnEliminarHistorialServicio_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM historial_servicios WHERE id_historial = @id_historial";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_historial", txtIdHistorial.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Historial de servicio eliminado con éxito.");
            }
        }

        private void btnAgregarInventarioRepuesto_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO inventario_repuestos (id_agencia, nombre_repuesto, cantidad, precio_unitario) VALUES (@id_agencia, @nombre_repuesto, @cantidad, @precio_unitario)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgenciaInventario.Text);
                cmd.Parameters.AddWithValue("@nombre_repuesto", txtNombreRepuesto.Text);
                cmd.Parameters.AddWithValue("@cantidad", txtCantidadRepuesto.Text);
                cmd.Parameters.AddWithValue("@precio_unitario", txtPrecioUnitarioRepuesto.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Repuesto agregado al inventario con éxito.");
            }
        }

        private void btnCargarInventarioRepuestos_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM inventario_repuestos";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInventarioRepuestos.DataSource = dt;
            }
        }

        private void btnActualizarInventarioRepuesto_Click(object sender, EventArgs e)
        {
            string query = "UPDATE inventario_repuestos SET id_agencia = @id_agencia, nombre_repuesto = @nombre_repuesto, cantidad = @cantidad, precio_unitario = @precio_unitario WHERE id_inventario = @id_inventario";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_inventario", txtIdInventarioRepuesto.Text);
                cmd.Parameters.AddWithValue("@id_agencia", txtIdAgenciaInventario.Text);
                cmd.Parameters.AddWithValue("@nombre_repuesto", txtNombreRepuesto.Text);
                cmd.Parameters.AddWithValue("@cantidad", txtCantidadRepuesto.Text);
                cmd.Parameters.AddWithValue("@precio_unitario", txtPrecioUnitarioRepuesto.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inventario de repuesto actualizado con éxito.");
            }
        }

        private void btnEliminarInventarioRepuesto_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM inventario_repuestos WHERE id_inventario = @id_inventario";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_inventario", txtIdInventarioRepuesto.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Repuesto eliminado del inventario con éxito.");
            }
        }

        private void btnAgregarPedidoRepuesto_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pedidos_repuestos (id_inventario, cantidad_pedida) VALUES (@id_inventario, @cantidad_pedida)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_inventario", txtIdInventarioPedido.Text);
                cmd.Parameters.AddWithValue("@cantidad_pedida", txtCantidadPedido.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido de repuesto realizado con éxito.");
            }
        }

        private void btnCargarPedidosRepuestos_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM pedidos_repuestos";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPedidosRepuestos.DataSource = dt;
            }
        }

        private void btnActualizarPedidoRepuesto_Click(object sender, EventArgs e)
        {
            string query = "UPDATE pedidos_repuestos SET id_inventario = @id_inventario, cantidad_pedida = @cantidad_pedida WHERE id_pedido = @id_pedido";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_pedido", txtIdPedido.Text);
                cmd.Parameters.AddWithValue("@id_inventario", txtIdInventarioPedido.Text);
                cmd.Parameters.AddWithValue("@cantidad_pedida", txtCantidadPedido.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido de repuesto actualizado con éxito.");
            }
        }

        private void btnEliminarPedidoRepuesto_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM pedidos_repuestos WHERE id_pedido = @id_pedido";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_pedido", txtIdPedido.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido de repuesto eliminado con éxito.");
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO proveedores (nombre, telefono, email, direccion) VALUES (@nombre, @telefono, @email, @direccion)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", txtNombreProveedor.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoProveedor.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailProveedor.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccionProveedor.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor agregado con éxito.");
            }
        }

        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM proveedores";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProveedores.DataSource = dt;
            }
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            string query = "UPDATE proveedores SET nombre = @nombre, telefono = @telefono, email = @email, direccion = @direccion WHERE id_proveedor = @id_proveedor";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_proveedor", txtIdProveedor.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombreProveedor.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoProveedor.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailProveedor.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccionProveedor.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor actualizado con éxito.");
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM proveedores WHERE id_proveedor = @id_proveedor";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_proveedor", txtIdProveedor.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado con éxito.");
            }
        }
    }
}
