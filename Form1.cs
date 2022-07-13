using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsA4_13ConBd
{
    public partial class Form1 : Form
    {
        
        accesoDatos oBD;
        List<Persona> personas;
        bool nuevo;
        
        
        public Form1()
        {
            InitializeComponent();
            oBD = new accesoDatos();
            personas = new List<Persona>();
            bool nuevo = false;
            int cantidadPersonas = 0;
        }
        

        private void habilitar(bool x)
        {
            TxtNombre.Enabled = x;
            TxtApellido.Enabled = x;
            TxtDocumento.Enabled = x;
            CboEstadoCivil.Enabled = x;
            CboTipoDocumento.Enabled = x;
            RbtFemenino.Enabled = x;
            RbtMasculio.Enabled = x;
            ChkFallecido.Enabled = x;
            BtnCancelar.Enabled = x;
            BtnGrabar.Enabled = x;
            BtnSalir.Enabled = !x;
            BtnEditar.Enabled = !x;
            BtnBorrar.Enabled = !x;
            BtnNuevo.Enabled = !x;
            LstPersonas.Enabled = !x;
          

        }

        private void limpiar()
        {
            TxtApellido.Text = "";
            TxtNombre.Text = "";
            TxtDocumento.Text = "";
            CboEstadoCivil.SelectedIndex = -1;
            CboTipoDocumento.SelectedIndex = -1;
            RbtFemenino.Checked = false;
            RbtMasculio.Checked = false;
            ChkFallecido.Checked = false;


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(true);
            TxtApellido.Focus();
            nuevo = true;

        }

        private void LblFallecido_Click(object sender, EventArgs e)
        {

        }

        private void LblSexo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            habilitar(false);
            LstPersonas.Focus();
            cargarCombo();
            cargarLista();
            limpiar();


        }
        private void cargarCombo()
        {


            //conexion.Open();
            //comando.Connection = conexion;
            //comando.CommandType = CommandType.Text;
            //comando.CommandText = "SELECT * FROM Estados_Civiles";

            //DataTable tabla = new DataTable();
            //tabla.Load(comando.ExecuteReader());
            //conexion.Close();
            DataTable tabla = oBD.consultarBd("SELECT * FROM Estados_Civiles");
            CboEstadoCivil.DataSource = tabla;
            CboEstadoCivil.DisplayMember = "estado_civil";
            CboEstadoCivil.ValueMember = "id_estado_civil";


            //conexion.Open();
            //comando.Connection = conexion;
            //comando.CommandType = CommandType.Text;
            //comando.CommandText = "SELECT * FROM Tipos_Documentos";.
            //DataTable tabla1 = new DataTable();
            //tabla1.Load(comando.ExecuteReader());
            //conexion.Close();
            DataTable tabla1 = oBD.consultarBd("SELECT * FROM Tipos_Documentos");

            CboTipoDocumento.DataSource = tabla1;
            CboTipoDocumento.DisplayMember = "tipo_documeto";
            CboTipoDocumento.ValueMember = "id_tipo_documento";



            limpiar();


        }
        private void cargarLista()
        {
            personas.Clear();
            LstPersonas.Items.Clear();
            DataTable tabla = oBD.consultarBd("SELECT * FROM Personas");
            foreach (DataRow fila in tabla.Rows)
            {
                Persona p = new Persona();
                p.pApellido = fila["apellido"].ToString();
                p.pNombres = fila["nombre"].ToString();
                p.pTipoDocumento = int.Parse(fila["id_tipo_documento"].ToString());
                p.pDocumento = int.Parse(fila["documento"].ToString());
                p.pEstadoCivil = int.Parse(fila["id_estado_civil"].ToString());
                p.pSexo = int.Parse(fila["sexo"].ToString());
                p.pFallecio = Convert.ToBoolean(fila["fallecido"]);
                personas.Add(p);
                LstPersonas.Items.Add(p.ToString());
            }
    
        }

      
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int index = LstPersonas.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Debe seleccioar una persona para editar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                habilitar(true);
                LstPersonas.Enabled = false;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int index = LstPersonas.SelectedIndex;
            
            if(index < 0)
            {

                MessageBox.Show("Debe seleccioar la persona que desea eliminar", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Esta seguro que desea elimiar?", "ABM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    personas[index] = null;
                    LstPersonas.Items.RemoveAt(index);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            limpiar();
            habilitar(false);
            LstPersonas.Focus();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del programa?", "ABM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                //crear objeto
                Persona p = new Persona();
                p.pApellido = TxtApellido.Text;
                p.pNombres = TxtNombre.Text;
                p.pTipoDocumento = Convert.ToInt32(CboTipoDocumento.SelectedValue);
                p.pDocumento = Convert.ToInt32(TxtDocumento.Text);
                p.pEstadoCivil = Convert.ToInt32(CboEstadoCivil.SelectedValue);
                if (RbtMasculio.Checked)
                    p.pSexo = 2;
                else
                    p.pSexo = 1;
                p.pFallecio = ChkFallecido.Checked;
                //valida datos...
                if (nuevo)
                {
                   

                    if (!existe(p))
                    {
                        //insert con SQL tradicional
                        string insertSQL = "INSERT INTO Personas VALUES ('" +
                        p.pApellido + "', '" +
                        p.pNombres + "', " +
                        p.pTipoDocumento + "," +
                        p.pEstadoCivil + "," +
                        p.pSexo + "," + 
                        Convert.ToInt32(p.pFallecio)+ "," +
                        p.pDocumento + ")";

                        if (oBD.actualizarBd(insertSQL) > 0)
                        {
                            MessageBox.Show("Se insertó con éxito una nueva persona!!!");
                            cargarLista();
                        }

                    }
                    else
                    {
                        MessageBox.Show("La persona ya existe!!!");
                    }
                    habilitar(false);
                    limpiar();
                    nuevo= false;
                }
                else
                {
                    string updateSQL = "UPDATE Personas Set apellido ='" +
                        p.pApellido + "', nombre ='" +
                        p.pNombres + "', id_estado_civil =" +
                        p.pEstadoCivil + ", sexo =" +
                        p.pSexo + ", fallecido =" +
                        Convert.ToInt32(p.pFallecio);

                    if (oBD.actualizarBd(updateSQL) > 0)
                    {
                        MessageBox.Show("Se modificó con éxito una nueva persona!!!");
                        cargarLista();
                    }
                    habilitar(false);
                    limpiar();
                   
                }
            }

        }

        private bool existe(Persona nueva)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].pDocumento == nueva.pDocumento)
                    return true;
            }
            return false;
        }

        private bool validarDatos()
        {
            if (TxtApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un apellido...");
                TxtApellido.Focus();
                return false;
            }

            if (TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre...");
                TxtNombre.Focus();
                return false;
            }

            if (CboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento...");
                CboTipoDocumento.Focus();
                return false;
            }

            if (TxtDocumento.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un documento...");
                TxtDocumento.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(TxtDocumento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar únicamente valores numéricos...");
                    TxtDocumento.Focus();
                    return false;
                }
            }

            if (CboEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado civil...");
                CboEstadoCivil.Focus();
                return false;
            }

            if (!RbtFemenino.Checked && !RbtMasculio.Checked)
            {
                MessageBox.Show("Debe seleccionar un sexo...");
                RbtFemenino.Focus();
                return false;
            }

            return true;
        }
    }
}
