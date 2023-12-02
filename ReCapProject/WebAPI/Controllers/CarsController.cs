
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()  //IActionResult WebAPI'nin HTTP kodlarını döndürebilmemiz için sunduğu altyapı
        {
            var result = _carService.GetAll(); //getAll servisini çağırıp onu kullanabilmek için result değişkenine atıyoruz
            if (result.Success) //result değişkeninin başarılı olup olmadığı kontrolü
            {
                return Ok(result); //OK = 200 Kodu (Başarılı oldu anlamında) Sunucunun isteği başarılı bir şekilde aldığını, işlediğini ve başarılı bir şekilde istenen cevabı döndüğünü (işlemin başarılı olduğunu) belirten durum kodudur.Genellikle GET istekleri sonucunda dönen durum kodudur.
            }
            return BadRequest(result); //BadRequest == 400 kodu (Başarısız oldu anlamında) istek ya da tarayıcıdaki bir hata durumunda sunucunun isteği işleyemediğini söylemek amaçlı dönen durum mesajıdır.

        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _carService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getCarDetailDtos")]
        public IActionResult GetCarDetailDtos()
        {
            var result = _carService.GetCarDetailDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("[action]")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    
    }
}

