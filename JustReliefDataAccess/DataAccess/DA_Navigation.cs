using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using JustReliefDataAccess.DataObject;

namespace JustReliefDataAccess.DataAccess
{
    public class DA_Navigation
    {
        public List<Navigation> GetNavigationList(string location)
        {
            //   DatabaseProviderFactory factory = new DatabaseProviderFactory();
            //   Database db = factory.Create("DefaultConnection");
            Database db = DatabaseFactory.CreateDatabase("JRConnection");
            List<Navigation> ModelNavigation = new List<Navigation>();

            string sqlCommand = "JRS_sel_Navigation";
            DbCommand DbCommand = db.GetStoredProcCommand(sqlCommand);

            //cmd.Parameters.Add(new SqlParameter("@modelCode", modelCode) { SqlDbType = SqlDbType.VarChar });
            //Execute Reader to get the result data
            using (IDataReader reader = db.ExecuteReader(DbCommand))
            {
                if (reader != null)
                {
                    int indexId = reader.GetOrdinal("NavigationId");
                    int indexName = reader.GetOrdinal("NavigationName");
                    int indexLink = reader.GetOrdinal("NavigationLink");
                    int indexImage = reader.GetOrdinal("NavigationImage");
                    int indexDescription = reader.GetOrdinal("NavigationDescription");
                    int indexLevel = reader.GetOrdinal("NavigationLevel");

                    while (reader.Read())
                    {
                        ModelNavigation.Add(new Navigation
                        {
                            NavigationId = reader.GetInt32(indexId),
                            NavigationName = reader.GetString(indexName),
                            NavigationLink = reader.GetString(indexLink),
                            NavigationImage = reader.GetString(indexImage),
                            NavigationDescription = reader.GetString(indexDescription),
                            NavigationLevel = reader.GetInt32(indexLevel)
                           
                            //If(IsDBNull(myDataRecord.Item("CenterID")), 0, Convert.ToInt32(myDataRecord.Item("CenterID"))

                        });
                    }
                    reader.Close();
                }
            }

            return ModelNavigation;
        }
    }
}
