using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    // Discount criteria interface
    public interface IDiscountCriterion
    {
        bool IsApplicable(Flight flight, DateTime purchaseDate, Person p);
    }
    public class EndsA_Criterion : IDiscountCriterion
    {
        public bool IsApplicable(Flight flight, DateTime purchaseDate, Person p)
        {
            return flight.To.EndsWith("a");
        }
    }
    public class Africa_Criterion : IDiscountCriterion
    {
        public bool IsApplicable(Flight flight, DateTime purchaseDate, Person p)
        {
            return flight.To == "Africa";
        }
    }
    public class Children_Criterion : IDiscountCriterion
    {
        public bool IsApplicable(Flight flight, DateTime purchaseDate, Person p)
        {
            int age = purchaseDate.Year - p.BirthDate.Year;
            return age < 18;
        }
    }
    /// <summary>
    /// celowo zmokowane na true
    /// </summary>
    public class Satrurday_Criterion : IDiscountCriterion
    {
        public bool IsApplicable(Flight flight, DateTime purchaseDate, Person p)
        {
            return true;
        }
    }
    public class BirthdayDiscountCriterion : IDiscountCriterion
    {
        public bool IsApplicable(Flight flight, DateTime purchaseDate, Person p)
        {
            return purchaseDate.Date == p.BirthDate;
        }
    }

    public class GenderDiscountCriterion : IDiscountCriterion
    {
        public GenderDiscountCriterion(Gender gender)
        {
            this.gender = gender;
        }

        public Gender gender { get; set; }

        public bool IsApplicable(Flight flight, DateTime purchaseDate, Person p)
        {
            return p.Gender == gender;
        }
    }
}
