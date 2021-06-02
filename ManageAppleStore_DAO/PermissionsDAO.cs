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
    public class PermissionsDAO
    {
        public static BindingList<PermissionsDTO> getListByEmpOfTypeIDDAO(string StrEmpOfTypeID)
        {
            BindingList<PermissionsDTO> LstPer = new BindingList<PermissionsDTO>();
            string StrSelect = @"select distinct *
	                                from tblPermissions per
		                                where per.EmployOfTypeID like '" + StrEmpOfTypeID + "'";
            SqlConnection conn = DataProviderDAO.createConnect();
            SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

            while (sdr.Read())
            {
                PermissionsDTO Per = new PermissionsDTO();
                Per.StrEmployeeOfTypeID = sdr["EmployOfTypeID"].ToString();
                Per.StrFrmID = sdr["FrmID"].ToString();
                Per.BFull = Convert.ToBoolean(sdr["FullRule"]);
                Per.BAdd = Convert.ToBoolean(sdr["AddRule"]);
                Per.BView = Convert.ToBoolean(sdr["ViewRule"]);
                Per.BUpdate = Convert.ToBoolean(sdr["UpdateRule"]);
                Per.BDelete = Convert.ToBoolean(sdr["DeleteRule"]);
                Per.BAccess = Convert.ToBoolean(sdr["AccessRule"]);

                LstPer.Add(Per);
            }

            sdr.Close();
            conn.Close();
            return LstPer;
        }

        public static PermissionsDTO getListByEmpOfTypeIDAndFormDAO(string StrEmpOfTypeID, string StrFrmID)
        {
            PermissionsDTO Per = null;
            string StrSelect = @"select distinct *
	                                from tblPermissions per
		                                where per.EmployOfTypeID like '" + StrEmpOfTypeID + "' and per.FrmID like '" + StrFrmID + "'";
            SqlConnection conn = DataProviderDAO.createConnect();
            SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

            if (sdr.Read())
            {
                Per = new PermissionsDTO();
                Per.StrEmployeeOfTypeID = sdr["EmployOfTypeID"].ToString();
                Per.StrFrmID = sdr["FrmID"].ToString();
                Per.BFull = Convert.ToBoolean(sdr["FullRule"]);
                Per.BAdd = Convert.ToBoolean(sdr["AddRule"]);
                Per.BView = Convert.ToBoolean(sdr["ViewRule"]);
                Per.BUpdate = Convert.ToBoolean(sdr["UpdateRule"]);
                Per.BDelete = Convert.ToBoolean(sdr["DeleteRule"]);
                Per.BAccess = Convert.ToBoolean(sdr["AccessRule"]);
            }

            sdr.Close();
            conn.Close();
            return Per;
        }

        public static bool addDAO(PermissionsDTO Per)
        {
            string StrInsert = @"insert into dbo.tblPermissions(EmployOfTypeID, FrmID, FullRule, ViewRule, AddRule, UpdateRule, DeleteRule, AccessRule) values(@EmployOfTypeID, @FrmID, @FullRule, @ViewRule, @AddRule, @UpdateRule, @DeleteRule, @AccessRule)";
            List<SqlParameter> LstPar = new List<SqlParameter>();
            LstPar.Add(new SqlParameter("@EmployOfTypeID", Per.StrEmployeeOfTypeID));
            LstPar.Add(new SqlParameter("@FrmID", Per.StrFrmID));
            LstPar.Add(new SqlParameter("@FullRule", Per.BFull));
            LstPar.Add(new SqlParameter("@ViewRule", Per.BView));
            LstPar.Add(new SqlParameter("@AddRule", Per.BAdd));
            LstPar.Add(new SqlParameter("@UpdateRule", Per.BUpdate));
            LstPar.Add(new SqlParameter("@DeleteRule", Per.BDelete));
            LstPar.Add(new SqlParameter("@DeleteRule", Per.BAccess));

            SqlConnection conn = DataProviderDAO.createConnect();
            bool BResult = DataProviderDAO.executeStatement(StrInsert, LstPar.ToArray(), conn);

            conn.Close();

            return BResult;
        }

        public static bool updateDAO(PermissionsDTO Per)
        {
            string StrUpdate = @"update dbo.tblPermission set FullRule = @FullRule, ViewRule = @ViewRule, AddRule = @AddRule, UpdateRule = @UpdateRule, DeleteRule = @DeleteRule, AccessRule = @AccessRule where EmployOfTypeID like '" + Per.StrEmployeeOfTypeID + "' and FrmID like '" + Per.StrFrmID + "'";
            List<SqlParameter> LstPar = new List<SqlParameter>();
            LstPar.Add(new SqlParameter("@FullRule", Per.BFull));
            LstPar.Add(new SqlParameter("@ViewRule", Per.BView));
            LstPar.Add(new SqlParameter("@AddRule", Per.BAdd));
            LstPar.Add(new SqlParameter("@UpdateRule", Per.BUpdate));
            LstPar.Add(new SqlParameter("@DeleteRule", Per.BDelete));
            LstPar.Add(new SqlParameter("@DeleteRule", Per.BAccess));

            SqlConnection conn = DataProviderDAO.createConnect();

            bool BResult = DataProviderDAO.executeStatement(StrUpdate, LstPar.ToArray(), conn);

            conn.Close();

            return BResult;
        }
    }
}
