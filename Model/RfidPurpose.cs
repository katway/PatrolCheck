using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class RfidPurpose
    {
        public RfidPurpose()
        { }
        #region Model
        private int purposeCode;

        public int PurposeCode
        {
            get { return purposeCode; }
            set { purposeCode = value; }
        }


        private string purposeName;

        public string PurposeName
        {
            get { return purposeName; }
            set { purposeName = value; }
        }

       
        
        #endregion Model


    }
}
