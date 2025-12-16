using System;
using System.Collections.Generic;

namespace Jordan_C__Final.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public double UnitPrice { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
