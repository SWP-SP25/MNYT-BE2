﻿namespace BusinessObject
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
