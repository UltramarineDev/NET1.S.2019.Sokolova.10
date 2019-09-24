using NUnit.Framework;
using System;

namespace IntegerConverter.Tests
{
    public class CustomConverterTests
    {
        [TestCase(new string[] { "101", "0", "101011", "11", "11101", "101010", "10", "1101" }, 2, ExpectedResult = new int[] { 5, 0, 43, 3, 29, 42, 2, 13 })]
        [TestCase(new string[] { "2", "21", "0", "2101", "222201", "222", "10", "1101" }, 3, ExpectedResult = new int[] { 2, 7, 0, 64, 721, 26, 3, 37 })]
        [TestCase(new string[] { "33", "0", "1012", "11", "321", "333101", "10", "1101" }, 4, ExpectedResult = new int[] { 15, 0, 70, 5, 57, 4049, 4, 81 })]
        [TestCase(new string[] { "101", "0", "43012", "11", "440", "1101" }, 5, ExpectedResult = new int[] { 26, 0, 2882, 6, 120, 151 })]
        [TestCase(new string[] { "101", "0", "53012", "550", "10", "1101" }, 6, ExpectedResult = new int[] { 37, 0, 7136, 210, 6, 253 })]
        [TestCase(new string[] { "101", "30", "66051", "635", "10", "1101" }, 7, ExpectedResult = new int[] { 50, 21, 16500, 320, 7, 393 })]
        [TestCase(new string[] { "101", "70", "376", "432", "600", "1101" }, 8, ExpectedResult = new int[] { 65, 56, 254, 282, 384, 577 })]
        [TestCase(new string[] { "101", "88", "500", "81", "106", "1101" }, 9, ExpectedResult = new int[] { 82, 80, 405, 73, 87, 811 })]
        [TestCase(new string[] { "101A", "15", "9A1", "76" }, 11, ExpectedResult = new int[] { 1352, 16, 1200, 83 })]
        [TestCase(new string[] { "AB", "15B", "10", "9801" }, 12, ExpectedResult = new int[] { 131, 215, 12, 16705 })]
        [TestCase(new string[] { "BCA", "15C", "101", "431" }, 13, ExpectedResult = new int[] { 2025, 246, 170, 716 })]
        [TestCase(new string[] { "DA", "C21", "10", "76" }, 14, ExpectedResult = new int[] { 192, 2381, 14, 104 })]
        [TestCase(new string[] { "1B", "EA", "432", "2" }, 15, ExpectedResult = new int[] { 26, 220, 947, 2 })]
        [TestCase(new string[] { "FE3", "129", "A9", "1BC35", "111", "9D" }, 16, ExpectedResult = new int[] { 4067, 297, 169, 113717, 273, 157 })]
        public int[] ConvertToIntTests(string[] inputSet, int p)
            => CustomConverter.ConvertToInt(inputSet, p);

        [Test]
        public void ConvertToIntMethod_InvalidNumber_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] { "12", "65A", "1C", "B54"}, 12));
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] { "12", "602", "100", "545" }, 6));
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] { "120", "65AF", "1C", "B54" }, 15));
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] { "12", "65A", "103", "101" }, 3));
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] {}, 3));
        }

        [Test]
        public void ConvertToIntMethod_EmptyArray_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => CustomConverter.ConvertToInt(null, 12));
        }

        [Test]
        public void ConvertToIntMethod_InvalidNumeralSystem_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] { "101", "0", "43012"}, 23));
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] { "101", "0", "43012" }, 1));
            Assert.Throws<ArgumentException>(() => CustomConverter.ConvertToInt(new string[] { "101", "0", "43012" }, -8));
        }
    }
}
