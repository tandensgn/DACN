using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class UserDao
    {
        DACN_SalePhoneDbContext db = null;
        public UserDao()
        {
            db = new DACN_SalePhoneDbContext();
        }
        public long Insert(user entity)
        {
            db.users.Add(entity);
            db.SaveChanges();
            return entity.us_id;
        }
        public bool Login(string userName, string passWord)
        {
            var result = db.users.Count(x => x.us_name == userName && x.us_password == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
