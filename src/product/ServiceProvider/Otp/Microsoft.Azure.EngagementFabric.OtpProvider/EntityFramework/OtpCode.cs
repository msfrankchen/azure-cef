//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.EngagementFabric.OtpProvider.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class OtpCode
    {
        public string PhoneNumber { get; set; }
        public string EngagementAccount { get; set; }
        public string Code { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime ExpiredTime { get; set; }
    }
}
