using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class PersonDTO
    {
        protected string _StrID;
        protected string _StrFullName;
        protected int _IIDCard;
        protected string _StrNumberPhone;
        protected string _StrEmail;
        protected DateTime? _DTBirthDay = null;
        protected string _StrGender;
        protected string _StrAddress;
        protected bool _BStatus;

        public PersonDTO()
        {
            _StrID = string.Empty;
            _StrFullName = string.Empty;
            _IIDCard = 0;
            _StrNumberPhone = string.Empty;
            _StrEmail = string.Empty;
            _StrGender = string.Empty;
            _StrAddress = string.Empty;
            _BStatus = false;
        }

        public PersonDTO(string strID, string strFullName, int iIDCard, string strNumberPhone, string strEmail, DateTime dTBirthDay, string strGender, string strAddress, bool bStatus)
        {
            _StrID = strID;
            _StrFullName = strFullName;
            _IIDCard = iIDCard;
            _StrNumberPhone = strNumberPhone;
            _StrEmail = strEmail;
            _DTBirthDay = dTBirthDay;
            _StrGender = strGender;
            _StrAddress = strAddress;
            _BStatus = bStatus;
        }

        public string StrID { get => _StrID; set => _StrID = value; }
        public string StrFullName { get => _StrFullName; set => _StrFullName = value; }
        public int IIDCard { get => _IIDCard; set => _IIDCard = value; }
        public string StrNumberPhone { get => _StrNumberPhone; set => _StrNumberPhone = value; }
        public string StrEmail { get => _StrEmail; set => _StrEmail = value; }
        public DateTime? DTBirthDay { get => _DTBirthDay; set => _DTBirthDay = value; }
        public string StrGender { get => _StrGender; set => _StrGender = value; }
        public string StrAddress { get => _StrAddress; set => _StrAddress = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
