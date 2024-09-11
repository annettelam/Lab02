using System;
using System.Collections.Generic;

namespace Lab02.Model.NW;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
