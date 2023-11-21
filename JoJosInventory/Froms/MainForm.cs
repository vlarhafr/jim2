using JoJosInventory.Classes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JoJosInventory
{
    public partial class MainForm : Form
    {
        Boolean subMenuExpand = false;
        Boolean menuExpand = false;
        BcLogin login = BcLogin.Instance;
        private ToolTip toolTip1;
        Controls.BaseMaterial Bm = new Controls.BaseMaterial();
        public MainForm()
        {
            InitializeComponent();
            Bm.Dock = DockStyle.Fill;

            // Inicializar ToolTip
            toolTip1 = new System.Windows.Forms.ToolTip(this.components);

            // Configurar los retrasos para el ToolTip
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            // Configurar el texto del ToolTip para los botones
            AddButtonsFromControl(flMenu);
            //toolTip1.SetToolTip(this.button2, "Texto para el botón 2");
            // Repite esta línea para cada botón o control
        }

        private void AddButtonsFromControl(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                // Si el control es un botón, lo añade a la lista
                if (subControl is Button)
                {
                    //buttons.Add(subControl as Button);
                    Button b = (Button)subControl;
                    toolTip1.SetToolTip(b, b.Text.ToString().Trim());
                }
                // Si el control es un contenedor, busca recursivamente dentro de él
                else if (subControl is FlowLayoutPanel || subControl is Panel)
                {
                    AddButtonsFromControl(subControl);
                }
            }
        }

        private void timerSubMenuTransition_Tick(object sender, EventArgs e)
        {
            if (subMenuExpand)
            {
                flDamage.Height += 10;
                if (flDamage.Height >= 64)
                {
                    timerSubMenuTransition.Stop();
                    subMenuExpand = false;
                    btnDmp.ImageIndex = 1;
                }
            }
            else
            {
                flDamage.Height -= 10;
                if (flDamage.Height <= 0)
                {
                    timerSubMenuTransition.Stop();
                    subMenuExpand = true;
                    btnDmp.ImageIndex = 2;
                }
            }

        }

        private void btnDmp_Click(object sender, EventArgs e)
        {
            timerSubMenuTransition.Start();
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            timerMenuTransition.Start();
        }

        private void timerMenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                flMenu.Width += 10;
                if (flMenu.Width >= 231)
                {
                    timerMenuTransition.Stop();
                    menuExpand = false;
                    picMain.Image = imageList.Images[3];
                }
            }
            else
            {
                flMenu.Width -= 10;
                if (flMenu.Width <= 50)
                {
                    timerMenuTransition.Stop();
                    menuExpand = true;
                    picMain.Image = imageList.Images[4];
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnUser.Text = login.Username;
        }

        private void CleanButtons(Control control)
        {
            foreach (Control subControl in control.Controls)
            {
                if (subControl is Button)
                {
                    Button b = (Button)subControl;
                    if (!b.Tag.ToString().ToLower().Contains("dm"))
                    {
                        b.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        b.BackColor = Color.Gainsboro;
                    }

                }
                else if (subControl is FlowLayoutPanel || subControl is Panel)
                {
                    CleanButtons(subControl);
                }
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            RemoveControls();
            CleanButtons(flMenu);
            Button b = (Button)sender;
            b.BackColor = Color.DarkGray;
            switch (b.Tag)
            {
                case "Bm":
                    pnMain.Controls.Add(Bm);
                    break;

                default:
                    //pnMain.Controls.Add(Bm);
                    break;
            }
        }

        private void RemoveControls()
        {
            foreach (Control control in pnMain.Controls.OfType<Control>().ToList())
            {
                pnMain.Controls.Remove(control);
            }
        }
    }
}