using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Rfid
    {
        public Rfid()
        { }
        #region Model
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string alias;

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }


        private string rFID;

        public string RFID
        {
            get { return rFID; }
            set { rFID = value; }
        }


        private int purpose;

        public int Purpose
        {
            get { return purpose; }
            set { purpose = value;}
        }

       

       


        #endregion Model

    }
}
