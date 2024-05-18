using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public static class DataContext
    {
        public static List<Precipitation> Precipitations { get; set; } =
        [
            new Precipitation("Без осадков"),
            new Precipitation("Снег"),
            new Precipitation("Дождь"),
            new Precipitation("Град"),
        ];
        public static List<Weather> Weathers { get; set; } =
        [
            new Weather(-20,DateTime.Now.AddDays(-30), Precipitations[0]),
            new Weather(-15,DateTime.Now.AddDays(-29), Precipitations[2]),
            new Weather(8,DateTime.Now.AddDays(-28), Precipitations[1]),
            new Weather(0,DateTime.Now.AddDays(-27), Precipitations[3]),
            new Weather(5,DateTime.Now.AddDays(-26), Precipitations[0]),
            new Weather(14,DateTime.Now.AddDays(-25), Precipitations[3]),
            new Weather(-3,DateTime.Now.AddDays(-24), Precipitations[1]),
            new Weather(6,DateTime.Now.AddDays(-23), Precipitations[0]),
            new Weather(20,DateTime.Now.AddDays(-22), Precipitations[3]),
            new Weather(27,DateTime.Now.AddDays(-21), Precipitations[2]),
            new Weather(14,DateTime.Now.AddDays(-20), Precipitations[2]),
            new Weather(0,DateTime.Now.AddDays(-19), Precipitations[2]),
            new Weather(-2,DateTime.Now.AddDays(-18), Precipitations[3]),
            new Weather(-10,DateTime.Now.AddDays(-17), Precipitations[1]),
            new Weather(-16,DateTime.Now.AddDays(-16), Precipitations[1]),
            new Weather(-20,DateTime.Now.AddDays(-15), Precipitations[0]),
            new Weather(-7,DateTime.Now.AddDays(-14), Precipitations[0]),
            new Weather(-4,DateTime.Now.AddDays(-13), Precipitations[3]),
            new Weather(0,DateTime.Now.AddDays(-12), Precipitations[2]),
            new Weather(8,DateTime.Now.AddDays(-11), Precipitations[2]),
            new Weather(20,DateTime.Now.AddDays(-10), Precipitations[2]),
            new Weather(-8,DateTime.Now.AddDays(-9), Precipitations[1]),
            new Weather(0,DateTime.Now.AddDays(-8), Precipitations[0]),
            new Weather(18,DateTime.Now.AddDays(-7), Precipitations[0]),
            new Weather(0,DateTime.Now.AddDays(-6), Precipitations[0]),
            new Weather(-6,DateTime.Now.AddDays(-5), Precipitations[3]),
            new Weather(-26,DateTime.Now.AddDays(-4), Precipitations[3]),
            new Weather(-20,DateTime.Now.AddDays(-3), Precipitations[2]),
            new Weather(-2,DateTime.Now.AddDays(-2), Precipitations[1]),
            new Weather(13,DateTime.Now.AddDays(-1), Precipitations[0]),
            new Weather(30,DateTime.Now.AddDays(0), Precipitations[0]),
            new Weather(18,DateTime.Now.AddDays(1), Precipitations[0]),
            new Weather(0,DateTime.Now.AddDays(2), Precipitations[3]),
            new Weather(5,DateTime.Now.AddDays(3), Precipitations[0]),
            new Weather(-6,DateTime.Now.AddDays(4), Precipitations[0]),
            new Weather(-15,DateTime.Now.AddDays(5), Precipitations[2]),
            new Weather(-22,DateTime.Now.AddDays(6), Precipitations[2]),
            new Weather(-27,DateTime.Now.AddDays(7), Precipitations[3]),
            new Weather(-6,DateTime.Now.AddDays(8), Precipitations[0]),
            new Weather(-17,DateTime.Now.AddDays(9), Precipitations[3]),
            new Weather(-20,DateTime.Now.AddDays(10), Precipitations[1]),
            new Weather(0,DateTime.Now.AddDays(11), Precipitations[0]),
            new Weather(-8,DateTime.Now.AddDays(12), Precipitations[3]),
            new Weather(5,DateTime.Now.AddDays(13), Precipitations[1]),
            new Weather(18,DateTime.Now.AddDays(14), Precipitations[0]),
            new Weather(31,DateTime.Now.AddDays(15), Precipitations[0]),
            new Weather(20,DateTime.Now.AddDays(16), Precipitations[1]),
            new Weather(3,DateTime.Now.AddDays(17), Precipitations[3]),
            new Weather(-4,DateTime.Now.AddDays(18), Precipitations[0]),
            new Weather(-16,DateTime.Now.AddDays(19), Precipitations[2]),
            new Weather(-25,DateTime.Now.AddDays(20), Precipitations[1]),
            new Weather(-12,DateTime.Now.AddDays(21), Precipitations[0]),
            new Weather(0,DateTime.Now.AddDays(22), Precipitations[2]),
            new Weather(14,DateTime.Now.AddDays(23), Precipitations[1]),
            new Weather(33,DateTime.Now.AddDays(24), Precipitations[0]),
            new Weather(19,DateTime.Now.AddDays(25), Precipitations[0]),
            new Weather(20,DateTime.Now.AddDays(26), Precipitations[3]),
            new Weather(7,DateTime.Now.AddDays(27), Precipitations[0]),
            new Weather(-6,DateTime.Now.AddDays(28), Precipitations[0]),
            new Weather(-23,DateTime.Now.AddDays(29), Precipitations[2]),
            new Weather(-36,DateTime.Now.AddDays(30), Precipitations[1]),
        ];
    }
}
