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
    
    public partial class un_messages
    {
        public int id_message { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public System.DateTime Timestamp { get; set; }
        public bool IsSent { get; set; }
        public Nullable<int> id_person { get; set; }
    
        public virtual un_persons un_persons { get; set; }
    }
}