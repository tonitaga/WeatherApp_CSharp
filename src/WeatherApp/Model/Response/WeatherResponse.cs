﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model.Response.Body;

namespace WeatherApp.Model.Response
{
    // Класс WeatherResponse
    // Создан для сохранения всех данных из JSON файла
    // Наименование полей согласно ответу от сервиса в виде JSON файла
    public class WeatherResponse
    {
        // Variable-naming like in JSON file of OpenWeatherMap servise response
        public WeatherResponseBodyCoord         coord   {  get; set; }
        public List<WeatherResponseBodyWeather> weather {  get; set; }
        public WeatherResponseBodyMain          main    { get; set; }
        public WeatherResponseBodyWind          wind    { get; set; }
        public WeatherResponseBodySystem        sys     { get; set; }

        public int cod {  get; set; }
    }
}
