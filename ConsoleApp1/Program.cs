using System;
using System.Data;
using System.Linq;
using Dapper;
using NetTopologySuite.Geometries;
using Npgsql;
using NpgsqlTypes;

namespace ConsoleApp1
{
    class Program
    {
        private static IDbConnection Db;
        static void Main(string[] args)
        {
            // setup npgsql geography data type mapper
            NpgsqlConnection.GlobalTypeMapper.UseNetTopologySuite();
            // mapper for Dapper
            SqlMapper.AddTypeHandler(new GeographyTypeMapper());
            
            Db = new NpgsqlConnection("Server=localhost;Port=5432;Database=db;User Id=postgres; Password=password;");
            Db.Open();
            
            try
            {
                var doesTableExist = (bool)Db.ExecuteScalar("SELECT EXISTS (SELECT FROM information_schema.tables WHERE table_schema = 'public' AND table_name = 'test');");
                if (!doesTableExist)
                {
                    Console.WriteLine($"{DateTime.Now:H:mm:ss.fff} Creating table with data...");
                    var records = Db.Execute(Sql.Bootstrap);
                    Console.WriteLine($"{DateTime.Now:H:mm:ss.fff} {records} records affected");
                }
                Console.WriteLine($"{DateTime.Now:H:mm:ss.fff} Hello World! Getting data now...");

                // This fails. Add the LIMIT 20 and then it works
                var s = Sql.SelectData; // + " LIMIT 20";
                var list = Db.Query<DataModel>(s);

                Console.WriteLine($"{DateTime.Now:H:mm:ss.fff} Data successfully retrieved. Got {list.Count()} records");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    
    public class GeographyTypeMapper : SqlMapper.TypeHandler<Point>
    {
        public override void SetValue(IDbDataParameter parameter, Point value)
        {
            if (parameter is NpgsqlParameter npgsqlParameter)
            {
                npgsqlParameter.NpgsqlDbType = NpgsqlDbType.Geography;
                npgsqlParameter.NpgsqlValue = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override Point Parse(object value)
        {
            if (value is Point geometry)
            {
                return geometry;
            }

            throw new ArgumentException();
        }
    }
}