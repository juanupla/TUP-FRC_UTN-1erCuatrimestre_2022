using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2App2
{
    public partial class frmPlantas : Form
    {
        accesoDatos oBD;
        List<Plantas> plantas;
        public frmPlantas()
        {
            InitializeComponent();
            oBD = new accesoDatos();
            plantas = new List<Plantas>();
        }

        private void frmPlantas_Load(object sender, EventArgs e)
        {
            Habilitar(false);

            cargarCombo();
            cargarLista();
            limpiar();

        }
        
        private void Habilitar(bool x)
        {
            txtCodigo.Enabled = x;
            txtNombre.Enabled = x;
            txtPrecio.Enabled = x;
            cboEspecie.Enabled = x;
            dtpFecha.Enabled = x;
            btnEditar.Enabled = !x;
            btnSalir.Enabled = !x;
            btnGuardar.Enabled = x;

        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cboEspecie.SelectedIndex = -1;
            dtpFecha.Checked = false;
        }
        public void cargarCombo()
        {
            DataTable tabla = oBD.consultarBD("SELECT * FROM Especies");
            cboEspecie.DataSource = tabla;
            cboEspecie.DisplayMember = "nombreEspecie";
            cboEspecie.ValueMember = "idEspecie";
        }

        public void cargarLista()
        {
            plantas.Clear();
            lstPlantas.Items.Clear();
            DataTable tabla = oBD.consultarBD("SELECT * FROM Plantas");
            foreach (DataRow i in tabla.Rows)
            {
                Plantas p = new Plantas();
                p.pCodigo = Convert.ToInt32(i["codigo"].ToString());
                p.pNombre = i["nombre"].ToString();
                p.pEspecie = Convert.ToInt32(i["especie"].ToString());
                p.pPrecio = float.Parse(i["precio"].ToString());
                p.pFecha = Convert.ToDateTime( i["fecha"].ToString());

                plantas.Add(p);
                lstPlantas.Items.Add(p);
            }
            

        }

        public bool validacion()
        {
            
            if(txtCodigo.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Codigo");
                txtCodigo.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCodigo.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar datos numéricos");
                    txtCodigo.Focus();
                    return false;
                }
            }
            if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre");
                txtNombre.Focus();
                return false;
            }
            if(txtPrecio.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Precio");
                txtPrecio.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtPrecio.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar datos numéricos");
                    txtPrecio.Focus();
                    return false;
                }
            }
            if(cboEspecie.SelectedIndex < 0) {
                MessageBox.Show("Debe seleccionar una especie");
                cboEspecie.Focus();
                return false;
            }
            if(dtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser menor a la actual");
                dtpFecha.Focus();
                return false;
            }
            return true;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstPlantas.SelectedIndex >= 0)
            {
                Habilitar(true);
                btnEditar.Enabled = true;
                txtCodigo.Enabled = false;
                btnSalir.Enabled = true;

                //al seleccionar editar, los campos deben permitir actualizar su contenido y habilita el boton guardar
            }
            else
            {
                MessageBox.Show("debe seleccionar una planta");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                Plantas p = new Plantas();
                p.pCodigo = Convert.ToInt32(txtCodigo.Text);
                p.pNombre = txtNombre.Text;
                p.pEspecie = Convert.ToInt32(cboEspecie.SelectedValue);
                p.pPrecio = float.Parse(txtPrecio.Text);
                p.pFecha = Convert.ToDateTime(dtpFecha.Value);

                string update = "UPDATE Plantas Set nombre='" + p.pNombre + "', especie=" + p.pEspecie + ", precio=" + p.pPrecio + ", fecha='" + p.pFecha.ToString("yyyy/MM/dd") + "' WHERE codigo=" + p.pCodigo;
                if (oBD.actualizarBD(update) > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                    cargarLista();
                }
                limpiar();
                Habilitar(false);
                //validar los campos
                //Fecha no puede ser posterior a la acutal
                //emite mensaje de exito
                //Actualiza lista
                //deshabilita boton guardar
            }






        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?","Vivero",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void lstPlantas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //al seleccionar un elemento de la lista, se deberan mostrar todos sus datos
            limpiar();
            int posicion;
            posicion = lstPlantas.SelectedIndex;
            if (posicion >= 0) {
                txtCodigo.Text = Convert.ToString(plantas[posicion].pCodigo);
                txtNombre.Text = Convert.ToString(plantas[posicion].pNombre);
                txtPrecio.Text = Convert.ToString(plantas[posicion].pPrecio);
                cboEspecie.SelectedIndex = plantas[posicion].pEspecie;
                dtpFecha.Value = plantas[posicion].pFecha;
            }
                
        }
    }
}
