﻿namespace CRUDOperation.Models
{
    public class StudentViewModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
       
    }
}
