﻿namespace _3._Application.DTOs;

public sealed class MaintenanceDTO
{
    public int MaintenanceId { get; set; }

    public required int RoomId { get; set; }

    public required string IssueDescription { get; set; }

    public required DateTimeOffset ReportTime { get; set; }

    public DateTimeOffset? RepairDate { get; set; }

    public RoomDTO? Room { get; set; } = null;
}
