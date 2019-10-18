using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_ResourceManager.dbo
{
    public class DAsuppliers
    {
        #region "suppliers_get_table"

        /// <summary>
        ///     Determines if the user exists
        /// </summary>
        /// <returns></returns>
        /// <history>
        ///     [hpool] 18-oct-2019 Created
        /// </history>
        public Entity_ResourceManager.dbo.suppliers suppliers_get_table(String code)
        {

            string consulta = "dbo.sp_suppliers_get_table";
            System.Data.SqlClient.SqlParameter[] Params = { new System.Data.SqlClient.SqlParameter("@code", code) };

            Data_Connection.Connection_SQL cBaseDatos = new Data_Connection.Connection_SQL();
            System.Data.DataTable _datos = cBaseDatos.SelectFromStoreProcedure(DataAccess_ResourceManager.main_program.gSQLconexion, consulta, Params);

            if (_datos.Equals(null))
            {
                return null;
            }
            else
            {
                Entity_ResourceManager.dbo.suppliers Registro;

                foreach (System.Data.DataRow _row in _datos.Rows)
                {
                    Registro = new Entity_ResourceManager.dbo.suppliers();
                    Registro.ExtractData(_row);
                    return Registro;
                }
                return null;
            }
        }

        #endregion

        #region "registered_users_save"

        /// <summary>
        ///     Determines if the user exists
        /// </summary>
        /// <returns></returns>
        /// <history>
        ///     [hpool] 18-oct-2019 Created
        /// </history>
        public static Entity_ResourceManager.dbo.suppliers suppliers_get_table(Entity_ResourceManager.dbo.suppliers _registeredCode)
        {

            string consulta = "dbo.sp_suppliers_get_table";

            System.Data.SqlClient.SqlParameter[] Params = {
                new System.Data.SqlClient.SqlParameter("@id", _registeredCode.id),
                new System.Data.SqlClient.SqlParameter("@code", _registeredCode.code),
                new System.Data.SqlClient.SqlParameter("@status", _registeredCode.status),
                new System.Data.SqlClient.SqlParameter("@registration_date", _registeredCode.registration_date),
                new System.Data.SqlClient.SqlParameter("@update_record", _registeredCode.update_record),
                new System.Data.SqlClient.SqlParameter("@user_registration", _registeredCode.user_registration)
                };

            Entity_ResourceManager.dbo.suppliers Registro;
            Data_Connection.Connection_SQL cBaseDatos = new Data_Connection.Connection_SQL();
            DataAccess_ResourceManager.main_program.gSQLconexion.Open();
            System.Data.SqlClient.SqlDataReader _reader = cBaseDatos.InsertUpdateDelete(DataAccess_ResourceManager.main_program.gSQLconexion, consulta, Params);

            if (_reader.HasRows == true)
            {
                if (_reader.Read())
                {
                    Registro = new Entity_ResourceManager.dbo.suppliers();
                    Registro.ExtractData(_reader);
                    DataAccess_ResourceManager.main_program.gSQLconexion.Close();
                    return Registro;
                }
            }

            DataAccess_ResourceManager.main_program.gSQLconexion.Close();
            return null;
        }

        #endregion
    }
}
