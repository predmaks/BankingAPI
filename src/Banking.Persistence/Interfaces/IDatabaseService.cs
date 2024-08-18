using Banking.Domain.Users;

namespace Banking.Persistence.Interfaces
{
    public interface IDatabaseService
    {
        /// <summary>
        /// Creates new user in the database.
        /// </summary>
        /// <param name="user">The user to be created.</param>
        /// <returns></returns>
        Task AddUser(User user);

        /// <summary>
        /// Persists the changes in the database.
        /// </summary>
        /// <returns></returns>
        Task SaveChanges();

        /// <summary>
        /// Retrieves all users from database.
        /// </summary>
        /// <returns>The collection of users.</returns>
        Task<IEnumerable<User>> GetAllUsers();
    }
}
