using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.IRepository;
using Domen.Interfaces;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Domen.Models;
using Domen.Enums;

namespace Infrastructure
{
    public class CRUDforPatient : IRepository<IPatient>
    {
        static readonly string PathForPatients = @"..\..\..\..\Application\DataBase\PatientDB.json";
        static readonly string pathForDoctors = @"..\..\..\..\Application\DataBase\DoctorsDB.json";
        public void Add(IPatient item)
        {
            string JsonString = JsonConvert.SerializeObject(item);
            JArray DoctorArray = JArray.Parse(File.ReadAllText(PathForPatients));
            JToken jtoken = JToken.FromObject(item);
            DoctorArray.Add(jtoken);
            File.WriteAllText(PathForPatients, JsonConvert.SerializeObject(DoctorArray, Formatting.Indented));
        }

        public void Delete(Guid item)
        {
            if (Get(item) != null)
            {
                JArray arrayList = JArray.Parse(File.ReadAllText(PathForPatients));
                arrayList.Remove(arrayList.FirstOrDefault(x => (Guid)x["ID"] == item));
                File.WriteAllText(PathForPatients, JsonConvert.SerializeObject(arrayList, Formatting.Indented));
            }
            else Console.WriteLine("Jama");
        }

        public IPatient? Get(Guid item)
        {
            JArray Readarray = JArray.Parse(File.ReadAllText(PathForPatients));
                JToken? doctor = Readarray.FirstOrDefault(doctor => (Guid)doctor["ID"] == item);
                //return doctor.OfType<IDoctor>().FirstOrDefault();
                string Json = JsonConvert.SerializeObject(doctor, Formatting.Indented);
                return JsonConvert.DeserializeObject<Patient>(Json);
        }

        public List<IPatient> GetAll()
        {
            JArray Array = JArray.Parse(File.ReadAllText(PathForPatients));
            List<IPatient> doctors = new List<IPatient>();
            foreach (JToken doctor in Array)
            {
                string Jokenn = JsonConvert.SerializeObject(doctor, Formatting.Indented);
                doctors.Add(JsonConvert.DeserializeObject<Patient>(Jokenn));

            }
            return doctors;
        }

        public void Update(Guid item, int Turnnumber)
        {
            if (Get(item) != null)
            {
                JArray array = JArray.FromObject(GetAll());
                JToken doctor = JToken.FromObject(Get(item));
                array.FirstOrDefault(x => (int)x["TurnNumber"] == Turnnumber)["TurnNumber"] = doctor["TurnNumber"];
                array.FirstOrDefault(x => (Guid)x["ID"] == item)["TurnNumber"] = Turnnumber;
                File.WriteAllText(PathForPatients, JsonConvert.SerializeObject(array, Formatting.Indented));
            }
        }
    }
}
