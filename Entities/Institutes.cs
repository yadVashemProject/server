using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Institutes
    {
        public string? name { get; set; }
        public bool? isNotWithCharge { get; set; }
        public bool? isPayingInstitution { get; set; }
        public addressInfo? addressInfo { get; set; }
        public communicationInfo? communicationInfo { get; set; }
        public int? educationType { get; set; }
        public ageGroup? ageGroup { get; set; }
        public int? companyNumber { get; set; }
        public int? institutionCode { get; set; }
        public string? institutionSymbol { get; set; }
        public int? institutionCompanyNumberOrSymbol { get; set; }
        public string? sushaimeCode { get; set; }
        public string? almogCode { get; set; }
        public institutionType? institutionType { get; set; }
        public bool? isWithPayingInstitution { get; set; }
        public int? city { get; set; }
        public int? address { get; set; }
        public bool? isBlockedForReservation { get; set; }
        public string? id { get; set; }
        public bool? isDeleted { get; set; }
        public bool? isDirty { get; set; }
        public bool? isCanceled { get; set; }
        public bool? isActive { get; set; }
        public int? createdOn { get; set; }
    }
}
