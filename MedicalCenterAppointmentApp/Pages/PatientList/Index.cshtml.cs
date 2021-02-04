using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalCenterAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenterAppointmentApp.Pages.PatientList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Patient> Patients { get; set; }

        public async Task OnGet()
        {
            Patients = await _db.Patients.ToListAsync();

        }
    }
}
