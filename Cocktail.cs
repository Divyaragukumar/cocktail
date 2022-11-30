using System;
using System.Collections.Generic;

namespace cocktailapi.Models;

public partial class Cocktail
{
    public int Cid { get; set; }

    public string? CocktailName { get; set; }

    public string? Info { get; set; }

    public string? Glass { get; set; }

    public string? Instructions { get; set; }

    public string? Ingredients { get; set; }

    public string? Images { get; set; }
}
