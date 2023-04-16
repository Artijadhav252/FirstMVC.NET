using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstMVC.NET.Models;

public partial class Student
{
    public int Id { get; set; }
    [Required]
    [EmailAddress]
    public string? EmailId { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Gender { get; set; }
    [Required]
    public string? MobileNumber { get; set; }
}
