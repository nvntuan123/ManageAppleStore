﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppleStore_DTO
{
    public class FrmsDTO
    {
        private string _StrFrmID;
        private string _StrFrmName;

        public FrmsDTO()
        {
            _StrFrmID = string.Empty;
            _StrFrmName = string.Empty;
        }

        public FrmsDTO(string strFrmID = null, string strFrmName = null)
        {
            _StrFrmID = strFrmID;
            _StrFrmName = strFrmName;
        }

        public string StrFrmID { get => _StrFrmID; set => _StrFrmID = value; }
        public string StrFrmName { get => _StrFrmName; set => _StrFrmName = value; }
    }
}
