using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgCalc.Business_Layer
{
    class Transaction
    {

        private int categoryid, sourceid, period;
        private string categoryname, description;
        private double amount;
        private bool iscredit;

        public bool IsCredit
        {
            get { return iscredit; }
            set { iscredit = value; }
        }

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

        public int Period
        {
            get { return period; }
            set { period = value; }
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

        public Transaction(int categoryid, string categoryname, string description, double amount, int sourceid, int period, bool iscredit)
        {
            CategoryID = categoryid;
            CategoryName = categoryname;
            Description = description;
            Amount = amount;
            SourceID = sourceid;
            Period = period;
            IsCredit = iscredit;
        }
    }
}
