//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Core_Module
    {
        public System.Guid ID { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string ModuleUrl { get; set; }
        public Nullable<System.Guid> ParentModuleID { get; set; }
        public string ModuleImg { get; set; }
        public Nullable<int> ModuleDeep { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}
