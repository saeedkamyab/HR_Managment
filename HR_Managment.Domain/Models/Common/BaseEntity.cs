using System;
using System.ComponentModel.DataAnnotations;

namespace HR_Managment.Domain.Models.Common
{
    public abstract class BaseEntity<TKey>
    {
        [Required]
        public required TKey Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastModified { get; set; }
        [Required]
        public required string CreatedBy { get; set; }
        public required string LastModifiedBy { get; set; }
    }
}
