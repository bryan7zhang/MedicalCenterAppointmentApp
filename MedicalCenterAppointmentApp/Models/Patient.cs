using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalCenterAppointmentApp.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string PatientName { get; set; }

        [Required]
        public string PatientPhone { get; set; }

        public string EmergencyContact { get; set; }

        public string EmergencyPhone { get; set; }
    }
}
