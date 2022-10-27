using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetWalks();
        List<Walk> GetWalksByWalker(int walkerId);
    }
}
