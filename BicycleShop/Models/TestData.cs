using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class TestData
    {
        public static void Initialize(BicycleContext context)
        {
            if (!context.Bicycles.Any())
            {
                context.Bicycles.AddRange(
                    new Bicycle
                    {
                        Title = "Велосипед Cross Focus",
                        Brand = "Cross",
                        Price = 5299f,
                        Class = "Hardtail",
                        Wheels = 26f,
                        Frame = 15f,
                        Color = "Gray blue",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//1
                    new Bicycle
                    {
                        Title = "Велосипед Corrado Fortun",
                        Brand = "Corrado",
                        Price = 9274f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 18.5f,
                        Color = "black blue",
                        YearOfIssue = 2019,
                        Saddle = "MTB type"
                    },//2
                    new Bicycle
                    {
                        Title = "Велосипед Formula Omega",
                        Brand = "Formula",
                        Price = 5206f,
                        Class = "Urban",
                        Wheels = 26f,
                        Frame = 18f,
                        Color = "beige",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//3
                    new Bicycle
                    {
                        Title = "Велосипед Corrado Fortun",
                        Brand = "Corrado",
                        Price = 9274f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 18.5f,
                        Color = "blue",
                        YearOfIssue = 2019,
                        Saddle = "MTB type"
                    },//4
                    new Bicycle
                    {
                        Title = "Велосипед Corrado Fortun",
                        Brand = "Corrado",
                        Price = 9274f,
                        Class = "Mountain",
                        Wheels = 25f,
                        Frame = 18.5f,
                        Color = "white",
                        YearOfIssue = 2020,
                        Saddle = "MTB type"
                    },//5
                    new Bicycle
                    {
                        Title = "Велосипед Corrado Fortun",
                        Brand = "Corrado",
                        Price = 9304f,
                        Class = "Mountain",
                        Wheels = 27f,
                        Frame = 18.5f,
                        Color = "black",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//6
                    new Bicycle
                    {
                        Title = "Велосипед Corrado Fortun",
                        Brand = "Corrado",
                        Price = 9274f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 18.5f,
                        Color = "blue",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//7
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9999f,
                        Class = "Mountain",
                        Wheels = 27.5f,
                        Frame = 19f,
                        Color = "gray",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//8
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9999f,
                        Class = "Mountain",
                        Wheels = 27.5f,
                        Frame = 19f,
                        Color = "gray",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//9
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9349f,
                        Class = "Mountain",
                        Wheels = 27.5f,
                        Frame = 19f,
                        Color = "gray",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//10
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9999f,
                        Class = "Mountain",
                        Wheels = 28f,
                        Frame = 19f,
                        Color = "gray",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//11
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9199f,
                        Class = "Mountain",
                        Wheels = 27.5f,
                        Frame = 19f,
                        Color = "red",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//12
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9000f,
                        Class = "Mountain",
                        Wheels = 15f,
                        Frame = 19f,
                        Color = "gray",
                        YearOfIssue = 2020,
                        Saddle = "MTB type"
                    },//13
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9899f,
                        Class = "Mountain",
                        Wheels = 27.5f,
                        Frame = 19f,
                        Color = "gray",
                        YearOfIssue = 2021,
                        Saddle = "MTB type"
                    },//14
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9999f,
                        Class = "Mountain",
                        Wheels = 30f,
                        Frame = 20f,
                        Color = "gray",
                        YearOfIssue = 2018,
                        Saddle = "MTB type"
                    },//15
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan mini",
                        Brand = "Ardis",
                        Price = 8888f,
                        Class = "Mountain",
                        Wheels = 22f,
                        Frame = 15f,
                        Color = "Orange",
                        YearOfIssue = 2020,
                        Saddle = "MTB type"
                    },//16
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 9009f,
                        Class = "Mountain",
                        Wheels = 27f,
                        Frame = 19f,
                        Color = "green",
                        YearOfIssue = 2021,
                        Saddle = "MTC type"
                    },//17
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Titan",
                        Brand = "Ardis",
                        Price = 10233f,
                        Class = "Mountain",
                        Wheels = 28f,
                        Frame = 20f,
                        Color = "gray",
                        YearOfIssue = 2020,
                        Saddle = "MTB type"
                    },//18
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 9076f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 19f,
                        Color = "white",
                        YearOfIssue = 2021,
                        Saddle = "MTC type"
                    },//19
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 9271f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 19f,
                        Color = "black",
                        YearOfIssue = 2021,
                        Saddle = "MTC type"
                    },//21
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 9100f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 19f,
                        Color = "gray",
                        YearOfIssue = 2021,
                        Saddle = "MTC type"
                    },//22
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 8976f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 19f,
                        Color = "white",
                        YearOfIssue = 2020,
                        Saddle = "MTC type"
                    },//23
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 9476f,
                        Class = "Mountain",
                        Wheels = 28f,
                        Frame = 19f,
                        Color = "red",
                        YearOfIssue = 2021,
                        Saddle = "MTC type"
                    },//24
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 9576f,
                        Class = "Mountain",
                        Wheels = 26f,
                        Frame = 19f,
                        Color = "white",
                        YearOfIssue = 2021,
                        Saddle = "MTC type"
                    },//25
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 8400f,
                        Class = "Mountain",
                        Wheels = 25f,
                        Frame = 19f,
                        Color = "white",
                        YearOfIssue = 2019,
                        Saddle = "MTC type"
                    },//26
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 9276f,
                        Class = "Mountain",
                        Wheels = 27f,
                        Frame = 20f,
                        Color = "white",
                        YearOfIssue = 2020,
                        Saddle = "MTC type"
                    },//27
                    new Bicycle
                    {
                        Title = "Велосипед Ardis Maxus",
                        Brand = "Ardis",
                        Price = 9276f,
                        Class = "Mountain",
                        Wheels = 27f,
                        Frame = 20f,
                        Color = "white",
                        YearOfIssue = 2020,
                        Saddle = "MTC type"
                    },//28
                    new Bicycle
                    {
                        Title = "Велосипед Dorozhnik Obsidian",
                        Brand = "Dorozhnik",
                        Price = 5025f,
                        Class = "Mountain",
                        Wheels = 28f,
                        Frame = 19.5f,
                        Color = "blue",
                        YearOfIssue = 2021,
                        Saddle = "Comfortable with springs"
                    },//29
                    new Bicycle
                    {
                        Title = "Велосипед Dorozhnik Obsidian",
                        Brand = "Dorozhnik",
                        Price = 5025f,
                        Class = "Mountain",
                        Wheels = 28f,
                        Frame = 19.5f,
                        Color = "blue",
                        YearOfIssue = 2021,
                        Saddle = "Comfortable with springs"
                    } //30
                    );
                context.SaveChanges();
            }
        }
    }
}
