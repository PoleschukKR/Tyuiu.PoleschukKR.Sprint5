using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint5.Task1.V15.Lib;

using System.IO;
namespace Tyuiu.PoleschukKR.Sprint5.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint5\Tyuiu.PoleschukKR.Sprint5.Task1.V15\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
