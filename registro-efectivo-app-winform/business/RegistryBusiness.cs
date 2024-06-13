using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using domain;


namespace business
{
    public class RegistryBusiness
    {
        public List<Registry> toList()
        {
            List<Registry> registriesList = new List<Registry>();
            DataAccess data = new DataAccess();

            try
            {
                string query = "Select Id, DateRegistry, Amount, TypeCoin, Entity, IsActive From REGISTRIES";
                data.setQuery(query);
                data.executeReader();

                mapOutRegistry(data.Reader,registriesList);

                data.closeConnection();

                return registriesList;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void mapOutRegistry(SqlDataReader reader, List<Registry> registries)
        {
            try
            {
                while (reader.Read())
                {
                    Registry registry = new Registry();
                    registry.Id = (int)reader["Id"];
                    registry.Date = (DateTime)reader["DateRegistry"];
                    registry.Amount = (Decimal)reader["Amount"];
                    registry.TypeCoin = (string)reader["TypeCoin"];
                    registry.Entity = (string)reader["Entity"];
                    registry.Active = (bool)reader["IsActive"];

                    registries.Add(registry);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
