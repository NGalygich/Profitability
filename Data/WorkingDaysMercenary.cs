using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

namespace Profitability;

public partial class WorkingDaysMercenary
{
    [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public double? Value { get; set; }
}
