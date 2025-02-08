using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeProcessor.Tests
{
    public class GradeEvaluatorTests
    {
        [Fact]
        public void ComputeAverage_ShouldReturnCorrectValue()
        {
            List<int> scores = new List<int> { 85, 95, 75 };
            double output = GradeProcessor.Core.GradeEvaluator.ComputeAverage(scores);
            Assert.Equal(85.0, output, 1);
        }

        [Fact]
        public void ComputeAverage_ShouldThrowExceptionForEmptyList()
        {
            List<int> scores = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeEvaluator.ComputeAverage(scores));
        }

        [Fact]
        public void ComputeAverage_ShouldProcessLargeDatasetEfficiently()
        {
            List<int> scores = Enumerable.Range(1, 100_000_000).ToList();
            DateTime startTime = DateTime.UtcNow;
            GradeProcessor.Core.GradeEvaluator.ComputeAverage(scores);
            DateTime endTime = DateTime.UtcNow;
            double executionTime = (endTime - startTime).TotalMilliseconds;
            Assert.True(executionTime < 200, $"Execution took {executionTime} ms");
        }

        [Fact]
        public void GetMaxScore_ShouldReturnHighestValue()
        {
            List<int> scores = new List<int> { 82, 91, 108 };
            int output = GradeProcessor.Core.GradeEvaluator.GetMaxScore(scores);
            Assert.Equal(108, output);
        }

        [Fact]
        public void GetMaxScore_ShouldThrowExceptionForEmptyList()
        {
            List<int> scores = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeEvaluator.GetMaxScore(scores));
        }

        [Fact]
        public void ComputeMedian_ShouldReturnCorrectMedian()
        {
            List<int> scores = new List<int> { 77, 88, 99 };
            double output = GradeProcessor.Core.GradeEvaluator.ComputeMedian(scores);
            Assert.Equal(88.0, output, 1);
        }

        [Fact]
        public void ComputeMedian_ShouldHandleEvenNumberOfScores()
        {
            List<int> scores = new List<int> { 70, 80, 90, 100 };
            double output = GradeProcessor.Core.GradeEvaluator.ComputeMedian(scores);
            Assert.Equal(85.0, output, 1); // (80 + 90) / 2 = 85
        }

        [Fact]
        public void ComputeMedian_ShouldThrowExceptionForEmptyList()
        {
            List<int> scores = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeEvaluator.ComputeMedian(scores));
        }
    }
}
