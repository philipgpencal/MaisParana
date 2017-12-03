using Microsoft.PowerBI.Api.V2.Models;
using System;

namespace MaisParana.Web.Models
{
    public class TileEmbedConfig : EmbedConfig
    {
        public string dashboardId { get; set; }
    }
}