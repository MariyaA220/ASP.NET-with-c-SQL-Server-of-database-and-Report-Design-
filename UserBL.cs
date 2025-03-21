using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class UserBL
    {
        public int storestudentinfo(UserBO objBO1)
        {
            UserDA da = new UserDA();
            return da.addstudentinfo(objBO1);
        }

       
        public object Removestudentinfo(UserBO objBO1)
        {
            
            UserDA da = new UserDA();
            return da.deletestudentinfo(objBO1);
        }
      
    }
}
