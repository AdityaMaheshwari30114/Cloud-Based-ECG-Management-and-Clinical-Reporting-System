using ECG.Models;
using System.Collections.Generic;

namespace ECG.Services
{
    public interface IPatientService
    {
        List<Patient> GetAllPatients();
        Patient GetPatientById(int id);
        bool AddPatient(Patient patient);
        bool UpdatePatient(Patient patient);
        bool DeletePatient(int id);
    }

    public class PatientService : IPatientService
    {
        public List<Patient> GetAllPatients()
        {
            // TODO: Implement database call
            return new List<Patient>();
        }

        public Patient GetPatientById(int id)
        {
            // TODO: Implement database call
            return null;
        }

        public bool AddPatient(Patient patient)
        {
            // TODO: Implement database call
            return true;
        }

        public bool UpdatePatient(Patient patient)
        {
            // TODO: Implement database call
            return true;
        }

        public bool DeletePatient(int id)
        {
            // TODO: Implement database call
            return true;
        }
    }
}
