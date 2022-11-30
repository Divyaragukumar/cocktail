using Microsoft.AspNetCore.Mvc;
using cocktailapi.Models;

namespace cocktailapi.Controllers;

[ApiController]
[Route("api/cocktail")]
public class CocktailController : ControllerBase
{
    private readonly CockdbContext DB;
    public CocktailController(CockdbContext db)
    {
        this.DB=db;
    }
    [HttpGet("GetCocktail/{cocktailname}")]
    public Cocktail GetCocktail(string cocktailname)
    {
        try{
            return DB.Cocktails.Where(e=>e.CocktailName.Equals(cocktailname)).FirstOrDefault();
        }
        catch(System.Exception)
    {
        throw;
    }
  
    }
}
