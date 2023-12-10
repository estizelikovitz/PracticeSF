using System;

namespace PracticeSFLibrary
{
    public class Class1
    {
    }
    public class Simcha
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
    }
    public class Deposit
    {
        public int Id { get; set; }
        public int ContributorId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
    public class Contributor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellNumber { get; set; }
        public bool AlwaysIncluded { get; set; }
    }
    public class Contribution
    {

        public int SimchaId { get; set; }
        public int ContributorId { get; set; }
        public decimal Amount { get; set; }
    }
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
    public class ContributionWithInclude
    {
        public int Id { get; set; }
        public int ContributorId { get; set; }
        public decimal Amount { get; set; }
        public bool Include { get; set; }
    }
}
