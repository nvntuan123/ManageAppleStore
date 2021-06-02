using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageAppleStore_DTO;

namespace ManageAppleStore_DAO
{
    public class EmployeeOfTypesDAO
    {
        public static BindingList<EmployeeOfTypesDTO> loadListDAO()
        {
            try
            {
                BindingList<EmployeeOfTypesDTO> LstEmpType = new BindingList<EmployeeOfTypesDTO>();
                string strSelect = @"select *
	                                    from dbo.tblEmployeeOfType
		                                    where dbo.tblEmployeeOfType.Status = 1";

                SqlConnection conn = DataProviderDAO.createConnect();
                SqlDataReader sdr = DataProviderDAO.queryData(strSelect, conn);

                while (sdr.Read())
                {
                    EmployeeOfTypesDTO EmpType = new EmployeeOfTypesDTO();

                    if (!sdr.IsDBNull(0))
                    {
                        EmpType.StrID = sdr["ID"].ToString();
                    }

                    if (!sdr.IsDBNull(1))
                    {
                        EmpType.StrName = sdr["Name"].ToString();
                    }

                    if (!sdr.IsDBNull(2))
                    {
                        EmpType.BStatus = Convert.ToBoolean(sdr["Status"]);
                    }

                    LstEmpType.Add(EmpType);
                }

                sdr.Close();
                conn.Close();

                return LstEmpType;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<string> loadIDListDAO()
        {
            try
            {
                List<string> LstID = new List<string>();
                string StrSelect = @"select dbo.tblEmployeeOfType.ID
	                                    from dbo.tblEmployeeOfType";
                SqlConnection conn = DataProviderDAO.createConnect();
                SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

                while (sdr.Read())
                {
                    if (!sdr.IsDBNull(0))
                    {
                        LstID.Add(sdr["ID"].ToString());
                    }
                }

                sdr.Close();
                conn.Close();

                return LstID;
            }
            catch
            {
                return null;
            }
        }

        public static bool updateDAO(EmployeeOfTypesDTO EmpTypeCurrent)
        {
            string strUpdate = @"UPDATE dbo.tblEmployeeOfType SET Name = @Name WHERE ID like '" + EmpTypeCurrent.StrID + "'";
            List<SqlParameter> LstPar = new List<SqlParameter>();
            LstPar.Add(new SqlParameter("@Name", EmpTypeCurrent.StrID));

            foreach (var ParCheck in LstPar)
            {
                if (ParCheck.Value == null)
                {
                    ParCheck.Value = DBNull.Value;
                }
            }

            try
            {
                SqlConnection conn = DataProviderDAO.createConnect();
                bool BResult = DataProviderDAO.executeStatement(strUpdate, LstPar.ToArray(), conn);
                conn.Close();

                return BResult;
            }
            catch
            {
                return false;
            }
        }

        public static bool addDAO(EmployeeOfTypesDTO EmpTypeCurrent)
        {
            string strInsert = @"INSERT INTO dbo.tblLoaiNhanVien(ID, Name, Status) VALUES (@ID, @Name, 1)";
            List<SqlParameter> LstPar = new List<SqlParameter>();
            LstPar.Add(new SqlParameter("@ID", EmpTypeCurrent.StrID));
            LstPar.Add(new SqlParameter("@Name", EmpTypeCurrent.StrName));

            if (LstPar[0].Value == null)
                return false;

            foreach (var ParCheck in LstPar)
            {
                if (ParCheck.Value == null)
                {
                    ParCheck.Value = DBNull.Value;
                }
            }

            try
            {
                SqlConnection conn = DataProviderDAO.createConnect();
                bool BResult = DataProviderDAO.executeStatement(strInsert, LstPar.ToArray(), conn);
                conn.Close();

                return BResult;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateStatusDAO(EmployeeOfTypesDTO EmpTypeCurrent)
        {
            try
            {
                string StrUpdate = @"UPDATE dbo.tblEmployeeOfType SET Status = 0 WHERE ID = '" + EmpTypeCurrent.StrID + "'";
                SqlConnection conn = DataProviderDAO.createConnect();
                bool BResult = DataProviderDAO.executeStatement(StrUpdate, conn);
                conn.Close();

                return BResult;
            }
            catch
            {
                return false;
            }
        }

        public static bool checkIDDAO(EmployeeOfTypesDTO EmpTypeCurrent)
        {
            try
            {
                bool BCheck = false;
                string StrSelect = @"SELECT TOP 1 ID
	                                    FROM dbo.tblEmployeeOfType
		                                    WHERE dbo.tblEmployeeOfType.ID like '" + EmpTypeCurrent.StrID + "'";
                SqlConnection conn = DataProviderDAO.createConnect();
                SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

                if (sdr.Read())
                {
                    if (!sdr.IsDBNull(0))
                    {
                        BCheck = true;
                    }
                }

                sdr.Close();
                conn.Close();

                return BCheck;
            }
            catch
            {
                return false;
            }
        }

        public static bool checkNameDAO(EmployeeOfTypesDTO EmpTypeCurrent)
        {
            try
            {
                bool BCheck = false;
                string StrSelect = @"SELECT TOP 1 ID
	                                    FROM dbo.tblEmployeeOfType
		                                    WHERE dbo.tblEmployeeOfType.Name like N'" + EmpTypeCurrent.StrName + "'";
                SqlConnection conn = DataProviderDAO.createConnect();
                SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

                if (sdr.Read())
                {
                    if (!sdr.IsDBNull(0))
                    {
                        BCheck = true;
                    }
                }

                sdr.Close();
                conn.Close();

                return BCheck;
            }
            catch
            {
                return false;
            }
        }
    }
}
