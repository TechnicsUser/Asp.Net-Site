//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int MessageId { get; set; }
        public string Title { get; set; }
        public int MessageType { get; set; }
        public string MessageTo { get; set; }
        public string MessageFrom { get; set; }
        public string UserId { get; set; }
        public bool IsDismissed { get; set; }
    }
}
