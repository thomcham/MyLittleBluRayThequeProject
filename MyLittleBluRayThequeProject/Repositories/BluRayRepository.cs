using MyLittleBluRayThequeProject.DTOs;
using MyLittleBluRayThequeProject.Entity;

namespace MyLittleBluRayThequeProject.Repositories
{
    public class BluRayRepository
    {

        /// <summary>
        /// Consctructeur par défaut
        /// </summary>
        public BluRayRepository()
        {
        }

        /*
        public BluRay Get(){
            return context.GetDbSet<BluRay>().FirstOrDefault();

        }*/

        public List<BluRayDto> GetListeBluRay()
        {
            return new List<BluRayDto>
            { 
                new BluRayDto
                {
                    Id = 0,
                    Titre = "My Little film 1",
                    DateSortie = DateTime.Now,
                    Version = "Courte",
                    Acteurs = new List<PersonneDto>
                    {
                        new PersonneDto
                        {
                            Id = 0,
                            Nom = "Per",
                            Prenom = "Sonne",
                            Nationalite = "Fr",
                            DateNaissance = DateTime.Now,
                            Professions = new List<string>{"Acteur"}
                        }
                    }
                },
                new BluRayDto
                {
                    Id = 1,
                    Titre = "My Little film 2",
                    DateSortie = DateTime.Now,
                    Version = "Longue",
                    Acteurs = new List<PersonneDto>
                    {
                        new PersonneDto
                        {
                            Id = 0,
                            Nom = "Per",
                            Prenom = "Sonne",
                            Nationalite = "Fr",
                            DateNaissance = DateTime.Now,
                            Professions = new List<string>{"Acteur"}
                        }
                    }
                }
            };
        }
    }
}
