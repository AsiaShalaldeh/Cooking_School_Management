using CookingSchoolManagement.Data;
using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingSchoolManagement.Services
{
    public class FavoritesService : IFavoritesService
    {
        private readonly SchoolContext _context;
        public FavoritesService(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Favorites> GetFavorites()
        {
            try
            {
                return _context.Favorites.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
