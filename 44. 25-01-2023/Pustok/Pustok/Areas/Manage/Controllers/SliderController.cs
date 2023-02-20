using Microsoft.AspNetCore.Mvc;
using Pustok.Helpers;
using Pustok.Models;
using System.Reflection;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly PustokContext _pustokContext;
        private readonly IWebHostEnvironment _env;

        public SliderController(PustokContext pustokContext, IWebHostEnvironment env)
        {
            _pustokContext = pustokContext;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_pustokContext.Sliders.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if(slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "You can only upload png or jpeg");
                    return View();
                }

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "You can only upload image size lower than 2mb");
                    return View();
                }

                //string filename = slider.ImageFile.FileName; // slider.jpg

                //if(filename.Length > 64)
                //{
                //    filename = filename.Substring(filename.Length - 64,64);
                //}

                //filename = Guid.NewGuid().ToString() + filename; //bbe54dae-d572-4633-acfa-0a24a36fe0f9slider.jpg

                ////string path = "C:\\Users\\asus\\Desktop\\University\\BP204\\35. 05-01-2023\\Pustok\\Pustok\\wwwroot\\uploads\\sliders\\" + filename;

                //string path = Path.Combine(_env.WebRootPath, "uploads/sliders", filename);

                //using (FileStream fileStream = new FileStream(path,FileMode.Create))
                //{
                //    slider.ImageFile.CopyTo(fileStream);
                //}


                //slider.Image = FileManager.SaveFile(_env.WebRootPath,"uploads/sliders",slider.ImageFile);

                slider.Image = slider.ImageFile.SaveFile(_env.WebRootPath, "uploads/sliders");
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Required");
            }
            if (!ModelState.IsValid) return View();

            _pustokContext.Sliders.Add(slider);
            _pustokContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            Slider slider = _pustokContext.Sliders.Find(id);
            if (slider is null) return View("Error");

            return View(slider);
        }

        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            Slider existSlider = _pustokContext.Sliders.Find(slider.Id);
            if (existSlider is null) return View("Error");


            if(slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "You can only upload png or jpeg");
                    return View();
                }

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "You can only upload image size lower than 2mb");
                    return View();
                }

                string deletePath = Path.Combine(_env.WebRootPath, "uploads/sliders", existSlider.Image);

                if (System.IO.File.Exists(deletePath))
                {
                    System.IO.File.Delete(deletePath);
                }

                existSlider.Image = slider.ImageFile.SaveFile(_env.WebRootPath, "uploads/sliders");
            }
            if (!ModelState.IsValid) return View();

            existSlider.Desc = slider.Desc;
            existSlider.ButtonText = slider.ButtonText;
            existSlider.Order = slider.Order;
            existSlider.RedirectUrl = slider.RedirectUrl;
            existSlider.Title1 = slider.Title1;
            existSlider.Title2 = slider.Title2;

            //PropertyInfo[] destination = existSlider.GetType().GetProperties();
            //PropertyInfo[] source = slider.GetType().GetProperties();

            //for (int i = 0; i < destination.Length; i++)
            //{
            //    destination[i].SetValue(existSlider, source[i].GetValue(slider));
            //}



            _pustokContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Slider slider = _pustokContext.Sliders.FirstOrDefault(x => x.Id == id);
            if (slider is null) return NotFound(); // 404

            _pustokContext.Sliders.Remove(slider);
            _pustokContext.SaveChanges();

            return Ok(); // 200
        }
    }
}
