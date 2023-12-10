using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSFLibrary
{
    public class PracticeSFDB
    {
        private string _connectionString;

        public PracticeSFDB(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Simcha> GetSimchas()
        {
            using var context = new PracticeSFDataContext(_connectionString);
            return context.Simchas.ToList();
        }
        public List<Contributor> GetContributors()
        {
            using var context = new PracticeSFDataContext(_connectionString);
            return context.Contributors.ToList();
        }
        public List<Contribution> GetContributions()
        {
            using var context = new PracticeSFDataContext(_connectionString);
            return context.Contributions.ToList();
        }
        public List<Deposit> GetDeposits()
        {
            using var context = new PracticeSFDataContext(_connectionString);
            return context.Deposits.ToList();
        }


        public int AddContributor(Contributor contributor)
        {
            using var context = new PracticeSFDataContext(_connectionString);
            context.Contributors.Add(contributor);
            context.SaveChanges();
            return contributor.Id;
        }
        public void AddDeposit(Deposit deposit)
        {
            using var context = new PracticeSFDataContext(_connectionString);
            context.Deposits.Add(deposit);
            context.SaveChanges();
        }
        public void AddSimcha(Simcha simcha)
        {
            using var context = new PracticeSFDataContext(_connectionString);
            context.Simchas.Add(simcha);
            context.SaveChanges();
        }
        public void AddContribution(Contribution contribution)
        {
            using var context = new PracticeSFDataContext(_connectionString);
            context.Contributions.Add(contribution);
            context.SaveChanges();
        }
        public void EditContributor(Contributor contributor)
        {
            using var context = new PracticeSFDataContext(_connectionString);
            context.Contributors.Update(contributor);
            context.SaveChanges();
        }
        public void Delete(int simchaId)
        {
            using var context = new PracticeSFDataContext(_connectionString);
            List<Contribution> c = context.Contributions.Where(c => c.SimchaId == simchaId).ToList();
            context.Contributions.RemoveRange(c);
            context.SaveChanges();
        }
        //public void Update(List<Contribution> c)
        //{
        //    using var context = new PracticeSFDataContext(_connectionString);
        //    //Contribution c = context.Contributions.FirstOrDefault(c => c.SimchaId == simchaId);
        //    context.Contributions.UpdateRange(c);
        //    context.SaveChanges(); 
        //}
        public void Update(List<ContributionWithInclude> cwi)
        {
            using var context = new PracticeSFDataContext(_connectionString);
            //Contribution c = context.Contributions.FirstOrDefault(c => c.SimchaId == simchaId);
            context.ContributionWithIncludes.UpdateRange(cwi);
            context.SaveChanges();
        }
    }
}
