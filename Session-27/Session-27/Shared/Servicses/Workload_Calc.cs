using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_27.Model;
using Session_27.EF.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace Session_27.Shared
{
    public class Workload_Calc
    {
        //Max Day Workload
        public decimal MaximumDayWorkload(IEntityRepo<Engineer> engineerRepo)
        {
            var engineers = engineerRepo.GetAll().ToList();
            decimal maxDayWorkload = engineers.ToList().Count() * 8;

            return maxDayWorkload;
        }

        //Tasks -  Engineers check
        public void MaxTaskCheck(IEntityRepo<Engineer> engineerRepo, IEntityRepo<TransactionLine> transLineRepo, IEntityRepo<Transaction> transactionRepo)
        {
            decimal maxHoursCheck = 0;
            bool engineerAvailable = true;
            Dictionary<int, bool> EngiAvail = new Dictionary<int, bool>();

            var engineers = engineerRepo.GetAll().ToList();
            int maxTasks = engineers.Count();

            var transLine = transLineRepo.GetAll();
            var transactions = transactionRepo.GetAll();

            //Set the max Work
            decimal maxWork = MaximumDayWorkload(engineerRepo);
            foreach (var engi in engineers) { EngiAvail.Add(engi.Id, engineerAvailable); }

            foreach (var trans in transactions)
            {
                foreach (var tl in transLine)
                {   
                    if (maxTasks > 0 && maxHoursCheck < maxWork)
                    { 
                        maxHoursCheck += tl.Hours;
                        maxTasks--;
                        int firstKey = EngiAvail.Keys.First();
                        bool firstValue = EngiAvail[firstKey];
                        EngiAvail[firstKey] = false;

                        EngiAvail.Remove(firstKey);
                        EngiAvail.Add(firstKey, firstValue);
                    }
                    else
                    {   //make engineers available again and also maxtasks
                        foreach (var key in EngiAvail.Keys) { EngiAvail[key] = true; }
                        maxTasks = EngiAvail.Count;
                        maxHoursCheck = 0;
                        break;
                    }    
                
                }
            }
        }

       // public 












    }


}


