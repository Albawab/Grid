// <copyright file="Student.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Student
    {
        /// <summary>
        /// Gets or sets de id van een student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets de naam van een student.
        /// </summary>
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }

        /*        /// <summary>
                /// Gets or sets de email van een student.
                /// </summary>
                [DataType(DataType.EmailAddress)]
                public string Email { get; set; }

                /// <summary>
                /// Gets or sets de telefoonnummer van een student.
                /// </summary>
                [Range(9, 10)]
                public int Phone { get; set; }*/
    }
}
