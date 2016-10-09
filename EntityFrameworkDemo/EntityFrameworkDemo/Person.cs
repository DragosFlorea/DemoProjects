using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class Person
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the day of birth.
        /// </summary>
        public DateTime DayOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <remarks>Is a blob in the database.</remarks>
        public byte[] Picture { get; set; }
    }
}
