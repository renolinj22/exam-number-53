﻿using System;
using System.ComponentModel.DataAnnotations;

public class UserForm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string[] Hobbies { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }


