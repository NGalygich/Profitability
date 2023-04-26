using System;
using System.Collections.Generic;

namespace Profitability;

public partial class PaymentClientsPlanned
{
    public int Id { get; set; }

    public DateTime? DatePlanned { get; set; }

    public double? AmountPlanned { get; set; }
}
