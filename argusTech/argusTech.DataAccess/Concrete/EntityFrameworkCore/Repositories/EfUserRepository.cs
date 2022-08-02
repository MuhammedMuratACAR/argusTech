using argusTech.DataAccess.Interfaces;
using argusTech.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserDal
    {
    }
   
}
