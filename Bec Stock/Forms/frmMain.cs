using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Bec_Stock.Forms.pages;

namespace Bec_Stock.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDash da = new frmDash();
            da.MdiParent = this;
            da.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmHome da = new frmHome();
            da.MdiParent = this;
            da.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmStock da = new frmStock();
            da.MdiParent = this;
            da.Show();

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCredit da = new frmCredit();
            da.MdiParent = this;
            da.Show();
        }
    }
}