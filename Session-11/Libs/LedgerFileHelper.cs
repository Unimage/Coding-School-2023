using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    internal class LedgerFileHelper
    {
        public int Year { get; set; }
        public int Month { get; set; }



        public LedgerFileHelper(int year , int month )
        {
            this.Year= year;
            this.Month= month;

        }


        public void  AppendToLedger()
        {

        }




    }


   


}
