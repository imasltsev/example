using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3 { 
    public class CandidateReportGenerator : IReportGenerator
{
    public void SortCandidate(List<Candidate> candidates)
    {
        var users = new List<object>();
        for (int i = 0; i < candidates.Count; i++)
        {
            users.Add(candidates[i]);
        }

        SortUser(users);
    }

    public void SortUser(List<object> users)
    {
        var candidates = new List<Candidate>();
        for (int i = 0; i < users.Count; i++)
        {
            candidates.Add((Candidate)users[i]);
        }

        
        candidates.Sort((a, b) => a.JobTitle.CompareTo(b.JobTitle));// Sort Jobtitle.

            
            for (int i = 0; i < candidates.Count; i++)// we sort by salary if the positions are the same.
            {
            var tmp = new Candidate();

            for (int j = i + 1; j < candidates.Count; j++)
            {
                if (j == candidates.Count)
                {
                    break;
                }

                if (candidates[i].JobTitle.Equals(candidates[j].JobTitle))
                {
                    if (candidates[i].JobSalary > candidates[j].JobSalary)
                    {
                        tmp = candidates[i];
                        candidates[i] = candidates[j];
                        candidates[j] = tmp;
                        tmp = null;
                    }
                }
            }
        }

        Console.WriteLine("\nSorted Candidates:");
        foreach (var user in candidates)
        {
            Console.WriteLine($"{user.Id} | {user.JobTitle,40} | {user.FullName,25} | ${user.JobSalary}");
        }
    }
}
}
