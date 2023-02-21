using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Etc {
    public class Limits {

        #region Employee / Customer Shared Limits
        public int _maxEmpNameSize = 20;
        public int _maxSurnameSize = 20;
        #endregion
        #region Customer Exclusive Limits
        public int _maxCardSize = 20;
        public char _firstCardChar = 'A';
        #endregion
        #region Employee Exclusive Limits
        public int _maxUsernameSize = 20;
        public int _maxPasswordSize = 256;
        public decimal _maxDecimal = 99999.99m;
        #endregion
        #region Item Limits
        public int _maxCodeSize = 6;
        public int _maxDesctiptionSize = 30;
        #endregion
        #region roster limits
        public int MaxManagers = 3;
        public int MaxStaff = 10;
        public int MaxCashiers = 4;
        #endregion
    }
}
