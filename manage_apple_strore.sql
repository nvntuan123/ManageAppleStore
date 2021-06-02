select distinct emp.ID,
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
		where emp.EmployOfTypeID = emptype.ID and emp.Status = 1

select ID
	from tblEmployees

INSERT INTO dbo.tblEmployees(ID, FullName, NumberPhone, BirthDay, Gender, Email, Password, IDCard, EmployOfTypeID, Salary, Status) VAlUES('NV10', 'Tuan', '0988366646', '2/15/1997', 'Nam', 'nvntuan123@gmail.com', '123456', '281141264', '1', '1000', 1)

update dbo.tblEmployees set Status = 0 where ID = 'NV10'

delete from dbo.tblEmployees where dbo.tblEmployees.ID = 'NV10'

select top 1 dbo.tblEmployees.ID
	from tblEmployees
		where tblEmployees.NumberPhone = '0988366646'


select *
	from dbo.tblEmployeeOfType
		where dbo.tblEmployeeOfType.Status = 1

select dbo.tblEmployeeOfType.ID
	from dbo.tblEmployeeOfType

select *
	from tblFrms

select distinct *
	from tblPermissions per
		where per.EmployOfTypeID like 'LNV1'

insert into dbo.tblPermissions(EmployOfTypeID, FrmID, FullRule, ViewRule, AddRule, UpdateRule, DeleteRule, AccessRule) values('LNV1', 'frmEmployees', 1, 1, 1, 1, 1, 1)
