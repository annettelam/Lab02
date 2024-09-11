using System;
using System.Collections.Generic;

namespace Lab02.Model.NW;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
