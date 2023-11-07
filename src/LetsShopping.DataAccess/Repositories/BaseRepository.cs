namespace LetsShopping.DataAccess.Repositories
{
    public class BaseRepository
    {
        protected readonly SqlConnection _connection;
        public BaseRepository()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            this._connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = LetsShopDB; Trusted_Connection = True;");
            

        }
    }
}
