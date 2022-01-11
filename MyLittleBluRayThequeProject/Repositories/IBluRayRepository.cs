using MyLittleBluRayThequeProject.DTOs;
using MyLittleBluRayThequeProject.Entity;

namespace MyLittleBluRayThequeProject.Repositories
{
    public interface IBluRayRepository
    {
        BluRay Get();
        List<BluRayDto> GetListeBluRay();
    }
}
