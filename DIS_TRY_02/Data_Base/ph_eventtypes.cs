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
    
    public partial class ph_eventtypes
    {
        public ph_eventtypes()
        {
            this.ph_events = new HashSet<ph_events>();
        }
    
        public int id_eventType { get; set; }
        public string Name { get; set; }
        public string NameLatin { get; set; }
    
        public virtual ICollection<ph_events> ph_events { get; set; }
    }
}