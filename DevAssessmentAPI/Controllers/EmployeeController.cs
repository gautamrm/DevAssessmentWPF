using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevAssessmentAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                //using (EmployeeDBEntities entities = new EmployeeDBEntities())
                //{
                //    var emp = entities.Employees.FirstOrDefault(em => em.ID == id);
                //    if (emp != null)
                //    {
                //        return Ok(emp);
                //    }
                //    else
                //    {
                //        return Content(HttpStatusCode.NotFound, "Employee with Id: " + id + " not found");
                //    }
                //}
                return Json(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);

            }
        }

        [HttpPost]
        public HttpResponseMessage Post(string body)
        {
            try
            {
                //using (EmployeeDBEntities entities = new EmployeeDBEntities())
                //{
                //    entities.Employees.Add(employee);
                //    entities.SaveChanges();
                //    var res = Request.CreateResponse(HttpStatusCode.Created, employee);
                //    res.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
                //    return res;
                //}
                HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.OK);
                return hrm;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPatch]
        public HttpResponseMessage Patch(int id)
        {
            try
            {
                //using (EmployeeDBEntities entities = new EmployeeDBEntities())
                //{
                //    var employee = entities.Employees.Where(emp => emp.ID == id).FirstOrDefault();
                //    if (employee != null)
                //    {
                //        entities.Employees.Remove(employee);
                //        entities.SaveChanges();
                //        return Request.CreateResponse(HttpStatusCode.OK, "Employee with id" + id + " Deleted");
                //    }
                //    else
                //    {
                //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id" + id + " is not found!");
                //    }
                //}
                HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.OK);
                return hrm;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                //using (EmployeeDBEntities entities = new EmployeeDBEntities())
                //{
                //    var employee = entities.Employees.Where(emp => emp.ID == id).FirstOrDefault();
                //    if (employee != null)
                //    {
                //        entities.Employees.Remove(employee);
                //        entities.SaveChanges();
                //        return Request.CreateResponse(HttpStatusCode.OK, "Employee with id" + id + " Deleted");
                //    }
                //    else
                //    {
                //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id" + id + " is not found!");
                //    }
                //}
                HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.OK);
                return hrm;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
