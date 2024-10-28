using System;
using Domain.Comman;

namespace Domain;

public class User:BaseEntity
{
    public required string Name { get; set; }
    public required string Emanil { get; set; }
    public required string Password { get; set; }

}
