//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCLogin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class EmployeeInformation
    {
        [DisplayName ("Employee Id")]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        [DisplayName ("E-mail Id")]
        public string E_mail_Id { get; set; }
        public string Designation { get; set; }
        [DisplayName ("Contact Number")]
        public Nullable<int> Contact_Number { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}
