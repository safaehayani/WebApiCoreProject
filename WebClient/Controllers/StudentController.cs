using Microsoft.AspNetCore.Mvc;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<StudentModel> studentlist;
            HttpResponseMessage response=GlobalVariables.WebApiClient.GetAsync("https://localhost:7002/api/Students").Result;
            studentlist = response.Content.ReadAsAsync<IEnumerable<StudentModel>>().Result;
            return View(studentlist);
        }

        public IActionResult AddOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new StudentModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("https://localhost:7002/api/Students/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    StudentModel student = response.Content.ReadAsAsync<StudentModel>().Result;
                    return View(student);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult AddOrEdit(StudentModel studentModel)
        {
            if (studentModel.Id == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("https://localhost:7002/api/Students", studentModel).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Une erreur s'est produite lors de l'ajout de l'étudiant.");
                    return View(studentModel);
                }
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("https://localhost:7002/api/Students/" + studentModel.Id, studentModel).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Une erreur s'est produite lors de la mise à jour de l'étudiant.");
                    return View(studentModel);
                }
            }
        }

    }
}
