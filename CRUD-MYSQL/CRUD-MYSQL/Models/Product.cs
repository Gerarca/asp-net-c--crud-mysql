using System;
using System.Collections.Generic;

namespace CRUD_MYSQL.Models;

public partial class Product
{
    public ulong Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public double Price { get; set; }

    public int Stock { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
