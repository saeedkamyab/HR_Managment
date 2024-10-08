using System;
using System.ComponentModel.DataAnnotations;

namespace HR_Managment.Domain.Models.Common
{
    public abstract class BaseEntity<TKey>
    {
        [Required]
        public TKey Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastModified { get; set; }
        [Required]
        public string? CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
