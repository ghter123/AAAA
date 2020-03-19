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
        public User GetByAccount(string account)
        {
            return DBSet.FirstOrDefault(o => o.Account == account);
        }
    }
}
