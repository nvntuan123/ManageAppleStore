using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class PermissionsDTO
    {
        private string _StrEmployeeOfTypeID;
        private string _StrFrmID;
        private bool _BFull;
        private bool _BView; // Xem
        private bool _BAdd;
        private bool _BUpdate;
        private bool _BDelete;
        private bool _BAccess; // Truy cap

        public PermissionsDTO()
        {
            _StrEmployeeOfTypeID = string.Empty;
            _StrFrmID = string.Empty;
            _BFull = false;
            _BView = false;
            _BAdd = false;
            _BUpdate = false;
            _BDelete = false;
            _BAccess = false;
        }

        public PermissionsDTO(string strEmployeeOfTypeID, string strFrmID, bool bFull, bool bView, bool bAdd, bool bUpdate, bool bDelete, bool bAccess)
        {
            _StrEmployeeOfTypeID = strEmployeeOfTypeID;
            _StrFrmID = strFrmID;
            _BFull = bFull;
            _BView = bView;
            _BAdd = bAdd;
            _BUpdate = bUpdate;
            _BDelete = bDelete;
            _BAccess = bAccess;
        }

        public string StrEmployeeOfTypeID { get => _StrEmployeeOfTypeID; set => _StrEmployeeOfTypeID = value; }
        public string StrFrmID { get => _StrFrmID; set => _StrFrmID = value; }
        public bool BFull { get => _BFull; set => _BFull = value; }
        public bool BView { get => _BView; set => _BView = value; }
        public bool BAdd { get => _BAdd; set => _BAdd = value; }
        public bool BUpdate { get => _BUpdate; set => _BUpdate = value; }
        public bool BDelete { get => _BDelete; set => _BDelete = value; }
        public bool BAccess { get => _BAccess; set => _BAccess = value; }
    }
}
