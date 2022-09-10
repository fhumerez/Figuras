namespace Figuras
{
    public partial class Form1 : Form
    {
        Stack<string> MiPila = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // llamamos al constructor para definir nombre del triangulo
           Triangulo tri = new Triangulo(Convert.ToDouble(txtBaseT.Text), Convert.ToDouble(txtAlturaT.Text) ,txtNombreT.Text);
            // utilizamos la interfaz creada poligono en la clase FiguraGeometrica para calcular el area
            
            txtAreaTriangulo.Text =Convert.ToString( tri.Area(tri.MyTipo,Convert.ToDouble(txtBaseT.Text), Convert.ToDouble(txtAlturaT.Text)));
            if (txtAreaTriangulo.Text != "")
            {
                // MiPila.Push(tri.MyTipo + ": " + Convert.ToString(tri.Nombre) + " :" + txtAreaTriangulo.Text );
                //llamamos al metodo mostrar de la clase triangulo
                MiPila.Push(tri.mostrar(tri.MyTipo));
                // MessageBox.Show("ingresado " + txtElemento.Text ,"Ingreso a Cola");
                listar();
                //txtElemento.Text = "";
            }

           
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            // llamamos al constructor para definir nombre del triangulo
            rectangulo rec = new rectangulo(Convert.ToDouble(txtBaseR.Text), Convert.ToDouble(txtAlturaR.Text), txtNombreR.Text);
            // utilizamos la interfaz creada poligono en la clase FiguraGeometrica para calcular el area

            txtAreaR.Text = Convert.ToString(rec.Area(rec.MyTipo, Convert.ToDouble(txtBaseR.Text), Convert.ToDouble(txtAlturaR.Text)));
            if (txtAreaR.Text != "")
            {
                // MiPila.Push(tri.MyTipo + ": " + Convert.ToString(tri.Nombre) + " :" + txtAreaTriangulo.Text );
                //llamamos al metodo mostrar de la clase triangulo
                MiPila.Push(rec.mostrar(rec.MyTipo));
                // MessageBox.Show("ingresado " + txtElemento.Text ,"Ingreso a Cola");
                listar();
                //txtElemento.Text = "";
            }
        }
        public void listar()
        {
            lstPila.Items.Clear();

            if (MiPila.Count > 0)
            {
                //lblPila.Text = "";
                foreach (string elemento in MiPila)
                {

                    lstPila.Items.Add(elemento);
                    //lblPila.Text = "\n";
                   // lblPila.Text = lblPila.Text + elemento + "\n";



                }
                
            }
            


        }
        public void listarLabel()
        {
            lblPila.Text = "";

            if (MiPila.Count > 0)
            {
                
                foreach (string elemento in MiPila)
                {

                   // lstPila.Items.Add(elemento);
                    //lblPila.Text = "\n";
                    lblPila.Text = lblPila.Text + elemento + "\n";



                }

            }



        }

        private void txtAlturaT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnParalelo_Click(object sender, EventArgs e)
        {
            // llamamos al constructor para definir nombre del triangulo
            Paralelogramo paralelo = new Paralelogramo(Convert.ToDouble(txtbaseP.Text), Convert.ToDouble(txtAlturaP.Text), txtNombreP.Text);
            // utilizamos la interfaz creada poligono en la clase FiguraGeometrica para calcular el area

            txtAreaP.Text = Convert.ToString(paralelo.Area(paralelo.MyTipo, Convert.ToDouble(txtbaseP.Text), Convert.ToDouble(txtAlturaP.Text)));
            if (txtAreaP.Text != "")
            {
                // MiPila.Push(tri.MyTipo + ": " + Convert.ToString(tri.Nombre) + " :" + txtAreaTriangulo.Text );
                //llamamos al metodo mostrar de la clase triangulo
                MiPila.Push(paralelo.mostrar(paralelo.MyTipo));
                // MessageBox.Show("ingresado " + txtElemento.Text ,"Ingreso a Cola");
                listar();
                //txtElemento.Text = "";
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listarLabel();
        }
    }
}