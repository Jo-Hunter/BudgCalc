using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgCalc.Business_Layer;
using BudgCalc.Presentation_Layer;
using System.Collections;

namespace BudgCalc
{
    class Global_Variable
    {

        

        public static Transaction transact;
        public static double selectedAmount;
        // tally_arr is a list of arrays which are all 3 long.
        // 0 is categoryID
        public static List<object[]> tally_arr;
        public static int currentPeriod;
        public static int budgetID;
        public static int transactionID;
        public static int sourceID = 0;

    }
}
