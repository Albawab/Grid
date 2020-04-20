// <copyright file="StudentController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// De controller van de student data.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Jos", "Arno", "Joris", "Remco", "Remko", "Max",
        };

        /// <summary>
        /// Geeft de gegevens van de student terug.
        /// </summary>
        /// <returns>De lijst van de studenten.</returns>
        [HttpGet]
        public IEnumerable<Student> GetData()
        {
            var rng = new Random();
            return Enumerable.Range(1, 300).Select(index => new Student
            {
                Id = index,
                Name = Names[rng.Next(Names.Length)],
            });
        }
    }
}