using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class TypesDTO
    {
        protected string _StrID;
        protected string _StrName;
        protected bool _BStatus;

        public TypesDTO()
        {
            _StrID = string.Empty;
            _StrName = string.Empty;
            _BStatus = false;
        }

        public TypesDTO(string strID, string strName, bool bStatus)
        {
            _StrID = strID;
            _StrName = strName;
            _BStatus = bStatus;
        }

        public string StrID { get => _StrID; set => _StrID = value; }
        public string StrName { get => _StrName; set => _StrName = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
