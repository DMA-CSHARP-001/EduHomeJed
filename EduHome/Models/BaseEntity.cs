﻿namespace EduHome.Models
{
	public abstract class BaseEntity
	{
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public  DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
