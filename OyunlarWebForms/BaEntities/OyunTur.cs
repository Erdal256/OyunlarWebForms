//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OyunlarWebForms.BaEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class OyunTur
    {
        public int Id { get; set; }
        public int OyunId { get; set; }
        public int TurId { get; set; }
    
        public virtual Oyun Oyun { get; set; }
        public virtual Tur Tur { get; set; }
    }
}
