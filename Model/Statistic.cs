//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Statistic
    {
        public System.Guid Id { get; set; }
        public string IPAddress { get; set; }
        public string URL { get; set; }
        public Nullable<System.Guid> LanguageId { get; set; }
        public Nullable<int> VisitCount { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public string Browser { get; set; }
        public string Description { get; set; }
    }
}
