using FirstAPI.Interfaces;

namespace FirstAPI.Services
{
    public class DoctorService : IDoctorService
    {   
        public DoctorServcie(IRepository<int,Doctor> doctorRepository,
                            IRepository<s=int,Speciality> specialityRepository,
                            IRepository<int,DoctorSpeciality> doctorSpecialityRepository)
        {
            
        }

    }
}