using Banking.Domain.Users;
using Banking.Persistence.Interfaces;

namespace Banking.Persistence
{
    /// <summary>
    /// The fake database class, which will be serving as an in-memory instance for the purpose of this demo.
    /// </summary>
    public class FakeDatabase : IDatabaseService
    {
        // NOTE: not much time, the Domain should not be references by the persistence, there should be DAO model, with mappings coming out of here to the upper layer
        private static List<User> _users;

        public FakeDatabase()
        {
            _users = new List<User>
            {
                new User("user1")
                {
                    Id = new Guid("b63ed9a2-05a6-4344-98e6-92ebf282142a")
                }
            };
        }

        public async Task AddUser(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;
        }

        public async Task SaveChanges()
        {
        }

        public async Task<IEnumerable<User>> GetAllUsers() => await Task.FromResult(_users);
    }
}
