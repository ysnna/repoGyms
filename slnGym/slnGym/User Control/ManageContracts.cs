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

namespace slnGym.User_Control
{
    public partial class ManageContracts : UserControl
    {
        public ManageContracts()
        {
            InitializeComponent();
        }

        ContractBL bl = new ContractBL();

        private void ManageContracts_Load(object sender, EventArgs e)
        {
            bl.loadDGVContract(dgvContracts);
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = dgvContracts.CurrentRow.Cells[1].Value.ToString();
            string index1 = dgvContracts.CurrentRow.Cells[3].Value.ToString();
            bl.disPlayID(txtIDBuyer, dgvContracts);
            bl.disPlayCusName(txtNameBuyer, index);
            bl.disPlayEmpID(txtIDSeller, dgvContracts);
            bl.disPlayEmpName(txtNameSeller, index1);
        }
    }
}