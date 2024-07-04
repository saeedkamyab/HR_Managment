using System;

namespace HR_Managment.Domain.Models.Common
{
    public abstract class BaseEntity<TKey>
    {
        
        public  TKey Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

    }
}
