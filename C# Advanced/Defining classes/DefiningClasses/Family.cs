using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = members.OrderByDescending(m => m.Age).FirstOrDefault();

            return oldestPerson;
        }
        public  List<Person> GetMembersAboveThirty()
        {
            
            List<Person> olderThanThitry = members.Where(m => m.Age > 30).OrderBy(m=>m.Name).ToList();

            return olderThanThitry;
        }


    }
}
