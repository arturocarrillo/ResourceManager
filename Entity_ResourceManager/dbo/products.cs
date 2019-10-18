using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_ResourceManager.dbo
{
    public class products
    {
        #region Properties

        public int id                             { get; set; }
        public string code                        { get; set; }
        public string   supplier_code               { get; set; }
        public DateTime invoice_date              { get; set; }
        public string   invoice_folio               { get; set; }
        public DateTime print_date                { get; set; }
        public string description                 { get; set; }
        public string description_short_code      { get; set; }
        public string description_short           { get; set; }
        public double history_value               { get; set; }
        public string  serial_number              { get; set; }
        public string  direction_assigned         { get; set; }
        public string  direction_cost_center      { get; set; }
        public string  department_assigned        { get; set; }
        public string  department_cost_center     { get; set; }
        public string  product_type               { get; set; }
        public string  family                     { get; set; }
        public string  group                      { get; set; }
        public string  locataion                  { get; set; }
        public string  color                      { get; set; }
        public string  state                      { get; set; }
        public string  code_previous              { get; set; }
        public string  trademark                  { get; set; }
        public string  observation                { get; set; }
        public string  responsible                { get; set; }
        public string director_name              { get; set; }
        public string status { get; set; }
        public DateTime registration_date { get; set; }
        public DateTime update_record { get; set; }
        public string user_registration { get; set; }

        #endregion

        #region Constructor

        public products()
        {

            id = 0;
            code                                 = String.Empty;
            supplier_code                        = String.Empty;
            invoice_date                         = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            invoice_folio                        = String.Empty;
            print_date                           = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            description                          = String.Empty;
            description_short_code               = String.Empty;
            description_short                    = String.Empty;
            history_value                        = 0 ;
            serial_number                       = String.Empty;
            direction_assigned                  = String.Empty;
            direction_cost_center               = String.Empty;
            department_assigned                 = String.Empty;
            department_cost_center              = String.Empty;
            product_type                        = String.Empty;
            family                              = String.Empty;
            group                               = String.Empty;
            locataion                           = String.Empty;
            color                               = String.Empty;
            state                               = String.Empty;
            code_previous                       = String.Empty;
            trademark                           = String.Empty;
            observation                         = String.Empty;
            responsible                         = String.Empty;
            director_name                        = String.Empty;
            status = String.Empty;
            registration_date = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            update_record = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            user_registration = String.Empty;

        }

        #endregion

        #region extract_data

        public void ExtractData(System.Data.DataRow _dataRow)
        {

            id                               = (int)_dataRow["id"];
            code                             = _dataRow["code"].ToString();
            supplier_code                    = _dataRow["supplier_code"].ToString();
            invoice_date                     = (DateTime)_dataRow["invoice_date"];
            invoice_folio                    = _dataRow["invoice_folio"].ToString();
            print_date                       = (DateTime)_dataRow["print_date"];
            description                      = _dataRow["description"].ToString();
            description_short_code           = _dataRow["description_short_code"].ToString();
            description_short                = _dataRow["description_short"].ToString();
            history_value                    = Convert.ToDouble(_dataRow["history_value"]);
            serial_number                    = _dataRow["serial_number"].ToString();
            direction_assigned               = _dataRow["direction_assigned"].ToString();
            direction_cost_center            = _dataRow["direction_cost_center"].ToString();
            department_assigned              = _dataRow["department_assigned"].ToString();
            department_cost_center           = _dataRow["department_cost_center"].ToString();
            product_type                     = _dataRow["product_type"].ToString();
            family                           = _dataRow["family"].ToString();
            group                            = _dataRow["group"].ToString();
            locataion                        = _dataRow["locataion"].ToString();
            color                            = _dataRow["color"].ToString();
            state                            = _dataRow["state"].ToString();
            code_previous                    = _dataRow["code_previous"].ToString();
            trademark                        = _dataRow["trademark"].ToString();
            observation                      = _dataRow["observation"].ToString();
            responsible                      = _dataRow["responsible"].ToString();
            director_name                    = _dataRow["code"].ToString();
            status                           = _dataRow["status"].ToString();
            registration_date                = (DateTime)_dataRow["registration_date"];
            update_record                    = (DateTime)_dataRow["update_record"];
            user_registration                = _dataRow["user_registration"].ToString();

        }

        #endregion

        #region extract_data

        public void ExtractData(System.Data.SqlClient.SqlDataReader _dataRow)
        {

            id = (int)_dataRow["id"];
            code = _dataRow["code"].ToString();
            supplier_code = _dataRow["supplier_code"].ToString();
            invoice_date = (DateTime)_dataRow["invoice_date"];
            invoice_folio = _dataRow["invoice_folio"].ToString();
            print_date = (DateTime)_dataRow["print_date"];
            description = _dataRow["description"].ToString();
            description_short_code = _dataRow["description_short_code"].ToString();
            description_short = _dataRow["description_short"].ToString();
            history_value = Convert.ToDouble(_dataRow["history_value"]);
            serial_number = _dataRow["serial_number"].ToString();
            direction_assigned = _dataRow["direction_assigned"].ToString();
            direction_cost_center = _dataRow["direction_cost_center"].ToString();
            department_assigned = _dataRow["department_assigned"].ToString();
            department_cost_center = _dataRow["department_cost_center"].ToString();
            product_type = _dataRow["product_type"].ToString();
            family = _dataRow["family"].ToString();
            group = _dataRow["group"].ToString();
            locataion = _dataRow["locataion"].ToString();
            color = _dataRow["color"].ToString();
            state = _dataRow["state"].ToString();
            code_previous = _dataRow["code_previous"].ToString();
            trademark = _dataRow["trademark"].ToString();
            observation = _dataRow["observation"].ToString();
            responsible = _dataRow["responsible"].ToString();
            director_name = _dataRow["code"].ToString();
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
