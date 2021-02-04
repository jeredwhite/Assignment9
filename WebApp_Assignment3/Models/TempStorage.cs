using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Assignment3.Models
{
    public static class TempStorage
    {
        private static List<SubmissionResponse> movies = new List<SubmissionResponse>();

        public static IEnumerable<SubmissionResponse> Applications => movies;

        public static void AddSubmission(SubmissionResponse movie)
        {
            movies.Add(movie);
        }
    }
}
