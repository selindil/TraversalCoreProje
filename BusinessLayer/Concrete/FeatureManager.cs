using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager:IFeatureService
    {
        IFeatureDal _featurDal;

        public FeatureManager(IFeatureDal featurDal)
        {
            _featurDal = featurDal;
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            return _featurDal.GetList();
        }

        public void TAdd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
