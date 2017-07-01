using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Api.Repository
{
    public interface IRepository
    {
        void Add(int number, int result);
        int? Get(int number);
    }
}
