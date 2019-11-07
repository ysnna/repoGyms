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
using slnGym.DataObject;
using System.IO;

namespace slnGym.User_Control
{
    public partial class ReceiptUC : UserControl
    {
        public ReceiptUC()
        {
            InitializeComponent();
        }

        PRODUCTs pd = new PRODUCTs();
        RECEIPTs inv = new RECEIPTs();
        CONTRACTs contract = new CONTRACTs();
        MEMBERs mem = new MEMBERs();
        ListReceipt listReceipt = new ListReceipt();
        LOGIN log = new LOGIN();
        ContractBL bl = new ContractBL();
        DETAILCONTRACT detailsCont = new DETAILCONTRACT();
        DETAILRECEIPT detailsReceipt = new DETAILRECEIPT();

        private void btPrintInvoice_Click(object sender, EventArgs e)
        {

            // this.Visible = false;
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
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
            txtSubTotal.Text = GETContract.Price.ToString();
            txtTotal.Text = txtSubTotal.Text;
            loadProducts();
            loadData();
            loadDetails();

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
            lbTimePayment.Text = DateTime.Now.ToString();
            createMember();
            createContract();
            createReceipt();
            createDetailsContract();
            createDetailsReceipt();
            MessageBox.Show("Complete");
        }

        public void createMember()
        {
            #region Create account
            //try..catch
            if (log.insertLogin(GETMember.IDMember, GETMember.Password, "2"))
            {
                MessageBox.Show("Added account", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Add account fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion

            #region Create member
            MemoryStream pic = new MemoryStream();
            GETMember.Picture.Save(pic, GETMember.Picture.RawFormat);
            if (GETMember.FName != null && GETMember.LName != null && pic != null && GETMember.Address != null && GETMember.Phone != null && GETMember.IDCard != '\0')
            {
                if (mem.insertMembers(GETMember.IDMember, GETMember.LName, GETMember.FName, GETMember.Birthday, GETMember.Address, GETMember.Gender, GETMember.Phone, GETMember.IDCard, GETMember.Note))
                    MessageBox.Show("Added Member", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Added member fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            #endregion
        }

        public void createContract()
        {
            //try..catch
            if (contract.insertCONTRACTS(GETContract.IDContract, GETMember.IDMember, GETContract.IDPT, GETContract.IDPackage, GETContract.Start, GETContract.End, GETContract.Remain))
            {
                MessageBox.Show("Added contract", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Added contract fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void createReceipt()
        {
            if (inv.insertRECEIPT(txtInvoiceNo.Text, GETMember.IDMember, Convert.ToDecimal(txtTotal.Text.Trim())))
            {
                MessageBox.Show("Added receipt", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Added receipt fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void createDetailsContract()
        {
            if (detailsCont.insertDETAILCON(GETContract.IDContract, GLOBAL.username, txtInvoiceNo.Text.Trim()))
            {
                MessageBox.Show("Added detail contract", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Added detail contract fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void createDetailsReceipt()
        {
            int lenght = dgvCheckInvoice.Rows.Count;
            for (int i = 0; i < lenght; i++)
            {
                int idBrand = Convert.ToInt32(dgvCheckInvoice.Rows[i].Cells[0].Value);
                int idSer = Convert.ToInt32(dgvCheckInvoice.Rows[i].Cells[1].Value);
                string name = dgvCheckInvoice.Rows[i].Cells[2].Value.ToString();
                decimal discount = Convert.ToDecimal(dgvCheckInvoice.Rows[i].Cells[3].Value);
                decimal total = Convert.ToDecimal(dgvCheckInvoice.Rows[i].Cells[4].Value);
                detailsReceipt.insertDETAILRECEIPT(txtInvoiceNo.Text, Convert.ToDateTime(lbTimePayment.Text), idBrand, idSer, name, discount, total);
            }
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

        public void loadData()
        {
            txtInvoiceNo.Text = bl.loadInvoiceID();
            txtMemIDInvoide.Text = GETMember.IDMember;
            txtEmployeeID.Text = GLOBAL.username;

            //DataTable dtContract = new DataTable();
            //dtContract = contract.getContractByCUSID(GETMember.IDMember.Trim());
            lbStartDate.Text = GETContract.Start.ToString();
            lbDischarge.Text = GETContract.End.ToString();
            lbDatePayment.Text = DateTime.Now.ToString();
            TimeSpan time = GETContract.End - GETContract.Start;
            txtComment.Text = txtComment.Text + time.Days.ToString() + " days";

            //DataTable dtMember = new DataTable();
            //dtMember = mem.getMemberbyID(GETMember.IDMember.Trim());
            txtNameMember.Text = GETMember.FName + " " + GETMember.LName;
            txtPhoneNumber.Text = GETMember.Phone;
            txtAddress.Text = GETMember.Address;
            int gender = Convert.ToInt32(GETMember.Gender);
            if (gender == 1)
                txtGender.Text = "Nữ";
            else txtGender.Text = "Nam";
            txtNote.Text = GETMember.Note;
        }

        public void loadDetails()
        {
            dgvCheckInvoice.RowTemplate.Height = 50;
            dgvCheckInvoice.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvCheckInvoice.AllowUserToAddRows = false;
            dgvCheckInvoice.EditMode = DataGridViewEditMode.EditProgrammatically;

            listReceipt.idBrand = 1;
            listReceipt.idService = GETContract.IDPackage;
            listReceipt.name = GETContract.NamePackage;
            listReceipt.discount = 0;
            listReceipt.price = GETContract.Price;
            listReceiptBindingSource.Add(listReceipt);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvViewProduct.CurrentCell.RowIndex;
            listReceipt = new ListReceipt();
            listReceipt.idBrand = 2;
            listReceipt.idService = Convert.ToInt32(dgvViewProduct.Rows[index].Cells[0].Value);
            listReceipt.name = dgvViewProduct.Rows[index].Cells[1].Value.ToString();
            listReceipt.price = Convert.ToDecimal(dgvViewProduct.Rows[index].Cells[2].Value);
            listReceiptBindingSource.Add(listReceipt);
            txtOthers.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + listReceipt.price).ToString();
        }

        private void txtOthers_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "0")
            {
                if (cbDiscount.Text == "%")
                {
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) + (100 * Convert.ToDecimal(txtDiscount.Text.Trim()))).ToString();
                }
                else
                {
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) + Convert.ToDecimal(txtDiscount.Text.Trim())).ToString();
                }
            }
            else txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim())).ToString();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "0")
            {
                if (cbDiscount.Text == "%")
                {
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) + (100 * Convert.ToDecimal(txtDiscount.Text.Trim()))).ToString();
                }
                else
                {
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) + Convert.ToDecimal(txtDiscount.Text.Trim())).ToString();
                }
            }
            else txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim())).ToString();
        }
    }
}