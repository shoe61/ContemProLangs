using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Program_7
{
    [Serializable]
    public class Record
    {
        private int id, qtyReq, qty;
        private string name, practice;

        // default constructor
        public Record() : this(0, "", 0, 0, "") { }

        // parameterized constructor
        public Record(int idValue, string nameValue, int qtyReqValue, int qtyValue, string practiceValue)
        {
            id = idValue;
            name = nameValue;
            qtyReq = qtyReqValue;
            qty = qtyValue;        
        }
       
        //properties
        public int ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Practice
        {
            get { return Practice; }
            set { Practice = value; }
        }
        
        public int QtyReq
        {
            get { return QtyReq; }
            set { QtyReq = value; }
        }

        public int Qty
        {
            get { return Qty; }
            set { Qty = value; }
        }
    }
}
