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
    public class EmployeesDAO
    {
        public static BindingList<EmployeesDTO> loadListDAO()
        {
			BindingList<EmployeesDTO> LstEmp = new BindingList<EmployeesDTO>();
			string StrSelect = @"select distinct emp.ID,
													emp.FullName,
													emp.NumberPhone,
													emp.BirthDay,
													emp.Gender,
													emp.Email,
													emp.Password,
													emp.IDCard,
													emp.EmployOfTypeID,
													emp.Salary,
													emp.Status
												from tblEmployees emp, tblEmployeeOfType emptype
													where emp.EmployOfTypeID = emptype.ID and emp.Status = 1";
            try
            {
				SqlConnection conn = DataProviderDAO.createConnect();
				SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

				while (sdr.Read())
                {
					EmployeesDTO Emp = new EmployeesDTO();
					Emp.StrID = sdr["ID"].ToString();
					Emp.StrFullName = sdr["FullName"].ToString();
					Emp.StrNumberPhone = sdr["NumberPhone"].ToString();
					Emp.DTBirthDay = Convert.ToDateTime(sdr["BirthDay"]);
					Emp.StrGender = sdr["Gender"].ToString();
					Emp.StrEmail = sdr["Email"].ToString();
					Emp.StrPassword = sdr["Password"].ToString();
					Emp.IIDCard = Convert.ToInt32(sdr["IDCard"]);
					Emp.StrEmployeeOfTypeID = sdr["EmployOfTypeID"].ToString();
					Emp.DecSalary = Convert.ToDecimal(sdr["Salary"]);
					Emp.BStatus = Convert.ToBoolean(sdr["Status"]);

					LstEmp.Add(Emp);
                }

				sdr.Close();
				conn.Close();

				return LstEmp;
            }
			catch
            {
				return null;
            }
		}

		public static List<string> loadIDListDAO()
        {
			List<string> LstEmpID = new List<string>();
			string StrSelect = @"select ID
									from tblEmployees";
			SqlConnection conn = DataProviderDAO.createConnect();
			SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

			while (sdr.Read())
            {
				if (!sdr.IsDBNull(0))
                {
					LstEmpID.Add(sdr["ID"].ToString());
                }
            }

			sdr.Close();
			conn.Close();
			return LstEmpID;
        }
		
		public static bool addDAO(EmployeesDTO Emp)
        {
			string StrInsertEmp = @"INSERT INTO dbo.tblEmployees(ID, FullName, NumberPhone, BirthDay, Gender, Email, Password, IDCard, EmployOfTypeID, Salary, Status) VAlUES(@ID, @FullName, @NumberPhone, @BirthDay, @Gender, @Email, @Password, @IDCard, @Salary, @EmployOfTypeID, @Status)";
			List<SqlParameter> LstPar = new List<SqlParameter>();
			LstPar.Add(new SqlParameter("@ID", Emp.StrID)); // 0
			LstPar.Add(new SqlParameter("@FullName", Emp.StrFullName)); // 1
			LstPar.Add(new SqlParameter("@NumberPhone", Emp.StrNumberPhone)); // 2
			LstPar.Add(new SqlParameter("@BirthDay", Emp.DTBirthDay)); // 3
			LstPar.Add(new SqlParameter("@Gender", Emp.StrGender)); // 4
			LstPar.Add(new SqlParameter("@Email", Emp.StrEmail)); // 5
			LstPar.Add(new SqlParameter("@Password", Emp.StrPassword)); // 6
			LstPar.Add(new SqlParameter("@IDCard", Emp.IIDCard)); // 7
			LstPar.Add(new SqlParameter("@EmployOfTypeID", Emp.StrEmployeeOfTypeID)); // 8
			LstPar.Add(new SqlParameter("@Salary", Emp.DecSalary)); // 9

			if (Emp.StrEmail == "")
            {
				LstPar[5].Value = DBNull.Value;
            }

			if (Emp.DecSalary == 0)
            {
				LstPar[9].Value = DBNull.Value;
            }

			if (LstPar[0].Value == null)
            {
				return false;
            }
			
			foreach (var ParCheck in LstPar)
            {
				if (ParCheck == null)
                {
					ParCheck.Value = DBNull.Value;
                }
            }

			SqlConnection conn = DataProviderDAO.createConnect();
			bool BResult = DataProviderDAO.executeStatement(StrInsertEmp, LstPar.ToArray(), conn);

			conn.Close();
			return BResult;
		}

		public static bool updateStatusDAO(EmployeesDTO Emp)
        {
			string StrUpdate = @"update dbo.tblEmployees set Status = 0 where ID = '" + Emp.StrID + "'";
			SqlConnection conn = DataProviderDAO.createConnect();
			bool BResult = DataProviderDAO.executeStatement(StrUpdate, conn);
			conn.Close();
			return BResult;

		}

		public static bool deleteDAO(EmployeesDTO Emp)
        {
			string StrDelete = @"delete from dbo.tblEmployees where dbo.tblEmployees.ID = '" + Emp.StrID + "'";
			SqlConnection conn = DataProviderDAO.createConnect();
			bool BResult = DataProviderDAO.executeStatement(StrDelete, conn);
			conn.Close();
			return BResult;
		}

		public static string getByIDNumberPhone(string StrNumberPhone)
        {
			string StrSelect = @"select top 1 dbo.tblEmployees.ID
									from tblEmployees
										where tblEmployees.NumberPhone = '" + StrNumberPhone + "'";
			SqlConnection conn = DataProviderDAO.createConnect();
			SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

			string StrID = "";
			if (sdr.Read())
            {
				if (!sdr.IsDBNull(0))
                {
					StrID = sdr["ID"].ToString();
                }
            }

			sdr.Close();
			conn.Close();
			return StrID;
		}

		public static string getIDByIDCard(string StrIDCard)
		{
			string StrSelect = @"select top 1 dbo.tblEmployees.ID
									from tblEmployees
										where tblEmployees.IDCard = '" + StrIDCard + "'";
			SqlConnection conn = DataProviderDAO.createConnect();
			SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

			string StrID = "";
			if (sdr.Read())
			{
				if (!sdr.IsDBNull(0))
				{
					StrID = sdr["ID"].ToString();
				}
			}

			sdr.Close();
			conn.Close();
			return StrID;
		}

		public static string checkEmailDAO(string StrEmail)
        {
			string StrID = "";
			string StrSelect = @"select top 1 dbo.tblEmployees.ID
									from tblEmployees
										where tblEmployees.Email = '" + StrEmail + "'";
			SqlConnection conn = DataProviderDAO.createConnect();
			SqlDataReader sdr = DataProviderDAO.queryData(StrSelect, conn);

			if (sdr.Read())
			{
				if (!sdr.IsDBNull(0))
				{
					StrID = sdr["ID"].ToString();
				}
			}

			sdr.Close();
			conn.Close();
			return StrID;
		}
	}
}
