using System;
using System.Collections.Generic;

namespace Lim_Matthew;

public  class SupplierTbl
{
    public int SupplierId { get; set; }

    public string SupplierName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Contact { get; set; }

    public DateTime? DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
