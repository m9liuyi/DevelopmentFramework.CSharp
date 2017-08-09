using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.Enum;

namespace CSharpDemo.Models.Entity.ORM
{
    public class CSharpDemoInitializer : DropCreateDatabaseIfModelChanges<CSharpDemoContext>
    {
        protected override void Seed(CSharpDemoContext context)
        {
            var contacts = new List<Contact>()
            {
                new Contact () {Name = "皇帝", EnrollmentDate = DateTime.Parse("2009-10-01") },
                new Contact () {Name = "书包", EnrollmentDate = DateTime.Parse("2010-10-01") },
                new Contact () {Name = "Mp3", EnrollmentDate = DateTime.Parse("2010-03-01") },
                new Contact () {Name = "泡椒", EnrollmentDate = DateTime.Parse("2010-03-02") },
                new Contact () {Name = "甜瓜", EnrollmentDate = DateTime.Parse("2010-03-03") },
            };
            contacts.ForEach(p => context.Contacts.Add(p));
            context.SaveChanges();

            var groups = new List<Group>()
            {
                new Group () {GroupName = GroupName.Colleague },
                new Group () {GroupName = GroupName.Family },
                new Group () {GroupName = GroupName.Friend },
                new Group () {GroupName = GroupName.Schoolmate },
                new Group () {GroupName = GroupName.Stranger },
            };
            groups.ForEach(p => context.Groups.Add(p));
            context.SaveChanges();

            var enrollments = new List<Enrollment>()
            {
                new Enrollment () { ContactID = 1, GroupID = 1 },
                new Enrollment () { ContactID = 2, GroupID = 2 },
                new Enrollment () { ContactID = 3, GroupID = 3 },
                new Enrollment () { ContactID = 4, GroupID = 4 },
                new Enrollment () { ContactID = 5, GroupID = 5 },
            };
            enrollments.ForEach(p => context.Enrollments.Add(p));
            context.SaveChanges();


            //base.Seed(context);
        }
    }
}
