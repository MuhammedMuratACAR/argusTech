using argusTech.Business.Interfaces;
using argusTech.DataAccess.Interfaces;
using argusTech.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.Business.Concrete
{
    public class UserManager:GenericManager<User>,IUserService
    {
        private readonly IGenericDal<User> _genericDal;
        public UserManager(IGenericDal<User> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
