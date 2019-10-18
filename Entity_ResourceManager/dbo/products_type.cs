using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_ResourceManager.dbo
{
    public class products_type
    {
        #region Properties

        public int id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public DateTime registration_date { get; set; }
        public DateTime update_record { get; set; }
        public string user_registration { get; set; }

        #endregion

        #region Constructor

        public products_type()
        {

            id = 0;
            code = String.Empty;
            description = String.Empty;
            status = String.Empty;
            registration_date = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            update_record = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            user_registration = String.Empty;

        }

        #endregion

        #region extract_data

        public void ExtractData(System.Data.DataRow _dataRow)
        {

            id = (int)_dataRow["id"];
            code = _dataRow["code"].ToString();
            description = _dataRow["description"].ToString();
            status = _dataRow["status"].ToString();
            registration_date = (DateTime)_dataRow["registration_date"];
            update_record = (DateTime)_dataRow["update_record"];
            user_registration = _dataRow["user_registration"].ToString();

        }

        #endregion

        #region extract_data

        public void ExtractData(System.Data.SqlClient.SqlDataReader _dataRow)
        {

            id = (int)_dataRow["id"];
            code = _dataRow["code"].ToString();
            description = _dataRow["description"].ToString();
            status = _dataRow["status"].ToString();
            registration_date = (DateTime)_dataRow["registration_date"];
            update_record = (DateTime)_dataRow["update_record"];
            user_registration = _dataRow["user_registration"].ToString();

        }

        #endregion

        //#region StringLine

        //public String StringLine()
        //{

        //    return "tabla: [registered_users] >>" +
        //    " [code]: " + code +
        //    " [login]: " + login +
        //    " [first_name]: " + first_name +
        //    " [first_surname]: " + first_surname +
        //    " [last_surname]: " + last_surname +
        //    " [email]: " + email +
        //    " [telephone]: " + telephone +
        //    " [address_street]: " + address_street +
        //    " [address_internal_number]: " + address_internal_number +
        //    " [address_outdoor_numer]: " + address_outdoor_numer +
        //    " [address_crossings]: " + address_crossings +
        //    " [address_colony]: " + address_colony +
        //    " [address_municipality]: " + address_municipality +
        //    " [address_state]: " + address_state +
        //    " [address_country]: " + address_country +
        //    " [password]: " + password +
        //    " [status]: " + status;

        //}

        //#/*endregion*/
    }
}

