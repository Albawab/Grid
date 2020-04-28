// <copyright file="InstellingenOdata.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Grid.Settings
{
    using HenE_Grid.Interface;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Klas Gets de instellingen van de odata.
    /// </summary>
    public class InstellingenOdata : IHaveSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstellingenOdata"/> class.
        /// </summary>
        /// <param name="configuration">configuration.</param>
        public InstellingenOdata(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets de configuratie.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Geef url van de odata terug.
        /// </summary>
        /// <returns>De instellingen van de applicatie.</returns>
        public Instellingen GetInstellingen()
        {
            return new Instellingen()
            {
                OdatabaseUrl = this.Configuration.GetSection("Instellingen").GetSection("OdatabaseUrl").Value,
            };
        }
    }
}
