using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.PoleschukKR.Sprint5.Task0.V22.Lib;

namespace Tyuiu.PoleschukKR.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint5\Tyuiu.PoleschukKR.Sprint5.Task0.V22\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait,fileExists);
        }
    }
}
