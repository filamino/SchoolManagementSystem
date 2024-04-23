using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Entities;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SmsdbContext _context;

        public StudentsController(SmsdbContext context)
        {
            _context = context;
        }

        // GET: Students

        [Authorize]
        public async Task< IActionResult> Index()
        {
            //var student = _context.Students.Select(student =>
            //new
            //{
            //    StudentName = student.FirstName,
            //    StudentLastName = student.LastName,
            //    student.DateOfBirth,
            //    student.AdmissionNumber,
            //    GenderType = student.Genders.Select(gender => gender.GenderType).FirstOrDefault(),
            //    Location = student.Addresses.Select(add => add.Address1)
            //}).ToList();
            ////var stud= _context.Students.Select(student=> new { studentName = student.FirstName, student.LastName, student.PhoneNumber }).ToList();

            ////ViewBag.studentlist = student;
            //return View( student);


            //var student = _context.Students.ToListAsync();
            return View(await _context.Students.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,AdmissionNumber,FirstName,LastName,DateOfBirth,PhoneNumber,JoinedDate,Email,About")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }





        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(StudentViewModel studentViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var student = new Student
        //        {
        //            FirstName = studentViewModel.FirstName,
        //            LastName = studentViewModel.LastName,
        //            AdmissionNumber = studentViewModel.AdmissionNumber,
        //            DateOfBirth = studentViewModel.DateOfBirth,
        //            JoinedDate = studentViewModel.JoinedDate,
        //            Email = studentViewModel.Email,
        //            PhoneNumber = studentViewModel.PhoneNumber,
        //            About = studentViewModel.About
        //        };
        //        _context.Students.Add(student);
        //        _context.SaveChanges();

        //        Address address = new Address
        //        {
        //            Address1 = studentViewModel.Address1,
        //            City = studentViewModel.City,
        //            Province = studentViewModel.Province,
        //            ZipCode = studentViewModel.ZipCode,
        //            Country = studentViewModel.Country,
        //            StudentId = student.StudentId
        //        };

        //        Add Address
        //        _context.Addresses.Add(address);
        //        _context.SaveChanges();
        //        Assign StudentId to Gender
        //        Gender gender = new Gender
        //        {
        //            GenderType = studentViewModel.GenderType,
        //            StudentId = student.StudentId

        //        };

        //        _context.Genders.Add(gender);
        //        _context.SaveChanges();


        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return RedirectToAction("Index");
        //}

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,AdmissionNumber,FirstName,LastName,DateOfBirth,JoinedDate,Email,PhoneNumber,About,Image")] Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }

        
    }
}
