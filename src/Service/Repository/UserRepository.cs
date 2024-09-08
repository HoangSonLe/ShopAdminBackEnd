using Application.Interfaces;
using Core.Enums;
using Infrastructure.DBContexts;
using Infrastructure.Entitites;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository
{
    public class UserRepository : RepositoryGenerator<User>, IUserRepository
    {
        public UserRepository(SampleDBContext context, SampleReadOnlyDBContext readOnlyDBContext) : base(context, readOnlyDBContext)
        {
           
        }
        public async Task<User> GetUserWithRolesByUserNameAsync(string userName)
        {
            var _context = (SampleReadOnlyDBContext)_dbReadOnlyContext;
            // Create a query with LINQ query syntax
            var query = from c in _context.CustomerInfors
                        join b in _context.Bills
                            on c.CustomerId equals b.CustomerId into b1
                        from b in b1.DefaultIfEmpty()
                        select new
                        {
                            c,
                            b
                        };
            // Execute the query and return the result
            var result = await query.ToListAsync();
            return await _context.Users
                                      .Include(u => u.Roles)
                                          .ThenInclude(ur => ur.Role)
                                      .FirstOrDefaultAsync(user => user.UserName.ToLower() == userName.ToLower() && user.State == (short)EState.Active);
         
        }
    }
}
