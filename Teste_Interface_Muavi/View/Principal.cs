using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Interface_Muavi.View
{
    public partial class Principal : Form
    {
        public Principal()
        {

            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

            Fechar_Submenus();

        }

        private void Fechar_Submenus()
        {

            pn_menu_midia.Visible = false;

            pn_menu_playlist.Visible = false;

            pn_menu_ferramentas.Visible = false;

        }

        private void Visibilidade_Menus(Panel menu)
        {

            if (menu.Visible == true)
            {

                menu.Visible = false;

            }

            else
            {

                Fechar_Submenus();

                menu.Visible = true;

            }

        }

        private void btn_midia_Click(object sender, EventArgs e)
        {

            Visibilidade_Menus(pn_menu_midia);

        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {

            Visibilidade_Menus(pn_menu_playlist);

        }

        private void btn_equalizador_Click(object sender, EventArgs e)
        {



        }

        private void btn_ferramentas_Click(object sender, EventArgs e)
        {

            Visibilidade_Menus(pn_menu_ferramentas);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Fechar_Submenus();

        }

        private Form form_externo = null;

        private void Abrir_Form_Externo(Form formulario)
        {

            if(form_externo != null)
            {

                form_externo.Close();

            }

            form_externo.Show(formulario);

        }

    }

}
