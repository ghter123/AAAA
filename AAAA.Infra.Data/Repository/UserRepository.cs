using AAAA.Domain;
using AAAA.Domain.Interfaces;
using AAAA.Infra.Data.Context;
using System.Linq;

namespace AAAA.Infra.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AAAAContext context) : base(context)
        {

        }
        public User GetByAccount(string account,string password)
        {
            return DBSet.SingleOrDefault(o => o.Account == account && o.Password == password);
        }
    }
}
