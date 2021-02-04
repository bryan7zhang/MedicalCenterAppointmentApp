using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalCenterAppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MedicalCenterAppointmentApp.Pages.DoctorList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Doctor> Doctors { get; set; }

        public async Task OnGet()
        {
            Doctors = await _db.Doctors.ToListAsync();

        }

    }
}

