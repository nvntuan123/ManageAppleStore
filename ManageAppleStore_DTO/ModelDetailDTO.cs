using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class ModelDetailDTO
    {
        private string _StrModelDetailID;
        private string _StrModelDetailName;
        private string _StrSpecifications;
        private string _StrDescription;

        public ModelDetailDTO()
        {
            _StrModelDetailID = string.Empty;
            _StrModelDetailName = string.Empty;
            _StrSpecifications = string.Empty;
            _StrDescription = string.Empty;
        }

        public ModelDetailDTO(string strModelDetailID = null, string strModelDetailName = null, string strSpecifications = null, string strDescription = null)
        {
            _StrModelDetailID = strModelDetailID;
            _StrModelDetailName = strModelDetailName;
            _StrSpecifications = strSpecifications;
            _StrDescription = strDescription;
        }

        public string StrModelDetailID { get => _StrModelDetailID; set => _StrModelDetailID = value; }
        public string StrModelDetailName { get => _StrModelDetailName; set => _StrModelDetailName = value; }
        public string StrSpecifications { get => _StrSpecifications; set => _StrSpecifications = value; }
        public string StrDescription { get => _StrDescription; set => _StrDescription = value; }
    }
}
