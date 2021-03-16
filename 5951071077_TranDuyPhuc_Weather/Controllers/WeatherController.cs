using _5951071077_TranDuyPhuc_Weather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071077_TranDuyPhuc_Weather.Controllers
{
    public class WeatherController : ApiController
    {
            public string Location { get; private set; }
            public int Degree { get; private set; }
            public DateTime DateTime { get; private set; }

            // GET: api/Weather
            public IEnumerable<WeatherInfo> Get()
            {
                var weatherInfList = new List<WeatherInfo>();
                for (int i = 0; i < 10; i++)
                {
                    var WeatherInfo = new WeatherInfo
                    {
                        Location = $"Location {i}",
                        Degree = i * 23 / 17,
                        DateTime = DateTime.Now.ToUniversalTime()
                    };
                    weatherInfList.Add(WeatherInfo);
                }
                return weatherInfList;

            }

            // GET: api/Weather/5
            public WeatherInfo Get(int id)
            {
                return new WeatherInfo
                {
                    Location = $"Location {id}",
                    Degree = id * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
            }
        }
    }
