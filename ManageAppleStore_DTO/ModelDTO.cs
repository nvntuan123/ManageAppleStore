using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class ModelDTO
    {
        private string _StrModelID;
        private string _StrModelName;
        private bool _BStatus;

        public string StrModelID { get => _StrModelID; set => _StrModelID = value; }
        public string StrModelName { get => _StrModelName; set => _StrModelName = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
