﻿namespace IdentityPractice.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime Deadline { get; set; }
        public AppUser? User { get; set; }
    }
}
