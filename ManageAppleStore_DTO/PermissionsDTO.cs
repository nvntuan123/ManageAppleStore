using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class PermissionsDTO
    {
        private string _StrPermissionID;
        private string _StrFrmID;
        private bool _BFull;
        private bool _BAdd;
        private bool _BDelete;
        private bool _BUpdate;
        private bool _BView;

        public string StrPermissionID { get => _StrPermissionID; set => _StrPermissionID = value; }
        public string StrFrmID { get => _StrFrmID; set => _StrFrmID = value; }
        public bool BFull { get => _BFull; set => _BFull = value; }
        public bool BAdd { get => _BAdd; set => _BAdd = value; }
        public bool BDelete { get => _BDelete; set => _BDelete = value; }
        public bool BUpdate { get => _BUpdate; set => _BUpdate = value; }
        public bool BView { get => _BView; set => _BView = value; }
    }
}
