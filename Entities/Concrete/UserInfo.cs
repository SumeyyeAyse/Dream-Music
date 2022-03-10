using System.Collections;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class UserInfo
    {
        public int UsersID { get; set; }
        public string UsersName { get; set; }
        public string UsersSurname { get; set; }
        public string UsersEmail { get; set; }
        public int UsersPhoneNum { get; set; }
        public string UsersCBank { get; set; }
        public int UsersBankNum { get; set; }
        public IEnumerable<BankInfo> BankInfos { get; set; }

    }
}
