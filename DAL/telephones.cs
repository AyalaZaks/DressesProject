//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class telephones
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public long telephone_number { get; set; }
    
        public virtual customers customers { get; set; }
    }
}
