//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBTI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Response
    {
        public int TestId { get; set; }
        public string QuestionId { get; set; }
        public Nullable<int> Grade { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual Test Test { get; set; }
    }
}
