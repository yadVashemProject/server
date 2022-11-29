using System;

namespace Entities
{
    public class addressInfo
    {
        public string? city { get; set; }
        public string? address { get; set; }
        public string? zipCode { get; set; }
        public string? mailingAddress { get; set; }
        public country? country { get; set; }
        public string? state { get; set; }
    }
}
