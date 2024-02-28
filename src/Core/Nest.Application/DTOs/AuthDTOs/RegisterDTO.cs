﻿namespace Nest.Application.DTOs.AuthDTOs;

public class RegisterDTO
{
    public string FullName { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string ConfirmatedPassword { get; set; }
}