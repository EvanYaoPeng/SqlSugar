using OrmTest;
using OrmTest.PerformanceTesting;
using OrmTest.UnitTest;
using SqlSugar;
using System;

namespace SqlSeverTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //    /***Unit Test***/

            //   new Select(1).Init();
            //new Field(1).Init();
            // new Where(1).Init();
            //new Method(1).Init();
            //new JoinQuery(1).Init();
            //new SingleQuery(1).Init();
            //new SelectQuery(1).Init();
            //new AutoClose(1).Init();
            //new Insert(1).Init();
            //new Delete(1).Init();
            //new Update(1).Init();
            //new Mapping(1).Init();
            //new DataTest(1).Init();
            //new EnumTest(1).Init();
            ///***Performance Test***/
            //new SqlSugarPerformance(100).Select();

            //SqlSugarClient db = new SqlSugarClient(new ConnectionConfig() { ConnectionString = Config.ConnectionString, DbType = DbType.SqlServer, IsAutoCloseConnection = true });
            //var item= db.SqlQueryable<OrmTest.Models.WF_CARD_RECORD>("SELECT *FROM WF_CARD_RECORD where id=1").First();
            //string str = db.Utilities.SerializeObject(item);

            ///***Demo***/
            //OrmTest.Demo.Query.Init();
            //OrmTest.Demo.Insert.Init();
            //OrmTest.Demo.Delete.Init();
            //OrmTest.Demo.Update.Init();
            OrmTest.Demo.DbFirst.Init();
            //OrmTest.Demo.JoinSql.Init();
            //OrmTest.Demo.Filter.Init();
            //OrmTest.Demo.ComplexModel.Init();
            OrmTest.Demo.CodeFirst.Init();
        }
    }
}
