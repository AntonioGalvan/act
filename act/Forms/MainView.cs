using act.Forms.Side_bar;
using act.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act.Forms.Roles
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            //Llamar el método al cargar la form
            ShowSideMenu();


        }

        //Este código sirve para mostrar el menú dentro del panel
        private void ShowSideMenu()
        {
            SideBar sdBar = new SideBar();
            sdBar.TopLevel = false;
            sdBar.AutoScroll = true;
            pnlMenu.Controls.Add(sdBar);
            sdBar.Show();
        }
    }
}
