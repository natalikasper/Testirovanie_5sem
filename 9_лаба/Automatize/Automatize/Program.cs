﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automatize
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.by");

            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("ITechArt");
            element.Submit();

            String el = driver.FindElement(By.XPath("//div[@class='g']")).Text;
            Console.WriteLine("\n" + el);
            if (el.Contains("itechart") == true)
                Console.WriteLine("OKKKK");
            else
                Console.WriteLine("Failed");

            Console.WriteLine("\nЗаголовок страницы: " + driver.Title);
            if (driver.Title.Contains("ITechArt") == true)
                Console.WriteLine("Заголовок страницы содержит 'ITechArt'");
            else
                Console.WriteLine("Заголовок страницы не содержит 'ITechArt'");

            driver.Quit();

        }
    }
}
