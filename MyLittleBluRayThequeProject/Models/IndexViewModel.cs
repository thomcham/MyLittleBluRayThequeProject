using MyLittleBluRayThequeProject.DTOs;

namespace MyLittleBluRayThequeProject.Models
{
    public class IndexViewModel
    {
        public List<BluRayDto> BluRays { get; set; }

        public BluRayDto SelectedBluRay { get; set; }
    }
}
