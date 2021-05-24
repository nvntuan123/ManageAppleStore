using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class CustomerOfTypesDTO : TypesDTO
    {
        private int _IDeceleraPercent;

        public CustomerOfTypesDTO() : base()
        {
            _IDeceleraPercent = 0;
        }

        public CustomerOfTypesDTO(string strID, string strName, bool bStatus, int iDeceleraPercent) : base(strID, strName, bStatus)
        {
            _IDeceleraPercent = iDeceleraPercent;
        }

        public int IDeceleraPercent { get => _IDeceleraPercent; set => _IDeceleraPercent = value; }
    }
}
