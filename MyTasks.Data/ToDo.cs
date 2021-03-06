﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTasks.Data
{
    [Table("ToDo")]
    public class ToDo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string AppUserId{ get; set; }

        [ForeignKey("AppUserId")]
        public AppUser User { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Complete { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}