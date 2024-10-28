using System;
using Domain.Comman;

namespace Domain;

public class Product:BaseEntity
{
    public required string Name { get; set; }
    public int Stock { get; set; }


}
