using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_ResourceManager
{
   public static class BusinessManager
    {

        #region "suppliers_get_table"

        /// <summary>
        ///     Determines if the user exists
        /// </summary>
        /// <returns></returns>
        /// <history>
        ///     [hpool] 18-oct-2019 Created
        /// </history>
        public static bool suppliers_get_table(String _code)
        {
            return DataAccess_ResourceManager.dbo.DAsuppliers.suppliers_get_table(_code);
        }

        #endregion
        #region "suppliers_get_table"

        /// <summary>
        ///     Determines if the user exists
        /// </summary>
        /// <returns></returns>
        /// <history>
        ///     [hpool] 18-oct-2019 Created
        /// </history>
        public static Entity_ResourceManager.dbo.suppliers suppliers_get_table(Entity_ResourceManager.dbo.suppliers _registeredCode)
        {
            return DataAccess_ResourceManager.dbo.DAsuppliers.suppliers_get_table(_registeredCode);
        }

        #endregion

    }
}
