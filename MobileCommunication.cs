using System;
using System.Collections.Generic;

namespace Profitability;

public partial class MobileCommunication
{
    public int Id { get; set; }

    public DateTime? AccountingDate { get; set; }

    public double? CommunicationsCost { get; set; }
}
