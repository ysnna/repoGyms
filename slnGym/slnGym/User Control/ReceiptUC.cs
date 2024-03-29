﻿using System;
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
using System.Globalization;

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
        DETAILCONTRACT detailsCont = new DETAILCONTRACT();
        DETAILRECEIPT detailsReceipt = new DETAILRECEIPT();
        STATISTICS statistic = new STATISTICS();
        ContractBL bl = new ContractBL();

        // ============Load & Event
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
            listReceipt.period = 1;
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
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) - (100 * Convert.ToDecimal(txtDiscount.Text.Trim()))).ToString();
                }
                else
                {
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) - Convert.ToDecimal(txtDiscount.Text.Trim())).ToString();
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
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) - (100 * Convert.ToDecimal(txtDiscount.Text.Trim()))).ToString();
                }
                else
                {
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim()) - Convert.ToDecimal(txtDiscount.Text.Trim())).ToString();
                }
            }
            else txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubTotal.Text.Trim())).ToString();
        }

        private void btPrintInvoice_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument receipt = new System.Drawing.Printing.PrintDocument();
            printDialog1.Document = receipt;
            receipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(createBill);
            DialogResult result1 = printDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
                receipt.Print();
            this.Dispose();
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

        private void ReceiptUC_Load(object sender, EventArgs e)
        {
            btPayment.Enabled = false;
            btPrintInvoice.Enabled = false;
            lbStatus.Text = "Non-payment";
            cbDiscount.Text = "VND";
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

        //==========Hàm xử lý

        public void createBill(Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            double cash = double.Parse(txtTotal.Text, NumberStyles.Currency);
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 16);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("       GYM FITNESS Center", new Font("Courier New", 24), new SolidBrush(Color.Black), startX + 100, startY);
            string top = "Item Name".PadRight(35) + "Quantity".PadRight(10) + "Price";
            offset = offset + (int)fontHeight;
            graphic.DrawString("Invoice number: " + txtInvoiceNo.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Employee ID   : " + txtEmployeeID.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Member        : " + txtNameMember.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Checked out   : " + lbDatePayment.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            decimal total = Convert.ToDecimal(txtTotal.Text);
            decimal paid = Convert.ToDecimal(txtPaid.Text);
            decimal change = Convert.ToDecimal(txtChange.Text);

            for (int i = 0; i < dgvCheckInvoice.Rows.Count; i++)
            {
                string name = dgvCheckInvoice.Rows[i].Cells[2].Value.ToString();
                string quantity = dgvCheckInvoice.Rows[i].Cells[3].Value.ToString();
                decimal price = Convert.ToDecimal(dgvCheckInvoice.Rows[i].Cells[4].Value);

                string productLine = name.PadRight(35) + quantity.PadRight(10) + String.Format("{0:c}", price);
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }

            graphic.DrawString("------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            graphic.DrawString("Total  ".PadRight(45) + String.Format("{0:c}", total),
                new Font("Courier New", 16, FontStyle.Regular),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Payment".PadRight(45) + String.Format("{0:c}", paid),
                new Font("Courier New", 16, FontStyle.Regular),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Change ".PadRight(45) + String.Format("{0:c}", change),
                new Font("Courier New", 16, FontStyle.Regular),
                new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 40;
            graphic.DrawString("          Thank you. See you again soon", font, new SolidBrush(Color.Black), startX + 100, startY + offset);

            offset = offset + 20;
            graphic.DrawString("             Have a wonderful day!", font, new SolidBrush(Color.Black), startX + 100, startY + offset);
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "Paid";
            lbTimePayment.Text = DateTime.Now.ToString();
            if (GETContract.ISRENEW == "renew")
            {
                createReceipt();
                createDetailsContract();
                createDetailsReceipt();
            }
            else if (GETContract.ISRENEW == "addnew")
            {
                createContract();
                createReceipt();
                createDetailsContract();
                createDetailsReceipt();
            }
            else if (GETContract.ISRENEW == "new")
            {
                createMember();
                createContract();
                createReceipt();
                createDetailsContract();
                createDetailsReceipt();
            }
            else if (GETContract.ISRENEW == "recommon")
            {
                createReceipt();
                createDetailsReceipt();
            }
            else if (GETContract.ISRENEW == "buypackages")
            {
                createMember();
                createReceipt();
                createDetailsReceipt();
            }
            else //buyproducts
            {
                createReceipt();
                createDetailsReceipt();
            }
            MessageBox.Show("Complete");
        }

      

        public bool IsNumeric(string val) => double.TryParse(val, out double result);

        public void createMember()
        {
            #region Create account
            //try..catch
            if (log.insertLogin(GETMember.IDMember, GETMember.Password, "5", "Blocked"))
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
                if (mem.insertMembers(GETMember.IDMember, GETMember.LName, GETMember.FName, pic, GETMember.Birthday, GETMember.Address, GETMember.Gender, GETMember.Phone, GETMember.IDCard, "Chờ duyệt"))
                    MessageBox.Show("Added Member", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Added member fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            #endregion
        }

        public void createContract()
        {
            //try..catch
            if (contract.insertCONTRACTS(GETContract.IDContract, GETMember.IDMember, GLOBAL.username, ""))
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
            int lenght = GETContract.listContracts.Count;
            for (int i = 0; i < lenght; i++)
            {
                detailsCont.insertDETAILCON(GETContract.IDContract, txtInvoiceNo.Text.Trim(), GETContract.listContracts[i].idPT, GETContract.listContracts[i].idPackage, GETContract.listContracts[i].dateStart, GETContract.listContracts[i].dateDischarge, GETContract.listContracts[i].status);
            }
        }

        public void createDetailsReceipt()
        {
            int lenght = dgvCheckInvoice.Rows.Count;
            for (int i = 0; i < lenght; i++)
            {
                int idBrand = Convert.ToInt32(dgvCheckInvoice.Rows[i].Cells[0].Value);
                int idSer = Convert.ToInt32(dgvCheckInvoice.Rows[i].Cells[1].Value);
                string name = dgvCheckInvoice.Rows[i].Cells[2].Value.ToString();
                int period = Convert.ToInt32(dgvCheckInvoice.Rows[i].Cells[3].Value);
                decimal total = Convert.ToDecimal(dgvCheckInvoice.Rows[i].Cells[4].Value);
                if (GETContract.ISRENEW == "recommon" || GETContract.ISRENEW == "buypackages")
                {
                    detailsReceipt.insertDETAILRECEIPT(txtInvoiceNo.Text, Convert.ToDateTime(Convert.ToDateTime(lbTimePayment.Text).ToShortDateString()), idBrand, idSer, name, period, total, GETContract.Start.ToString());
                }
                else detailsReceipt.insertDETAILRECEIPT(txtInvoiceNo.Text, Convert.ToDateTime(Convert.ToDateTime(lbTimePayment.Text).ToShortDateString()), idBrand, idSer, name, period, total, "");
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
            txtEmployeeID.Text = GLOBAL.username.ToUpper();
            lbDatePayment.Text = DateTime.Now.ToString();
            txtNameMember.Text = GETMember.FName + " " + GETMember.LName;
            txtPhoneNumber.Text = GETMember.Phone;
            txtAddress.Text = GETMember.Address;
           string gender = GETMember.Gender;
            if (gender == "Female")
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
            decimal total = 0;
            if (GETContract.ISRENEW == "recommon" || GETContract.ISRENEW == "buypackages")
            {
                listReceipt = new ListReceipt();
                listReceipt.idBrand = 3;
                listReceipt.idService = 18;
                listReceipt.name = "Package common";
                listReceipt.period = GETContract.Period;
                listReceipt.price = 600000 * GETContract.Period;
                listReceiptBindingSource.Add(listReceipt);
                total = listReceipt.price;
            }
            else if (GETContract.ISRENEW == "renew" || GETContract.ISRENEW == "addnew" || GETContract.ISRENEW == "new")
            {
                int lenght = 0;
                if (GETContract.listContracts.Count > 0)
                {
                    lenght = GETContract.listContracts.Count;
                }
                for (int i = 0; i < lenght; i++)
                {
                    listReceipt = new ListReceipt();
                    listReceipt.idBrand = 1;
                    listReceipt.idService = GETContract.listContracts[i].idPackage;
                    listReceipt.name = GETContract.listContracts[i].namePackage;
                    listReceipt.period = GETContract.listContracts[i].period;
                    listReceipt.price = GETContract.listContracts[i].price * GETContract.listContracts[i].period;
                    listReceiptBindingSource.Add(listReceipt);
                    total += listReceipt.price;
                }
            }
            else
            { }
            txtSubTotal.Text = total.ToString();
            txtTotal.Text = txtSubTotal.Text;
        }

        private void dgvCheckInvoice_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvCheckInvoice.CurrentCell.RowIndex;
            int getIDgroup = Convert.ToInt32(dgvCheckInvoice.Rows[index].Cells[0].Value);
            if (getIDgroup == 1)
            {
                txtSubTotal.Text = (Convert.ToDecimal(txtSubTotal.Text.Trim()) - Convert.ToDecimal(dgvCheckInvoice.Rows[index].Cells[4].Value)).ToString();
            }
            else if (getIDgroup == 2)
            {
                txtOthers.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) - Convert.ToDecimal(dgvCheckInvoice.Rows[index].Cells[4].Value)).ToString();
            }
            else //gói phổ thông
            {

            }

            if (dgvCheckInvoice.SelectedRows.Count > 0)
            {
                dgvCheckInvoice.Rows.RemoveAt(dgvCheckInvoice.CurrentRow.Index);
                //GETContract.listContracts.RemoveAt(index);
            }
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
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

        private void dgvCheckInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt32( dgvCheckInvoice.CurrentRow.Cells[1].Value.ToString());
            int i = 0;
            while (i < GETContract.listContracts.Count)
            {
                if (index == GETContract.listContracts[i].idPackage)
                {
                    lbStartDate.Text = GETContract.listContracts[i].dateStart.ToString();
                    lbDischarge.Text = GETContract.listContracts[i].dateDischarge.ToString();
                    return;
                    //TimeSpan time = GETContract.listContracts[i].dateDischarge - GETContract.listContracts[i].dateStart;
                    //txtComment.Text = "Total payment due in " + time.Days.ToString() + " days";
                }
                i++;
            }
        }
    }
}