using act.Forms.Side_bar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act.Forms.Business_Rules.Index
{
    public partial class RuleIndex : Form
    {
        public RuleIndex()
        {
            InitializeComponent();
            ShowSideMenu();
        }
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
