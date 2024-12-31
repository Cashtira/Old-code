﻿namespace _3._Application.DTOs;

public sealed class ServiceDTO
{
    public int ServiceId { get; set; }

    public required string Name { get; set; }

    public required decimal Price { get; set; }

    public required string Description { get; set; }

    public IList<ServiceBookingDTO> ServiceBookingDTOs { get; set; } = [];
}
