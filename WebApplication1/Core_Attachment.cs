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
    
    public partial class Core_Attachment
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> RefID { get; set; }
        public string FileSubject { get; set; }
        public string DisplayName { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string FilePath { get; set; }
        public string ContentType { get; set; }
        public Nullable<int> Length { get; set; }
        public byte[] ByteContent { get; set; }
        public Nullable<int> TypeCode { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}