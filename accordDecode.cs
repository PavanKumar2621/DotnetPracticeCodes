using System;

class AccordGpsDecoder
{
    static void Main()
    {
        string latitudeStr = "1715.0234262";
        string longitudeStr = "07828.0846276";
        
        ConvertLatLong(latitudeStr, out int latDeg, out int latMin, out double latSec);
        ConvertLatLong(longitudeStr, out int lonDeg, out int lonMin, out double lonSec);
        
        Console.WriteLine($"Latitude: {latDeg}° {latMin}' {latSec:F4}\"");
        Console.WriteLine($"Longitude: {lonDeg}° {lonMin}' {lonSec:F4}\"");
    }

    static void ConvertLatLong(string coordinate, out int degrees, out int minutes, out double seconds)
    {
        double value = double.Parse(coordinate);
        degrees = (int)(value / 100);
        double remainingMinutes = value - (degrees * 100);
        minutes = (int)remainingMinutes;
        seconds = (remainingMinutes - minutes) * 60;
    }
}
