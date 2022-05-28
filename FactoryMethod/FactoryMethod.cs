using Pruebas.FactoryMethod.Creator;

namespace Pruebas.FactoryMethod
{
    public static class FactoryMethod
    {
        public static void Execute()
        {
            DBManager<string> dbOracleManager = new OracleManager<string>();
            IDataBase<string> dataOracle = dbOracleManager.DataBase();
            dataOracle.Add("Harlin");

            dataOracle.GetAll();

            DBManager<string> dbMySqlManager = new MySqlManager<string>();
            IDataBase<string> dataMySql = dbMySqlManager.DataBase();
            dataMySql.Add("Harlin");

            dataMySql.GetAll();
        }
    }
}
