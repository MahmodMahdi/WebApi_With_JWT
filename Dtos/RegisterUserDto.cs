﻿using System.ComponentModel.DataAnnotations;

namespace WebApi_Demo.Dtos;
public class RegisterUserDto
{
    [Required]
    public string? UserName { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    [Compare("Password")]
    public string? ConfirmPassword { get; set; }
}
