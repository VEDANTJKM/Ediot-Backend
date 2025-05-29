using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Weather
{
    public int Id { get; set; }

    public DateTime DateTime { get; set; }

    public double Temperature { get; set; }

    public double Humidity { get; set; }

    public double Pressure { get; set; }

    public double Dust { get; set; }

    public double Uv { get; set; }
}
