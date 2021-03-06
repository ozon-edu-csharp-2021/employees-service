using System;
using System.Collections.Generic;

namespace CSharpCourse.EmployeesService.Domain.Models.DTOs
{
    /// <summary>
    /// Employee of company
    /// </summary>
    public class EmployeeDto : IdModel<long>
    {
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Middle name
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Employee birth day
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Date of hiring
        /// </summary>
        public DateTime HiringDate { get; set; }

        /// <summary>
        /// Размер одежды
        /// </summary>
        public int ClothingSize { get; set; }

        /// <summary>
        /// Conferences that an employee can attend
        /// </summary>
        public ICollection<ConferenceDto> Conferences { get; set; }
    }
}
