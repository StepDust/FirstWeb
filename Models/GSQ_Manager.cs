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
    
    public partial class GSQ_Manager
    {
        public int Id { get; set; }
        public int Role_Id { get; set; }
        public int Role_Type { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Real_Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Nullable<int> Is_Lock { get; set; }
        public Nullable<System.DateTime> Add_Time { get; set; }
    }
}