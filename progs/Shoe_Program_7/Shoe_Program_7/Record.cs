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
        // default constructor
        public Record() { }
       

        // parameterized constructor
        public Record(int id, string name, int qtyReq, int qty, string practice) { }
       
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
