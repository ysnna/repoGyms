using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym.Forms
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        Layer.SERVICEPACKs sv = new Layer.SERVICEPACKs();
        Layer.PRODUCTs pd = new Layer.PRODUCTs();

        private void tabAdmin_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tabAdmin.TabPages[e.Index];
            Rectangle _tabBounds = tabAdmin.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(Color.Tomato);
                g.FillRectangle(Brushes.WhiteSmoke, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            Font _tabFont = new Font("Sitka Display", 18.0f, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            loadServicePackage();
            loadServiceProduct();
        }

        private void newEmployeeUC_Load(object sender, EventArgs e)
        {

        }
       
        Layer.ADDMACHINES machine = new Layer.ADDMACHINES();

        private void picAddMachine_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAddMachine.Image = Image.FromFile(open.FileName);
        }

        private void btSaveMachine_Click(object sender, EventArgs e)
        {
            //if (verif())
            //{
            MemoryStream pic = new MemoryStream();
            picAddMachine.Image.Save(pic, picAddMachine.Image.RawFormat);
            string name = txtAddNameMachine.Text;
            string info = txtAddDescriptionMachine.Text;
            int amount = Convert.ToInt32(numericAddMachine.Value);
            try
            {
                if (machine.insertMACHINE(name, pic, info, amount))
                {
                    MessageBox.Show("Add to database is successful", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddMachine();
                }
                else MessageBox.Show("Bug rồi");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
        }

        void ClearFormAddMachine()
        {
            txtAddDescriptionMachine.Text = "";
            txtAddNameMachine.Text = "";
            numericAddMachine.Value = 1;
            picAddMachine.Image = picAddMachine.BackgroundImage;
        }

        bool verif()
        {
            if ((txtAddDescriptionMachine.Text.Trim() == "") || (txtAddNameMachine.Text.Trim() == "")
                || (picAddMachine.Image == null))
                return false;
            return true;
        }

        public void loadServicePackage()
        {
            listPackage.Items.Clear();
            DataTable dt = new DataTable();
            dt = sv.getSERVICE();
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                listPackage.Items.Add(item[0].ToString());
                listPackage.Items[i].SubItems.Add(item[1].ToString());
                listPackage.Items[i].SubItems.Add(item[2].ToString());
                listPackage.Items[i].SubItems.Add(item[3].ToString());
                i++;
            }
        }

        public void loadServiceProduct()
        {
            dvgProducts.DataSource = pd.getPRODUCTS();
            dvgProducts.RowTemplate.Height = 70;
            dvgProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dvgProducts.AllowUserToAddRows = false;
            dvgProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dvgProducts.Columns[1];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void tabAdmin_Click(object sender, EventArgs e)
        {
            if (tabAdmin.SelectedIndex == 0)
            {


            }
            else if (tabAdmin.SelectedIndex == 1)
            {

            }
            else if (tabAdmin.SelectedIndex == 2)
            {

            }
            else if (tabAdmin.SelectedIndex == 3)
            {

            }
            else if (tabAdmin.SelectedIndex == 4)
            {

            }
            else
            {

            }
        }

        private void btSavePackage_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sv.getSERVICE();
            int id = dt.Rows.Count;
            if (txtAddNamePack.Text != null && txtAddCostPack.Text != null && txtAddDescriptionPack.Text != null)
            {
                //try..catch
                if (sv.insertSERVICE(id + 1, txtAddNamePack.Text, Convert.ToDecimal(txtAddCostPack.Text), txtAddDescriptionPack.Text))
                {
                    MessageBox.Show("Add to database successful", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListViewItem item = new ListViewItem(new string[] { (id + 1).ToString(), txtAddNamePack.Text, txtAddCostPack.Text, txtAddDescriptionPack.Text });
                    this.listPackage.Items.AddRange(new ListViewItem[] { item });
                    ClearFormAddPackage();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ClearFormAddPackage()
        {
            txtAddCostPack.Text = "";
            txtAddNamePack.Text = "";
            txtAddDescriptionPack.Text = "";
        }

        public void ClearFormAddProduct()
        {
            txtAddCostProduct.Text = "";
            txtAddNameProduct.Text = "";
            picAddProduct.Image = null;
        }

        private void btDeletePackage_Click(object sender, EventArgs e)
        {
            int id = getIDPackage;
            if (MessageBox.Show("Are you sure you want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (id == 0)
                {
                    MessageBox.Show("Please select a package");
                    return;
                }
                foreach (ListViewItem it in listPackage.Items)
                {
                    if (it.Text == id.ToString())
                    {
                        sv.deleteSERVICE(id);
                        it.Remove();
                        MessageBox.Show("Deleted");
                        return;
                    }
                }
            }
        }

        private void btEditPackage_Click(object sender, EventArgs e)
        {
            decimal cost = Convert.ToDecimal(txtEditCostPack.Text);
            string des = txtEditDescriptionPack.Text;
            string name = txtEditNamePack.Text;
            int id = getIDPackage;
            if (txtEditNamePack.Text != null && txtEditCostPack.Text != null && txtEditDescriptionPack.Text != null)
            {
                if (sv.updateSERVICE(id, name, cost, des)) //update k dc
                {
                    int i = 0;
                    for (i = 0; i < listPackage.Items.Count; i++)
                    {
                        if (listPackage.Items[i].Text == id.ToString())
                        {
                            listPackage.Items[i].SubItems[1].Text = txtEditNamePack.Text;
                            listPackage.Items[i].SubItems[2].Text = txtEditCostPack.Text;
                            listPackage.Items[i].SubItems[3].Text = txtEditDescriptionPack.Text;
                            break;
                        }
                    }
                    MessageBox.Show("Successful updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddPackage();
                    return;
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        int getIDPackage = 0;
        private void listPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listPackage.SelectedItems)
            {
                txtEditNamePack.Text = items.SubItems[1].Text;
                txtEditCostPack.Text = items.SubItems[2].Text;
                txtEditDescriptionPack.Text = items.SubItems[3].Text;
                getIDPackage = Convert.ToInt32(items.SubItems[0].Text);
            }
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pd.getPRODUCTS();
            int id = dt.Rows.Count;
            MemoryStream pic = new MemoryStream();
            picAddProduct.Image.Save(pic, picAddProduct.Image.RawFormat);
            if (txtAddNameProduct.Text != null && txtAddCostProduct.Text != null && picAddProduct.Image != null)//try catch image
            {
                //try..catch
                if (pd.insertPRODUCTS(id + 1, txtAddNameProduct.Text, Convert.ToDecimal(txtAddCostProduct.Text), pic))
                {
                    loadServiceProduct();
                    MessageBox.Show("Add to database successful", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddProduct();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = getIDPackage;
            if (MessageBox.Show("Are you sure you want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sv.deleteSERVICE(id);
                MessageBox.Show("Deleted");
                loadServicePackage();
            }
        }
        int getIDProduct = 0;
        private void dvgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pd.getPRODUCTS();
            int numrow = dvgProducts.CurrentCell.RowIndex;
            txtEditCostProduct.Text = dvgProducts.Rows[numrow].Cells[3].Value.ToString();
            txtEditNameProduct.Text = dvgProducts.Rows[numrow].Cells[2].Value.ToString();
            getIDProduct = Convert.ToInt32(dvgProducts.Rows[numrow].Cells[0].Value.ToString());
            byte[] pic;
            pic = (byte[])dt.Rows[numrow]["picture"];
            MemoryStream picedit = new MemoryStream(pic);
            picEditProduct.Image = Image.FromStream(picedit);
        }

        private void picAddProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAddProduct.Image = Image.FromFile(open.FileName);
        }

        private void picEditProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picEditProduct.Image = Image.FromFile(open.FileName);
        }

    }
}