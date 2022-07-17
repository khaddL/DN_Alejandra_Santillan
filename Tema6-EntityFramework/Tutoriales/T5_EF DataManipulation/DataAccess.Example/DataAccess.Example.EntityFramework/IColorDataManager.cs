using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
     public interface IColorDataManager
    {
        void Insert(Color color);

        void Update(Color color);


        Color Get(int id);

        List<Color> GetAll();



        void Delete(int id);
        

    }
}
