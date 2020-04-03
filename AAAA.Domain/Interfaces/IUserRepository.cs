namespace AAAA.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByAccount(string account,string password);
    }
}
