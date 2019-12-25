using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   [TableName("HR_SMSInfo")]
   public class HR_SMSInfo:ParentClass
    {
      
        public string UserCode { get; set; }
        public string Phone { get; set; }
        public string Contents { get; set; }
        public string CacheKey { get; set; }
        public DateTime? CreatDate { get; set; }

    }
}
