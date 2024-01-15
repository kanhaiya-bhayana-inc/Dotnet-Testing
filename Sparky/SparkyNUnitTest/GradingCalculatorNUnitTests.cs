using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator gc;

        [SetUp]
        public void Setup()
        {
            this.gc = new GradingCalculator();
        }

        [Test]
        public void GradeChecker_ScoreMoreThan90AndAttendancePercentageMoreThan70_ReturnsGradeA()
        {
            var excpected = "A";
            gc.Score = 92;
            gc.AttendancePercentage = 80;
            var actual = gc.GetGrade();
            Assert.That(actual, Is.EqualTo(excpected));
        }
        [Test]
        public void GradeChecker_ScoreMoreThan80AndAttendancePercentageMoreThan60_ReturnsGradeB()
        {
            var excpected = "B";
            gc.Score = 82;
            gc.AttendancePercentage = 70;
            var actual = gc.GetGrade();
            Assert.That(actual, Is.EqualTo(excpected));
        }

        [Test]
        public void GradeChecker_ScoreMoreThan60AndAttendancePercentageMoreThan60_ReturnsGradeC()
        {
            var excpected = "C";
            gc.Score = 62;
            gc.AttendancePercentage = 62;
            var actual = gc.GetGrade();
            Assert.That(actual, Is.EqualTo(excpected));
        }
        [Test]
        [TestCase(95,55)]
        [TestCase(65,55)]
        [TestCase(50,90)]
        public void GradeChecker_FailureScenario_ReturnsGradeF(int score, int attendance)
        {
            var excpected = "F";
            gc.Score = score;
            gc.AttendancePercentage = attendance;
            var actual = gc.GetGrade();
            Assert.That(actual, Is.EqualTo(excpected));
        }

        // combine all of the above test cases into one single test case

        
        [Test]
        

        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]

        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]

        public string GradeChecker_AllGradeLogicalScenario_GradeOutput(int score, int attendance)
        {
            gc.Score = score;
            gc.AttendancePercentage = attendance;
            return gc.GetGrade();
        }
    }
}
