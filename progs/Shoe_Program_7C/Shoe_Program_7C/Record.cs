using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Program_7C
{
    [Serializable]
    public class Record
    {
        // these variables must be declared in Record order. It matters!
        private int id;
        private string name;
        private int qtyReq;
        private int qty;
        private string practice;

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
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Practice
        {
            get { return practice; }
            set { practice = value; }
        }

        public int QtyReq
        {
            get { return qtyReq; }
            set { qtyReq = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
    }
}
