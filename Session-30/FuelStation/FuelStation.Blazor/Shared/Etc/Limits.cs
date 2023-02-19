using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Etc {
    public class Limits {

        #region Employee / Customer Shared Limits
        private int _maxEmpNameSize = 20;
        private int _maxSurnameSize = 20;
        #endregion
        #region Customer Exclusive Limits
        private int _maxCardSize = 20;
        private char _firstCardChar = 'A';
        #endregion
        #region Employee Exclusive Limits
        private int _maxUsernameSize = 20;
        private int _maxPasswordSize = 256;
        private decimal _maxDecimal = 99999.99m;
        #endregion
        #region Item Limits
        private int _maxCodeSize = 6;
        private int _maxDesctiptionSize = 30;
        #endregion
    }
}
