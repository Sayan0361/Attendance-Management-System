using Attendance_Management_System.DAL;
using Attendance_Management_System.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCrypt.Net;


namespace Attendance_Management_System.Controllers
{
    public class StudentController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(StudentModel model)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@name", model.name);
            param.Add("@roll_no", model.roll_no);
            param.Add("@section",model.section);
            param.Add("@class",model._class);

            int newStudentID = DapperContext.ExecuteReturnScalar<int>("sp_InsertOrEditIntoStudent", param);
            string hash = GenerateHash(model, newStudentID);

            DynamicParameters hashParam = new DynamicParameters();
            hashParam.Add("@studentID", newStudentID);
            hashParam.Add("@hash", hash);
            var result = DapperContext.ReturnSingle<HashTableModel>("sp_InsertHashAndStudentID", hashParam);
            //var studentIDAndHashAfterSaveToDB = new HashTableModel
            //{
            //    studentID = newStudentID,
            //    hash = hash
            //};

            return PartialView("_UserMessageModal", result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string GenerateHash(StudentModel model, int studentID)
        {
            return BCrypt.Net.BCrypt.HashPassword(model.name + model.roll_no + model.section + model._class + studentID.ToString());
        }

    }
}