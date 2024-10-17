﻿using _2_проба;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void CircleArea_WithValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            TCircle circle = new TCircle(3);
            double expectedArea = Math.PI * Math.Pow(3, 2);

            // Act
            double actualArea = circle.CircleArea(3);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, "Площа кола обчислена неправильно.");
        }
        [TestMethod]
        public void SectorArea_WithValidRadiusAndAngle_ReturnsCorrectSectorArea()
        {
            // Arrange
            TCircle circle = new TCircle(3, 90); // Радіус = 3, Кут сектора = 90
            double expectedSectorArea = (Math.PI * Math.Pow(3, 2) * 90) / 360;

            // Act
            double actualSectorArea = circle.SectorArea(3, 90);

            // Assert
            Assert.AreEqual(expectedSectorArea, actualSectorArea, "Площа сектора обчислена неправильно.");
        }

        [TestMethod]
        public void CompareTo_WithDifferentRadii_CorrectlyComparesCircles()
        {
            // Arrange
            TCircle largerCircle = new TCircle(5);
            TCircle smallerCircle = new TCircle(3);

            // Act
            int result = largerCircle.Compare(smallerCircle);

            // Assert
            Assert.IsTrue(result > 0, "Перший круг має більший радіус, тому результат порівняння повинен бути позитивним.");
        }

        [TestMethod]
        public void CompareTo_WithSameRadius_ReturnsZero()
        {
            // Arrange
            TCircle circle1 = new TCircle(3);
            TCircle circle2 = new TCircle(3);

            // Act
            int comparisonResult = circle1.Compare(circle2);

            // Assert
            Assert.AreEqual(0, comparisonResult, "Кола з однаковим радіусом повинні повертати 0.");
        }
        [TestMethod]

        public void ConeVolume_WithValidRadiusAndHeight_ReturnsCorrectVolume()
        {
            // Arrange
            TCone cone = new TCone();
            cone.Radius = 3;
            cone.Height = 5;
            double expectedVolume = (Math.PI * Math.Pow(3, 2) * 5) / 3;

            // Act
            double actualVolume = cone.ConeVolume();

            // Assert
            Assert.AreEqual(expectedVolume, actualVolume, "Об'єм конуса обчислений неправильно.");
        }

        [TestMethod]
        public void CompareTo_WithDifferentVolumes_CorrectlyComparesCones()
        {
            // Arrange
            TCone cone1 = new TCone { Radius = 3, Height = 5 }; // об'єм 47.12
            TCone cone2 = new TCone { Radius = 2, Height = 4 }; // об'єм 16.76

            cone1.CircleMethods();
            cone2.CircleMethods();

            // Act
            int comparisonResult = cone1.Compare(cone2);

            // Assert
            Assert.IsTrue(comparisonResult > 0, "Перший конус має більший об'єм, тому результат порівняння повинен бути позитивним.");
        }

        [TestMethod]
        public void CompareTo_WithSameVolume_ReturnsZero()
        {
            // Arrange
            TCone cone1 = new TCone { Radius = 3, Height = 4 };
            TCone cone2 = new TCone { Radius = 3, Height = 4 };

            cone1.CircleMethods(); // Виклик для обчислення об'єму
            cone2.CircleMethods(); // Виклик для обчислення об'єму

            // Act
            int comparisonResult = cone1.Compare(cone2);

            // Assert
            Assert.AreEqual(0, comparisonResult, "Конуси з однаковим об'ємом повинні повертати 0.");
        }
        [TestMethod]
        public void OperatorSubtraction_CorrectDifferenceOfCones()
        {
            // Arrange
            TCone cone1 = new TCone { Radius = 5, Height = 8 };
            TCone cone2 = new TCone { Radius = 3, Height = 4 };

            // Act
            TCone result = cone1 - cone2;

            // Assert
            Assert.AreEqual(2.0, result.res_1, "Різниця радіусів повинна дорівнювати 2.");
            Assert.AreEqual(4.0, result.res_2, "Різниця висот повинна дорівнювати 4.");
        }




    }
}
