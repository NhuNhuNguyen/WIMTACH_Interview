using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MyCollegeV1.Models
{
    public class College : FullAuditedEntity<int>, IPassivable
    {
        public College()
        {
            this.IsActive = true;
            this.CreationTime = DateTime.Now;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string GPSLatitude { get; set; }

        public string Longitude { get; set; }

        public string ContactEmail { get; set; }

        public bool IsSleep { get; set; }

        public bool NguyenReasonDescription { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}