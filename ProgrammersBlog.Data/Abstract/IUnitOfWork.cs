using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        IRoleRepository Roles { get; }
        ICommentRepository Comments { get; }
        IUserRepository Users { get; }

        Task<int> SaveAsync();
    }
}
