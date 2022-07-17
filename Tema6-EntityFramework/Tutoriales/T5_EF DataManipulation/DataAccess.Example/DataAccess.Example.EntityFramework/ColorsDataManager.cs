using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class ColorsDataManager : IColorDataManager
    {
        private readonly VehicleDataContext _dataContext;


        public ColorsDataManager(VehicleDataContext dataContext)
        { 
            _dataContext = dataContext;
        
        }


        public void Insert(Color color)
        { 
            _dataContext.Colors.Add(color);
            _dataContext.SaveChanges();
        
        }

        public void Update(Color color)
        { 
            var entity = _dataContext.Colors.Find(color.Id);

            entity.Code = color.Code;
            entity.Name = color.Name;

            _dataContext.SaveChanges();
        
        }

        public Color Get(int id)
        {
            var entity = _dataContext.Colors.Find(id);

            return entity;

        }
        public List<Color> GetAll()
        {
            var result = _dataContext.Colors.ToList();

            return result;
        }

        public void Delete(int id)
        {
            var entity = _dataContext.Colors.Find(id);
            _dataContext.Colors.Remove(entity);


            _dataContext.SaveChanges();

        
        }


    }
}
