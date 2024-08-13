using CiclismoDesktopPorCodigo.Views;

namespace CiclismoDesktopPorCodigo
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosView empleadosView = new EmpleadosView();
            empleadosView.ShowDialog();
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadosView empleadosView = new EmpleadosView();
            empleadosView.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            TipoProductoView TipoProductoView = new TipoProductoView();
            TipoProductoView.ShowDialog();
        }

        private void gestionarClientesStoredProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesStoredProcedureView clientesStoredProcedure = new ClientesStoredProcedureView();
            clientesStoredProcedure.ShowDialog();
        }

        private void btnClienteSP_Click(object sender, EventArgs e)
        {
            ClientesStoredProcedureView clientesStoredProcedure = new ClientesStoredProcedureView();
            clientesStoredProcedure.ShowDialog();
        }
    }
}
