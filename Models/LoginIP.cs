//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoginIP
    {
        public int id { get; set; }
        public string extranetIP { get; set; }
        public string ipv4 { get; set; }
        public string city { get; set; }
        public string @operator { get; set; }
        public string hostName { get; set; }
        public string mac { get; set; }
        public string System { get; set; }
        public Nullable<System.DateTime> loginTime { get; set; }
        public Nullable<int> counts { get; set; }
    }
}