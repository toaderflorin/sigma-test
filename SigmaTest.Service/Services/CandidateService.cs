using System;
using Microsoft.EntityFrameworkCore;
using SigmaTest.Service.Controllers.Entities;
using SigmaTest.Service.Data;

namespace SigmaTest.Service.Logic
{
    public class CandidateService
    {
        public IEnumerable<Candidate> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Candidates.AsNoTracking().ToList();
            }
        }

        public Candidate GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                var existingCandidate = context.Candidates.Find(id);

                if (existingCandidate == null)
                {
                    throw new NotFoundException($"Candidate with id {id} was not found.");
                }

                return existingCandidate;
            }
        }

        public void Add(Candidate candidate)
        {
            using (var context = new AppDbContext())
            {
                context.Candidates.Add(candidate);
                context.SaveChanges();
            }
        }

        public void Update(Candidate candidate)
        {
            using (var context = new AppDbContext())
            {
                var existingCandidate = context.Candidates.Find(candidate.Id);

                if (existingCandidate == null)
                {
                    throw new NotFoundException($"Candidate with id {candidate.Id} was not found.");
                }

                context.Candidates.Update(candidate);
                context.SaveChanges();
            }
        }

        public void RemoveById(int id)
        {
            using (var context = new AppDbContext())
            {
                var candidate = context.Candidates.Find(id);

                if (candidate == null)
                {
                    throw new NotFoundException($"Candidate with id {id} was not found.");
                }

                context.Candidates.Remove(candidate);
                context.SaveChanges();
            }
        }
    }
}

