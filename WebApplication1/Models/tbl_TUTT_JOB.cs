//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_TUTT_JOB
    {
        public string STT { get; set; }
        public string SoTUTT { get; set; }
        public string HBL { get; set; }
    
        public virtual tbl_HBL tbl_HBL { get; set; }
        public virtual tbl_TUTT tbl_TUTT { get; set; }
    }
}
