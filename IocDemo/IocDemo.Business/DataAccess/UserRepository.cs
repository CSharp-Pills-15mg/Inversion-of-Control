namespace IocDemo.Business.DataAccess;

public class UserRepository
{
    public IEnumerable<User> GetAll()
    {
        return new List<User>()
        {
            new User()
            {
                Name = "Flaviu Comănese",
                Gender = Gender.Male,
                Country = "Romania"
            },
            new User()
            {
                Name = "Raluca Dănilă",
                Gender = Gender.Female,
                Country = "Romania"
            },
            new User()
            {
                Name = "Oana Faur",
                Gender = Gender.Female,
                Country = "Romania"
            },
            new User()
            {
                Name = "Alexandru Iuga",
                Gender = Gender.Male,
                Country = "Romania"
            },
            new User()
            {
                Name = "Musab Arif",
                Gender = Gender.Male,
                Country = "India"
            },
            new User()
            {
                Name = "Ramkumar Seetharaman",
                Gender = Gender.Male,
                Country = "India"
            },
            new User()
            {
                Name = "Sushant Gawas",
                Gender = Gender.Male,
                Country = "India"
            },
            new User()
            {
                Name = "Cristi Laza",
                Gender = Gender.Male,
                Country = "Romania"
            }
        };
    }
}