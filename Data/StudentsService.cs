using Bogus;
using Microsoft.EntityFrameworkCore;
using StudentsBlazorApp.Models;
using System.Linq;

namespace StudentsBlazorApp.Data
{
    public class StudentsService
    {
        private DatabaseContext dbContext;

        public StudentsService(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //    private static readonly string[] Summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        public async Task<List<Students>> GetStudentsAsync()
        {
            return await dbContext.students.Include(e => e.StudentClass).Include(s => s.StudentCountry)
                .ToListAsync();
        }
        public async Task<List<CountriesMaster>> GetCountriesAsync()
        {
            return await dbContext.countries.Include(c => c.StudentsList)
                .ToListAsync();
        }
        public async Task<List<Classes>> GetClassesAsync()
        {
            return await dbContext.classes.Include(cl => cl.studentsList)
                .ToListAsync();
        }

        public Students GetStudentsById(int id)
        {
            return dbContext.students.SingleOrDefault(x => x.Id == id);

        }


        public Classes GetClassById(int id)
        {
            return dbContext.classes.SingleOrDefault(x => x.Id == id);

        }
        public CountriesMaster GetCountryById(int id)
        {
            return dbContext.countries.SingleOrDefault(x => x.Id == id);

        }

        public void UpdateStudent(Students student)
        {
            var studetToUpdate = GetStudentsById(student.Id);
            studetToUpdate.StudentName = student.StudentName;
            studetToUpdate.DateOfBirth = student.DateOfBirth;
            studetToUpdate.StudentCountry = student.StudentCountry;
            studetToUpdate.StudentClass = student.StudentClass;

            dbContext.SaveChanges();
        }

        public void EditCountry(CountriesMaster country)
        {
            var countryToUpdate = GetCountryById(country.Id);
            countryToUpdate.CountryName = country.CountryName;


            dbContext.SaveChanges();
        }
        public void EditClass(Classes _class)
        {
            var classToUpdate = GetClassById(_class.Id);
            classToUpdate.ClassName = _class.ClassName;


            dbContext.SaveChanges();
        }

        public async Task DeleteStudent(Students student)
        {
            dbContext.students.Remove(student);
            dbContext.SaveChanges();

        }
        public async Task DeleteCountry(CountriesMaster country)
        {
            //   var c = dbContext.countries.First(country.Id).Include(e => e.StudentsList);
            // dbContext.countries.Find(country.Id).Include()
            country.StudentsList.Clear();
            dbContext.countries.Remove(country);
            dbContext.SaveChanges();

        }
        public async Task DeleteClass(Classes _class)
        {
            _class.studentsList.Clear();
            dbContext.classes.Remove(_class);
            dbContext.SaveChanges();

        }

        
        public void GenerateCountry()
        {
            var data = new Faker<CountriesMaster>()
                .RuleFor(c => c.CountryName, f => f.Address.Country());
            var output = data.Generate();

            CountriesMaster ccountr = new CountriesMaster();
            ccountr = output;
            dbContext.countries.Add(ccountr);
            dbContext.SaveChanges();
        }
        public void GenerateClass()
        {
            var data = new Faker<Classes>()
                .RuleFor(c => c.ClassName, f => f.Name.JobTitle());
            var output = data.Generate();

            Classes cclass = new Classes();
            cclass = output;
            dbContext.classes.Add(cclass);
            dbContext.SaveChanges();
        }
        public int GenerateStudents()
        {

            // List<classes> classsesids = new List<classes>();
            var classsesids = dbContext.classes.ToList();
            // List<countries> countriesids = new List<countries>();
            var countriesids = dbContext.countries.ToList();

            // List<int> clId = classsesids.Select(cl => cl.Id).ToList();


            var data = new Faker<Students>()
                .RuleFor(c => c.StudentName, f => f.Person.FullName)
                .RuleFor(s => s.DateOfBirth, d => d.Person.DateOfBirth)
                .RuleFor(c => c.StudentClass, f => f.PickRandom(classsesids))
                .RuleFor(c => c.StudentCountry, f => f.PickRandom(countriesids));
            ;
            var output = data.Generate();

            Students rndStudent = new Students();
            rndStudent = output;
            dbContext.students.Add(rndStudent);
            //throw new Exception("Error");

            return dbContext.SaveChanges();
        }

    }
}