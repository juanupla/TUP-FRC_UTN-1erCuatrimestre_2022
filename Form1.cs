using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dsdsssds
namespace formsTelefoicaApp
{
    public partial class FrmTelefonica : Form
    {
        accesoDatos oBD;
        List<Telefono> Telefonos;
        public FrmTelefonica()
        {
            InitializeComponent();
            oBD = new accesoDatos();
            Telefonos = new List<Telefono>();
        }

        private void FrmTelefonica_Load(object sender, EventArgs e)
        {
            habilitar(false);
            LstTelefonos.Enabled=false;
           

            DataTable tabla = oBD.consultarBD("SELECT * FROM Marcas");
            CboMarca.DataSource=tabla;
            CboMarca.DisplayMember = "nombreMarca";
            CboMarca.ValueMember = "idMarca";
            CboMarca.SelectedIndex = -1;

            CargarLista();
        }

        public void CargarLista()
        {
            //cargar lista
            Telefonos.Clear();
            LstTelefonos.Items.Clear();
            DataTable tabla1 = oBD.consultarBD("SELECT * FROM Telefonos");
            foreach (DataRow fila in tabla1.Rows)
            {
                Telefono p = new Telefono();
                p.pMarca = Convert.ToInt32(fila["marca"].ToString());
                p.pNombre = fila["nombre"].ToString();
                p.pCodigo = Convert.ToInt32(fila["codigo"].ToString());
                p.pPrecio = float.Parse(fila["precio"].ToString());

                Telefonos.Add(p);
                LstTelefonos.Items.Add(p.ToString());

            }
        }

        public void habilitar(bool x)
        {
            TxtCodigo.Enabled = x;
            TxtNombre.Enabled = x;
            TxtPrecio.Enabled = x;
            CboMarca.Enabled = x;
            BtnNuevo.Enabled = !x;
            BtnGuardar.Enabled = x;
            BtnSalir.Enabled = !x;
            btnCancelar.Enabled = x;

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("seguro desea abandonar la aplicacio?","Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
    
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Telefono t = new Telefono();
                t.pMarca = Convert.ToInt32(CboMarca.SelectedIndex);
                t.pNombre = TxtNombre.Text;
                t.pPrecio = float.Parse(TxtPrecio.Text);
                t.pCodigo = Convert.ToInt32(TxtCodigo.Text);
                string insert = "INSERT INTO Telefonos Values(" + t.pCodigo + ",'" + t.pNombre + "'," + t.pMarca + "," + t.pPrecio + ")";
                if (oBD.actualizarBD(insert) > 0)
                {
                    MessageBox.Show("Se cargo un telefono correctamente");
                    CargarLista(); 
                }

                limpiar();
            }
        }

        public bool validar()
        {
            if(TxtCodigo.Text == "")
            {
                MessageBox.Show("Debe igresar un Código","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodigo.Focus();
                return false;

            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtCodigo.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El campo Código requiere de datos numéricos","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCodigo.Focus();
                    return false;
                    
                }
            }
            if(TxtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();
                return false;
            }
            if (CboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar una marca", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboMarca.Focus();
                return false;
            }
            if(TxtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPrecio.Focus();
                return false;
            }
            else
            {
                try
                {
                    float.Parse(TxtPrecio.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El campo Precio requiere de datos numéricos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtPrecio.Focus();
                    return false;
                }
            }
            return true;
        }

        public void limpiar()
        {
            TxtCodigo.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtPrecio.Text = string.Empty;
            CboMarca.SelectedIndex = -1;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            limpiar();
        }
    }
}
