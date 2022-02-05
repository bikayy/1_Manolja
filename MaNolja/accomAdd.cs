using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manolza
{
    public partial class accomAdd : Form
    {
        public User CurrentUser { get; set; }

        public string a { get; set; }
        public Accom AddAccom
        { 
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in clbFacility.CheckedItems)
                {
                    sb.Append(item + " ");
                }

                Accom acc = new Accom();
                acc.AccomId = 2;
                acc.RepName = txtRepName.Text;
                acc.AccomName = txtAccomName.Text;
                acc.AccomAddr1 = accomZip.ZipCode;
                acc.AccomAddr2 = accomZip.Address1;
                acc.AccomAddr3 = accomZip.Address2;
                acc.AccomEmail = txtAccomEmail.Text;
                acc.AccomTel = txtAccomTel.Text;
                acc.CRNum = txtCRNum.Text;
                acc.AccomFacility = sb.ToString();
                acc.AccomType = cboAccomType.Text;
                acc.AccomInfo = "";
                return acc;
            }
            set
            {
                string a = clbFacility.CheckedItems.ToString();
                txtRepName.Text = value.RepName;
                txtAccomName.Text = value.AccomName;
                string AccomAddr = value.AccomAddr1 + value.AccomAddr2 + value.AccomAddr3;
                txtAccomEmail.Text = value.AccomEmail;
                txtAccomTel.Text = value.AccomTel;
                txtCRNum.Text = value.CRNum;
                a = value.AccomFacility;
                cboAccomType.Text = value.AccomType;
            }
        }

        public accomAdd(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        public accomAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            accomDAC dac = new accomDAC();

            int iresult = dac.AccomAdd(AddAccom, CurrentUser.UserId);
            dac.Dispose();

            if (iresult > 0)
            {
                MessageBox.Show("업체 등록이 완료되었습니다.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accomAdd_Load(object sender, EventArgs e)
        {
            string[] category = { "accom_Type", "accom_Area", "reserve_Type", "payment_Method", "accom_facility" };

            accomDAC dac = new accomDAC();
            DataTable dtCode = dac.GetCommonCodes(category);

            DataView dv = new DataView(dtCode);
            dv.RowFilter = "category = 'accom_facility'";

            for (int i = 0; i < dv.Count; i++)
            {
                clbFacility.Items.Add(dv[i]["name"].ToString());
            }

            CommonUtil.ComboBinding(cboAccomType, "accom_Type", dtCode);

            
            
        }
    }
}
