using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HistoryAPI.Models;

namespace HistoryAPI.Controllers
{
    public class StudentsInClassesController : ApiController
    {
        private StudentInClassContext db = new StudentInClassContext();

        // GET: api/StudentsInClasses
        public IQueryable<StudentInClass> GetStudentInClasses()
        {
            return db.StudentsInClasses;
        }

        // GET: api/StudentsInClasses/5
        [ResponseType(typeof(StudentInClass))]
        public IHttpActionResult GetStudentInClass(int id)
        {
            StudentInClass studentInClass = db.StudentsInClasses.Find(id);
            if (studentInClass == null)
            {
                return NotFound();
            }

            return Ok(studentInClass);
        }

        // PUT: api/StudentsInClasses/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudentInClass(int id, StudentInClass studentInClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentInClass.Id)
            {
                return BadRequest();
            }

            db.Entry(studentInClass).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentInClassExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/StudentsInClasses
        [ResponseType(typeof(StudentInClass))]
        public IHttpActionResult PostStudentInClass(StudentInClass studentInClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StudentsInClasses.Add(studentInClass);
            studentInClass.relevance = true;
            studentInClass.StartDate = DateTime.Now;
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = studentInClass.Id }, studentInClass);
        }

        // DELETE: api/StudentsInClasses/5
        [ResponseType(typeof(StudentInClass))]
        public IHttpActionResult DeleteStudentInClass(int id)
        {
            StudentInClass studentInClass = db.StudentsInClasses.Find(id);
            if (studentInClass == null)
            {
                return NotFound();
            }

            //db.StudentsInClasses.Remove(studentInClass);
            studentInClass.relevance = false;
            studentInClass.EndingDate = DateTime.Now;
            db.SaveChanges();

            return Ok(studentInClass);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentInClassExists(int id)
        {
            return db.StudentsInClasses.Count(e => e.Id == id) > 0;
        }
    }
}