using System;
using Domain.Comman;

namespace Domain;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Quentity { get; set; }
    public int MyProperty { get; set; }


}
