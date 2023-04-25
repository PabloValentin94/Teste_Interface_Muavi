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

    public partial class frm_principal : Form
    {

        public frm_principal()
        {

            InitializeComponent();

            this.Size = this.MinimumSize;

            //pctbox_logo_centro.ImageLocation = "C:\\Users\\Evandro\\Desktop\\Teste_Interface_Muavi\\Teste_Interface_Muavi\\View\\Assets\\Images\\Logos\\main_logo.png";

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

        private void btn_ferramentas_Click(object sender, EventArgs e)
        {

            Visibilidade_Menus(pn_menu_ferramentas);

        }

        private void btn_form_externo_Click(object sender, EventArgs e)
        {

            Fechar_Submenus();

            Abrir_Form_Externo(new View.frm_externo());

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            Fechar_Submenus();

            if(MessageBox.Show("Realmente deseja fechar este formulário?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();

            }

        }

        private Form form_externo = null;

        private void Abrir_Form_Externo(Form formulario)
        {

            if(form_externo != null)
            {

                form_externo.Close();

            }

            form_externo = formulario;

            form_externo.TopLevel = false;

            form_externo.FormBorderStyle = FormBorderStyle.None;

            form_externo.Dock = DockStyle.Fill;

            pn_form_externo.Controls.Add(form_externo);

            pn_form_externo.Tag = form_externo;

            form_externo.BringToFront();

            form_externo.Show();

        }

    }

}
