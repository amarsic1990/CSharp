//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstVidzy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public byte GenreId { get; set; }
        public Nullable<Classification> Classification { get; set; }
    }
}
