using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.API.Models.Domains.DTO
{
    public class UpdateRegionDto
    {
    public string Code { get; set; }
    public string Name { get; set; }
    public string? ImageRegionUrl { get; set; }
    }
}