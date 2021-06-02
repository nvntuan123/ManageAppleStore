using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ManageAppleStore_DTO;
using System.Data.SqlClient;

namespace ManageAppleStore_DAO
{
    public class FrmsDAO
    {
        public static BindingList<FrmsDTO> loadListDAO()
        {
            BindingList<FrmsDTO> LstFrm = new BindingList<FrmsDTO>();
            string StrSelect = @"select *
	                                from tblFrms;";
            SqlConnection conn = DataProviderDAO.createConnect();
            SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

            while (sdr.Read())
            {
                FrmsDTO Frm = new FrmsDTO();
                Frm.StrFrmID = sdr["ID"].ToString();
                Frm.StrFrmName = sdr["Name"].ToString();
                LstFrm.Add(Frm);
            }

            sdr.Close();
            conn.Close();
            return LstFrm;
        }
    }
}
