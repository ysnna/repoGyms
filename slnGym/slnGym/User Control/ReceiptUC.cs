using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.Layer;

namespace slnGym.User_Control
{
    public partial class ReceiptUC : UserControl
    {
        public ReceiptUC()
        {
            InitializeComponent();
        }

        PRODUCTs pd = new PRODUCTs();

        private void btPrintInvoice_Click(object sender, EventArgs e)
        {

            this.Visible = false;
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "1000000";
            txtChange.Text = "";
            btPayment.Enabled = false;
            if (IsNumeric(txtPaid.Text) == true && double.Parse(txtPaid.Text) >= double.Parse(txtTotal.Text))
            {
                double changed;
                changed = Convert.ToDouble(txtPaid.Text.Trim()) - Convert.ToDouble(txtTotal.Text.Trim());
                txtChange.Text = changed.ToString();
                btPayment.Enabled = true;
            }
        }

        public bool IsNumeric(string val) => double.TryParse(val, out double result);

        private void ReceiptUC_Load(object sender, EventArgs e)
        {
            btPayment.Enabled = false;
            btPrintInvoice.Enabled = false;
            lbStatus.Text = "Non-payment";
            cbDiscount.Text = "VND";
            loadProducts();
        }

        private void cbDiscount_TextChanged(object sender, EventArgs e)
        {
            if (cbDiscount.Text == "%")
                lbDiscount.Visible = false;
            else lbDiscount.Visible = true;
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "Paid";
        }

        private void lbStatus_TextChanged(object sender, EventArgs e)
        {
            if (lbStatus.Text == "Paid")
                btPrintInvoice.Enabled = true;
            else btPrintInvoice.Enabled = false;
        }

        public void loadProducts()
        {
            dgvViewProduct.RowTemplate.Height = 40;
            dgvViewProduct.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvViewProduct.AllowUserToAddRows = false;
            dgvViewProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvViewProduct.DataSource = pd.getPRODUCTSbyIDNAMECost();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}