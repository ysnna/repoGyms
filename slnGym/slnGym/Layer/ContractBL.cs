using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.DataObject;
using slnGym.Layer;
using System.Data;

namespace slnGym.Layer
{
    public class ContractBL
    {
        EMPLOYEEs emp = new EMPLOYEEs();
        DETAILCONTRACT con = new DETAILCONTRACT();
        MEMBERs mem = new MEMBERs();
        RECEIPTs rc = new RECEIPTs();
        public void loadDGVContract(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = new DataTable();
            dt = con.getDetailConTractDGV();
            dgv.DataSource = dt;

        }
        public void disPlayID(TextBox txt, DataGridView dgv)
        {
            txt.Text = null;
            txt.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
        public void disPlayCusName(TextBox txt, string cusID)
        {
            txt.Text = null;
            DataTable dt = new DataTable();
            dt = mem.getMemberbyID(cusID);
            txt.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
        }
        public void disPlayEmpID(TextBox txt, DataGridView dgv)
        {
            txt.Text = null;
            txt.Text = dgv.CurrentRow.Cells[3].Value.ToString();
        }
        public void disPlayEmpName(TextBox txt, string empID)
        {
            txt.Text = null;
            DataTable dt = new DataTable();
            dt = emp.getEmployeebyID(empID);
            txt.Text = dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString();
        }
        //Lấy Contract ID tự động
        public string loadIDContract()
        {
            string Texti = null;
            DataTable dtcontract = new DataTable();
            CONTRACTs contract = new CONTRACTs();
            Layer.MEMBERs mem = new MEMBERs();
            dtcontract = contract.getCONTRACTS();
            int countRowContract = dtcontract.Rows.Count;
            int i = 1;
            int j = 0;
            if (countRowContract < 10)
            {
                while (i <= countRowContract && j < countRowContract)
                {
                    Texti = "CONT0";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "CONT0";
                    Texti += i;
                }
                return Texti;
            }
            else
            {
                while (i <= dtcontract.Rows.Count && j < dtcontract.Rows.Count)
                {
                    Texti = "CONT";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "CONT";
                    Texti += i;
                }
                return Texti;
            }
        }
        //Lấy Member ID tự động
        public string loadIDMEMBER()
        {
            string memID = null;
            DataTable dtmem = new DataTable();
            dtmem = mem.getAllMEMBERS();
            int countRowMember = dtmem.Rows.Count;
            int i = 1;
            int j = 0;
            while (i <= countRowMember && j < countRowMember)
            {
                memID = "kh";
                memID += i;
                if (memID == dtmem.Rows[j][0].ToString())
                {
                    j++;
                    i++;
                }
                else return memID;
            }
            if (i > countRowMember)
            {
                memID = "kh";
                memID += i;
            }

            return memID;
        }
        //Load InvoiceID tự động
        public string loadInvoiceID()
        {
            string Texti = null;
            DataTable dtcontract = new DataTable();
            dtcontract = rc.getRECEIPT();
            int countRowContract = dtcontract.Rows.Count;
            int i = 1;
            int j = 0;
            if (countRowContract < 10)
            {
                while (i <= countRowContract && j < countRowContract)
                {
                    Texti = "IVC0";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "IVC0";
                    Texti += i;
                }
                return Texti;
            }
            else
            {
                while (i <= dtcontract.Rows.Count && j < dtcontract.Rows.Count)
                {
                    Texti = "IVC";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "IVC";
                    Texti += i;
                }
                return Texti;

            }
        }
    }
}