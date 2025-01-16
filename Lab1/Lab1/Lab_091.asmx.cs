using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab1
{
    /// <summary>
    /// Summary description for Lab_091
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Lab_091 : System.Web.Services.WebService
    {
        private readonly string connectionString = "Data Source=LAPTOP-THIENBAO\\MSSQLSERVER01;Initial Catalog=world;Integrated Security=True;TrustServerCertificate=True";

        private List<Dictionary<string, object>> SQLExecutor(string query, params SqlParameter[] parameters)
        {
            var results = new List<Dictionary<string, object>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null) command.Parameters.AddRange(parameters);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }
            return results;
        }

        public class Country
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Continent { get; set; }
            public string Region { get; set; }
            public int Population { get; set; }
        }
        private List<Country> ConvertToCountries(List<Dictionary<string, object>> data)
        {
            var countries = new List<Country>();
            foreach (var row in data)
            {
                countries.Add(new Country
                {
                    Code = row["Code"].ToString(),
                    Name = row["Name"].ToString(),
                    Continent = row["Continent"].ToString(),
                    Region = row["Region"].ToString(),
                    Population = Convert.ToInt32(row["Population"])
                });
            }
            return countries;
        }
        public class City
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string CountryCode { get; set; }
            public string District { get; set; }
            public int Population { get; set; }
        }

        private List<City> ConvertToCities(List<Dictionary<string, object>> data)
        {
            var cities = new List<City>();
            foreach (var row in data)
            {
                cities.Add(new City
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    CountryCode = row["CountryCode"].ToString(),
                    District = row["District"].ToString(),
                    Population = Convert.ToInt32(row["Population"])
                });
            }
            return cities;
        }
        [WebMethod]
        public List<Country> GetAllCountries()
        {
            string query = "SELECT * FROM country";
            var result = SQLExecutor(query);
            return ConvertToCountries(result);
        }

        [WebMethod]
        public Country GetCountryByCode(string code)
        {
            string query = "SELECT * FROM country WHERE Code = @Code";
            var result = SQLExecutor(query, new SqlParameter("@Code", code));
            return ConvertToCountries(result).FirstOrDefault();
        }

        [WebMethod]
        public City GetCityByName(string name)
        {
            string query = "SELECT * FROM city WHERE LTRIM(RTRIM(Name)) = @Name";
            var result = SQLExecutor(query, new SqlParameter("@Name", name));
            return ConvertToCities(result).FirstOrDefault();
        }

        [WebMethod]
        public List<City> GetAllCitiesByCountryCode(string countryCode)
        {
            string query = "SELECT * FROM city WHERE CountryCode = @CountryCode";
            var result = SQLExecutor(query, new SqlParameter("@CountryCode", countryCode));
            return ConvertToCities(result);
        }
        [WebMethod]
        public string GetPresidentName(string code)
        {
            string query = "SELECT HeadOfState FROM country WHERE Code = @CountryCode";
            var result = SQLExecutor(query, new SqlParameter("@CountryCode", code));

            if (result.Count > 0 && result[0].ContainsKey("HeadOfState") && result[0]["HeadOfState"] != DBNull.Value)
            {
                return result[0]["HeadOfState"].ToString();
            }
            return "President information not available.";
        }
    }
}
