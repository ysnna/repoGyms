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
        Form1 f1 = new Form1();
        String sql;
        MY_DB mydb = new MY_DB();
        public Administration(Form1 administration)
        {
            InitializeComponent();
            f1 = administration;
        }

        int getIDPackage = 0;
        int getIDProduct = 0;
        int getIDMachine = 0;

        public void closeForm()
        {
            this.Dispose();
        }

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
            loadAccount();
            loadServicePackage();
            loadServiceProduct();
            loadServiceMachine();
            loadDGVTag();
        }

        private void picAddMachine_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAddMachine.Image = Image.FromFile(open.FileName);
        }

        private void btSaveMachine_Click(object sender, EventArgs e)
        {
            ///
            ///
            ///
            MemoryStream pic = new MemoryStream();
            picAddMachine.Image.Save(pic, picAddMachine.Image.RawFormat);
            if (txtAddNameMachine.Text != null && txtAddDescriptionMachine.Text != null && picAddMachine.Image != null)//try catch image
            {
                //try..catch
                if (/* insert được*/ 1 == 2)
                {
                    loadServiceMachine();
                    MessageBox.Show("Add to database successful", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddMachine();
                    f1.reloadDGVMachines();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btEditMachine_Click(object sender, EventArgs e)
        {
            ///
            ///
            ///
            MemoryStream pic = new MemoryStream();
            picAddMachine.Image.Save(pic, picAddMachine.Image.RawFormat);
            if (txtAddNameMachine.Text != null && txtAddDescriptionMachine.Text != null && picAddMachine.Image != null)//try catch image
            {
                //try..catch
                if ((/* insert được*/ 1 == 2))
                {
                    loadServiceMachine();
                    MessageBox.Show("Update to database successful", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddMachine();
                    f1.reloadDGVMachines();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btDeleteMachine_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ///
                ///mc.getMACHINESbyID(getIDMachine);
                ///
                if ((/* insert được*/ 1 == 2))
                {
                    loadServiceMachine();
                    MessageBox.Show("Deleted");
                    ClearFormAddMachine();
                    f1.reloadDGVMachines();
                }
                else MessageBox.Show("Invalid information");
            }
        }

        public void loadServicePackage()
        {
            ///
            ///
            ///
            sql = @"EXEC proLOADService";
            DataTable dt = mydb.createTable(sql);
            dgvPackages.DataSource = dt;
            dgvPackages.RowTemplate.Height = 70;
            dgvPackages.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPackages.AllowUserToAddRows = false;
            dgvPackages.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void loadServiceProduct()
        {
            ///
            ///
            ///
            sql = @"EXEC proLOADProduct";
            DataTable dt = mydb.createTable(sql);
            dvgProducts.DataSource = dt;
            dvgProducts.RowTemplate.Height = 70;
            dvgProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dvgProducts.AllowUserToAddRows = false;
            dvgProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dvgProducts.Columns[1];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public void loadServiceMachine()
        {
            ///
            ///
            ///
            sql = @"EXEC proLOADMachines";
            DataTable dt = mydb.createTable(sql);
            dgvMachines.DataSource = dt;
            dgvMachines.RowTemplate.Height = 70;
            dgvMachines.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMachines.AllowUserToAddRows = false;
            dgvMachines.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DataGridViewImageColumn pic = new DataGridViewImageColumn();
            //pic = (DataGridViewImageColumn)dgvMachines.Columns[2];
            //pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public void loadDGVTag()
        {
            dgvTag.RowTemplate.Height = 40;
            dgvTag.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvTag.AllowUserToAddRows = false;
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

        public void ClearFormAddPackage()
        {
            txtAddCostPack.Text = "";
            txtAddNamePack.Text = "";
            txtAddDescriptionPack.Text = "";
            txtAddTagPT.Text = "";
        }

        public void ClearFormAddProduct()
        {
            txtAddCostProduct.Text = "";
            txtAddNameProduct.Text = "";
            picAddProduct.Image = null;
        }

        public void ClearFormAddMachine()
        {
            txtAddDescriptionMachine.Text = "";
            txtAddNameMachine.Text = "";
            numericAddMachine.Value = 1;
            picAddMachine.Image = null;
        }

        private void btSavePackage_Click(object sender, EventArgs e)
        {
            ///
            ///
            ///

            if (txtAddNamePack.Text != null && txtAddCostPack.Text != null && txtAddDescriptionPack.Text != null)
            {
                //try..catch
                if ((/* insert được*/ 1 == 2))
                {
                    loadServicePackage();
                    MessageBox.Show("Add to database successful", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddPackage();
                    f1.reloadDGVPacket();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btDeletePackage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ///
                ///sv.getSERVICEbyID(getIDPackage);
                ///

                if ((/* insert được*/ 1 == 2))
                {
                    loadServicePackage();
                    MessageBox.Show("Deleted");
                    ClearFormAddPackage();
                    f1.reloadDGVPacket();
                }
                else MessageBox.Show("Invalid information");
            }
        }

        private void btEditPackage_Click(object sender, EventArgs e)
        {
            ///
            ///
            ///

            if (txtAddNamePack.Text != null && txtAddCostPack.Text != null && txtAddDescriptionPack.Text != null)//try catch image
            {
                //try..catch
                if ((/* insert được*/ 1 == 2))
                {
                    loadServicePackage();
                    MessageBox.Show("Update to database successful", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddPackage();
                    f1.reloadDGVPacket();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            ///
            ///
            //

            MemoryStream pic = new MemoryStream();
            picAddProduct.Image.Save(pic, picAddProduct.Image.RawFormat);
            if (txtAddNameProduct.Text != null && txtAddCostProduct.Text != null && picAddProduct.Image != null)//try catch image
            {
                //try..catch
                if ((/* insert được*/ 1 == 2))
                {
                    loadServiceProduct();
                    MessageBox.Show("Add to database successful", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddProduct();
                    f1.reloadDGVProduct();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            ///
            ///
            ///

            MemoryStream pic = new MemoryStream();
            picAddProduct.Image.Save(pic, picAddProduct.Image.RawFormat);
            if (txtAddNameProduct.Text != null && txtAddCostProduct.Text != null && picAddProduct.Image != null)//try catch image
            {
                //try..catch
                if ((/* insert được*/ 1 == 2))
                {
                    loadServiceProduct();
                    MessageBox.Show("Update to database successful", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormAddProduct();
                    f1.reloadDGVProduct();
                }
                else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Wanning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /// pd.getPRODUCTSbyID(getIDProduct);
                /// ///
                /// 

                if ((/* insert được*/ 1 == 2))
                {
                    loadServiceProduct();
                    MessageBox.Show("Deleted");
                    ClearFormAddProduct();
                    f1.reloadDGVProduct();
                }
                else MessageBox.Show("Invalid information");
            }
        }

        private void dvgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ///
            ///
            ///
            int numrow = dvgProducts.CurrentCell.RowIndex;
            txtAddCostProduct.Text = dvgProducts.Rows[numrow].Cells[3].Value.ToString();
            txtAddNameProduct.Text = dvgProducts.Rows[numrow].Cells[2].Value.ToString();
            getIDProduct = Convert.ToInt32(dvgProducts.Rows[numrow].Cells[0].Value.ToString());
            /*byte[] pic;
            pic = (byte[])dt.Rows[numrow]["picture"];
            MemoryStream picedit = new MemoryStream(pic);
            picAddProduct.Image = Image.FromStream(picedit);*/
        }

        private void picAddProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAddProduct.Image = Image.FromFile(open.FileName);
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ///
            ///
            ///
            int numrow = dgvPackages.CurrentCell.RowIndex;
            txtAddCostPack.Text = dgvPackages.Rows[numrow].Cells[2].Value.ToString();
            txtAddNamePack.Text = dgvPackages.Rows[numrow].Cells[1].Value.ToString();
            txtAddDescriptionPack.Text = dgvPackages.Rows[numrow].Cells[3].Value.ToString();
            txtAddTagPT.Text = dgvPackages.Rows[numrow].Cells[4].Value.ToString();
            getIDPackage = Convert.ToInt32(dgvPackages.Rows[numrow].Cells[0].Value.ToString());
        }

        private void dgvMachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ///
            ///
            ///
            int numrow = dgvMachines.CurrentCell.RowIndex;
            txtAddNameMachine.Text = dgvMachines.Rows[numrow].Cells[1].Value.ToString();
            txtAddDescriptionMachine.Text = dgvMachines.Rows[numrow].Cells[3].Value.ToString();
            numericAddMachine.Value = Convert.ToInt32(dgvMachines.Rows[numrow].Cells[4].Value.ToString());
            getIDMachine = Convert.ToInt32(dgvMachines.Rows[numrow].Cells[0].Value.ToString());
            /*byte[] pic;
            pic = (byte[])dt.Rows[numrow]["picture"];
            MemoryStream picedit = new MemoryStream(pic);
            picAddMachine.Image = Image.FromStream(picedit);*/
        }

        private void btRefreshMachine_Click(object sender, EventArgs e)
        {
            ClearFormAddPackage();
        }

        private void btRefreshProduct_Click(object sender, EventArgs e)
        {
            ClearFormAddProduct();
        }

        private void btRefreshMachin_Click(object sender, EventArgs e)
        {
            ClearFormAddMachine();
        }

        public void loadAccount()
        {
            User_Control.ManageAccountUC manageAccount = new User_Control.ManageAccountUC() { Width = 1414, Height = 798 };
            this.tabAccount.Controls.Add(manageAccount);
        }
    }
}