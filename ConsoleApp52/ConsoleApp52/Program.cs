using GeoLibrary;
using System;
namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeoJSONData geoPoint1= new GeoJSONData();
            GeoJSONData geoPoint2 = new GeoJSONData();
            GeoJSONData geoPolygon = new GeoJSONData();
            GeoJSONHelper jsonHelp = new GeoJSONHelper();
            geoPoint1 = jsonHelp.LoadGeoJSON("GeoPoint_1.json");
            geoPoint2 = jsonHelp.LoadGeoJSON("GeoPoint_2.json");
            geoPolygon = jsonHelp.LoadGeoJSON("polygon.json");
            Console.WriteLine($"Весь файл:\n{geoPoint1.Type}\n{geoPoint1.Geometry}\n{geoPoint1.Properties}");
            jsonHelp.SaveGeoJSON("geoJSON.json", geoPoint1);//сохранение
            Console.WriteLine($"тип:\n{jsonHelp.GetGeometryType(geoPoint1)}");
            Console.WriteLine($"координаты:\n{jsonHelp.GetCoordinates(geoPoint1)}");
            Console.WriteLine($"площадь полигона:\n{jsonHelp.CalculateArea(geoPolygon)}");
            Console.WriteLine($"расстояние между точками:\n{jsonHelp.CalculateDistance(geoPoint1,geoPoint2)}");
        }
    }
}
