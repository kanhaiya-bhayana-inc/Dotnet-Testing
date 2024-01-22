using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sparky
{
    
    public class GradingCalculatorXUnitTests
    {
        private GradingCalculator gc;

        public GradingCalculatorXUnitTests()
        {
            this.gc = new GradingCalculator();
        }

        [Fact]
        public void GradeChecker_ScoreMoreThan90AndAttendancePercentageMoreThan70_ReturnsGradeA()
        {
            var excpected = "A";
            gc.Score = 92;
            gc.AttendancePercentage = 80;
            var actual = gc.GetGrade();
            Assert.Equal(excpected,actual);
        }
        [Fact]
        public void GradeChecker_ScoreMoreThan80AndAttendancePercentageMoreThan60_ReturnsGradeB()
        {
            var excpected = "B";
            gc.Score = 82;
            gc.AttendancePercentage = 70;
            var actual = gc.GetGrade();
            Assert.Equal(excpected, actual);
        }

        [Fact]
        public void GradeChecker_ScoreMoreThan60AndAttendancePercentageMoreThan60_ReturnsGradeC()
        {
            var excpected = "C";
            gc.Score = 62;
            gc.AttendancePercentage = 62;
            var actual = gc.GetGrade();
            Assert.Equal(excpected, actual);
        }
        [Theory]
        [InlineData(95, 55)]
        [InlineData(65, 55)]
        [InlineData(50, 90)]
        public void GradeChecker_FailureScenario_ReturnsGradeF(int score, int attendance)
        {
            var excpected = "F";
            gc.Score = score;
            gc.AttendancePercentage = attendance;
            var actual = gc.GetGrade();
            Assert.Equal(excpected, actual);
        }

        // combine all of the above test cases into one single test case


        [Theory]
        [InlineData(95, 90,  "A")]
        [InlineData(85, 90,  "B")]
        [InlineData(65, 90,  "C")]
        [InlineData(95, 65, "B")]

        [InlineData(95, 55,  "F")]
        [InlineData(65, 55,  "F")]
        [InlineData(50, 90,  "F")]

        public void GradeChecker_AllGradeLogicalScenario_GradeOutput(int score, int attendance, string expectedResult)
        {
            gc.Score = score;
            gc.AttendancePercentage = attendance;
            var result = gc.GetGrade();
            Assert.Equal(expectedResult, result);
        }
    }
}
