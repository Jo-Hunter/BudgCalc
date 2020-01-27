using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgCalc.Business_Layer
{
    class Transaction
    {

        private int categoryid, sourceid;
        private string categoryname, description;
        private double amount;

        public int CategoryID
        {
            get { return categoryid; }
            set { categoryid = value; }
        }

        public int SourceID
        {
            get { return sourceid; }
            set { sourceid = value; }
        }

        public string CategoryName
        {
            get { return categoryname; }
            set { categoryname = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Transaction() { }

        public Transaction(int categoryid, string categoryname, string description, double amount, int sourceid)
        {
            CategoryID = categoryid;
            CategoryName = categoryname;
            Description = description;
            Amount = amount;
            SourceID = sourceid;
        }
    }
}
