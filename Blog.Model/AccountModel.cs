using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blog.Model
{
    [DataContract]
    public class AccountModel : BaseModel<AccountModel>
    {
        [DataMember]
        public string UserName { get; set; }


        [DataMember]
        public string Password { get; set; }
    }
}
