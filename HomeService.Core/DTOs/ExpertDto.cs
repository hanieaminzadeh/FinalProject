﻿using HomeService.Core.Entities;
using HomeService.Core.Enums;

namespace HomeService.Core.DTOs;

public class ExpertDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? BirthDate { get; set; }
    public string? ProfileImgUrl { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public int? CityId { get; set; }
    public City? City { get; set; }
    public string? CardNumber { get; set; }
    public string? ShebaNumber { get; set; }
    public string? Description { get; set; }
    public List<Service>? Services { get; set; }
    public List<Bid>? Bids { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public bool Active { get; set; } = false;
}
