using Microsoft.AspNetCore.Mvc;

public class CacheResourceAttribute : TypeFilterAttribute
{
    public CacheResourceAttribute()
        : base(typeof(CacheResourceFilter))
    {
    }
}