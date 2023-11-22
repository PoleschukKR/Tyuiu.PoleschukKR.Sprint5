using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint5.Task7.V9.Lib;
using System.IO;


namespace Tyuiu.PoleschukKR.Sprint5.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedExistsFile()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask7V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
