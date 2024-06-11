using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    public class PAController : ApiController
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        // GET: PA
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [System.Web.Http.Route("api/pa/videos")]
        public HttpResponseMessage GetVideoMappings()
        {
            var result = new ResultRespon<List<string>>();
            MyCarModel.Car addModel = new MyCarModel.Car();
            addModel.Type = "4 ล้อ";
            addModel.Name = "Toyota";

            MyCarModel.CarType model1 = new MyCarModel.CarType();
            model1.Color = "Red";
            model1.Seat = "5 ที่นั่ง";

            MyCarModel.CarType model2 = new MyCarModel.CarType();
            model2.Color = "Blud";
            model2.Seat = "7 ที่นั่ง";

            List<MyCarModel.CarType> addModels = new List<MyCarModel.CarType>();
            addModels.Add(model1);
            addModels.Add(model2);

            // ตั้งค่าคุณสมบัติ Attribute ของ addModel ด้วยรายการ addModels
            addModel.Attribute = addModels;

            if (addModel != null)
            {
                result.isSuccess = true;
                return Request.CreateResponse(HttpStatusCode.OK, addModel, Configuration.Formatters.JsonFormatter);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Configuration.Formatters.JsonFormatter);
            }

            
        }
    }
}