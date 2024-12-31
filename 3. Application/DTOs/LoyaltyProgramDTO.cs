﻿namespace _3._Application.DTOs;

public sealed class LoyaltyProgramDTO
{
    public int LoyaltyProgramId { get; set; }

    public required int GuestId { get; set; }

    public required int Points { get; set; }

    public required int Tier { get; set; }

    public UserDTO? User { get; set; } = null;
}
