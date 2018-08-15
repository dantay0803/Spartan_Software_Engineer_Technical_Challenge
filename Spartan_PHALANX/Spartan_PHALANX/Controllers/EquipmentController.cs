using Newtonsoft.Json;
using PHALANX_Equipment_Search.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Spartan_PHALANX.Controllers
{
    public class EquipmentController : ApiController
    {
        //Path to JSON file
        string filePath = @"C:\Users\danta\source\repos\Spartan_PHALANX\Spartan_PHALANX\App_Data\EquipmentData.json";

        // GET: api/Equipment
        public Example Get()
        {
            Example example = new Example();

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        String rawJSON = sr.ReadToEnd();
                        example = JsonConvert.DeserializeObject<Example>(rawJSON);
                        Console.WriteLine(example);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("JSON Data file could not be found.");
            }

            return example;
        }

        // GET: api/Equipment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Equipment
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Equipment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Equipment/5
        public void Delete(int id)
        {
        }
    }
}
