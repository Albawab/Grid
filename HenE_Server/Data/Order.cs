// <copyright file="Order.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// class waarin de proporties van een order staan.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets de id van de order.
        /// </summary>
        public int? OrderID { get; set; }

        /// <summary>
        /// Gets or sets de id van een customer.
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        /// Gets or sets de data van een order.
        /// </summary>
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Gets or sets de staad waar een order wordt gestuurd.
        /// </summary>
        public string ShipCity { get; set; }

        /// <summary>
        /// Gets or sets vracht van een order.
        /// </summary>
        public double? Freight { get; set; }
    }
}
