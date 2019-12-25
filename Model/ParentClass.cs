using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ParentClass
    {
        [ColumnName("ID",ColumnType.PrimaryKey)]
        public Guid ID { get; set; }
    }
}
