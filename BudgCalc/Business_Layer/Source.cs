using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgCalc.Business_Layer
{
    public class Source
    {

        private int sourceid;
        private string sourcename;

        public int SourceID
        {
            get { return sourceid; }
            set { sourceid = value; }

        }

        public string SourceName
        {
            get { return sourcename; }
            set { sourcename = value; }
        }

        public Source() { }

        public Source(int sourceid, string sourcename)
        {
            SourceID = sourceid;
            SourceName = sourcename;
        }

    }
}
