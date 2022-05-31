namespace Minijuego
{
    public partial class Form1 : Form
    {
        int x, y;
        int Altura_max = 70;
        bool saltar= false, abajo=false, izquierda=false, derecha=false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Concepto_Juego();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
                saltar = true;
            }
            else if(e.KeyCode == Keys.Down)
            {
                saltar = false; abajo = true;
            }
            else if(e.KeyCode==Keys.Left)
            {
                izquierda = true;
            }
            else if(e.KeyCode == Keys.Right)
            {
                derecha = true;
            }
        }
        private void Concepto_Juego()
        {
            if(saltar)
            {
                if (y > Altura_max) { y -= 5; }
                else 
                { 
                    saltar = false;
                    abajo = true;
                    izquierda=false;
                    derecha=false;
                }
            }
            if(abajo)
            {
                if(Pablo.Bottom>=this.Bottom)
                {
                    abajo = false;
                    MessageBox.Show("Intenta de nuevo");
                }
                else
                {
                    y += 5;
                    x += 0;
                }
            }
            if(izquierda)
            {
                if (x <= 0)
                {
                    x = 0;
                }
                else { x -= 5; }
                izquierda = false;
            }
            if(derecha)
            {
                if(x>= this.Right)
                {
                    x += 0;

                }
                else
                {
                    x += 5;
                }
                derecha = false;
            }
            Pablo.Location = new Point(x, y);
            if(Pablo.Left >= p1.Left - 30 && Pablo.Left <= p1.Right-20 && Pablo.Bottom <= p1.Top && Pablo.Bottom > p1.Top-10)
            {
                abajo=false;

            }
            else if(Pablo.Left >= p1.Left - 30 && Pablo.Left <= p1.Right - 20 && Pablo.Top <= p1.Bottom && Pablo.Top > p1.Bottom - 10)
            {
                saltar=false;

            }
            if (Pablo.Left >= p2.Left - 30 && Pablo.Left <= p2.Right - 20 && Pablo.Bottom <= p2.Top && Pablo.Bottom > p2.Top - 10)
            {
                abajo = false;

            }
            else if (Pablo.Left >= p2.Left - 30 && Pablo.Left <= p2.Right - 20 && Pablo.Top <= p2.Bottom && Pablo.Top > p2.Bottom - 10)
            {
                saltar = false;

            }

        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x =  Pablo.Top;
            y =  Pablo.Left;
            
        }
    }
}