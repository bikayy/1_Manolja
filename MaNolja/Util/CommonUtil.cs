using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manolza
{
    public class CommonUtil
    {
        public static void ComboBinding(ComboBox cbo, string category, DataTable dt, bool blankItem = true, string blankText = "선택")
        {
           
            if (blankItem)
            {
                DataRow dr = dt.NewRow();
                dr["code"] = "";
                dr["name"] = blankText;
                dr["category"] = category;
                dr["pcode"] = "";
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            DataView dv = new DataView(dt);
            dv.RowFilter = "category = '" + category + "'";
            cbo.DisplayMember = "name";
            cbo.ValueMember = "pcode";
            cbo.DataSource = dv;
        }


        public static void ComboBindingPcode(ComboBox cbo, string pcode, DataTable dt, bool blankItem = true, string blankText = "전체")
        {

            if (blankItem)
            {
                DataRow dr = dt.NewRow();
                dr["code"] = "";
                dr["name"] = blankText;
                dr["category"] = "";
                dr["pcode"] = pcode;
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            DataView dv = new DataView(dt);
            dv.RowFilter = "pcode = '" + pcode + "'";
            cbo.DisplayMember = "name";
            cbo.ValueMember = "category";
            cbo.DataSource = dv;
        }



    }
}
