﻿namespace TaskManagerApi
{
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace TaskManagerApi.Models
    {
        public class TaskItem
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Title is required.")]
            public string Title { get; set; }

            public string? Description { get; set; }

            public DateTime? DueDate { get; set; }

            public bool IsComplete { get; set; }
        }
    }

}
