using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ProjectManager : IProjectService
    {

        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }


        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public Project TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> TGetList()
        {
            return _projectDal.GetList();
        }

        public void TRemove(Project t)
        {
            _projectDal.Delete(t);
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
