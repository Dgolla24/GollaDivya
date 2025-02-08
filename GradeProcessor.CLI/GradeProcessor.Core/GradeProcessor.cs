using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeProcessor.Core
{
    public class GradeEvaluator
    {
        public static double ComputeAverage(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
            {
                throw new ArgumentException("Score list cannot be empty.");
            }
            return scores.Average();
        }

        public static int GetMaxScore(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
            {
                throw new ArgumentException("Score list must contain at least one element.");
            }
            return scores.Max();
        }

        public static double ComputeMedian(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
            {
                throw new ArgumentException("Scores list must have values.");
            }

            var sortedScores = scores.OrderBy(x => x).ToList();
            int count = sortedScores.Count;
            if (count % 2 == 1)
            {
                return sortedScores[count / 2];
            }
            else
            {
                return (sortedScores[(count / 2) - 1] + sortedScores[count / 2]) / 2.0;
            }
        }
    }
}
