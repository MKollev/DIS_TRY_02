//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIS_TRY_02.Data_Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class un_studytypes
    {
        public un_studytypes()
        {
            this.ph_assignments = new HashSet<ph_assignments>();
            this.ph_assignmentshistory = new HashSet<ph_assignmentshistory>();
        }
    
        public int id_studyType { get; set; }
        public string Name { get; set; }
        public string NameLatin { get; set; }
        public string NameShort { get; set; }
        public Nullable<int> MonCode { get; set; }
    
        public virtual ICollection<ph_assignments> ph_assignments { get; set; }
        public virtual ICollection<ph_assignmentshistory> ph_assignmentshistory { get; set; }
    }
}