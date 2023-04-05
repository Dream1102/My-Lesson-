using Application.IRepository;
using Domen.Interfaces;
using Domen.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Infrastructure
{
 

    public class CRUDforDoctor : IRepository<IDoctor>
    {

        static readonly string PathForProducts = @"..\..\..\..\Application\DataBase\PatientsDB.json";
        static readonly string pathForDoctors = @"..\..\..\..\Application\DataBase\DoctorsDB.json";
        static readonly string pathForQeue = @"..\..\..\..\Application\DataBase\QeueDB.json";
        public void Add(IDoctor item)
        {
            string JsonString = JsonConvert.SerializeObject(item);
            JArray DoctorArray = JArray.Parse(File.ReadAllText(pathForDoctors));
            JToken jtoken = JToken.FromObject(item);
            DoctorArray.Add(jtoken);
            File.WriteAllText(pathForDoctors, JsonConvert.SerializeObject(DoctorArray, Formatting.Indented));
        }

        public void Delete(Guid item)
        {
            if (Get(item) != null)
            {
                JArray arrayList= JArray.Parse(File.ReadAllText(pathForDoctors));
                arrayList.Remove(arrayList.FirstOrDefault(x => (Guid)x["ID"]==item));
                File.WriteAllText(pathForDoctors, JsonConvert.SerializeObject(arrayList,Formatting.Indented));
            }
            else Console.WriteLine("Jama");
        }

        public IDoctor? Get(Guid item)
        {
            JArray Readarray = JArray.Parse(File.ReadAllText(pathForDoctors));
            if (Readarray.Any(x => (Guid)x["ID"]==item))
            {
                JToken? doctor = Readarray.FirstOrDefault(doctor => (Guid)doctor["ID"]==item);
                
                string Json=JsonConvert.SerializeObject(doctor, Formatting.Indented);
                return JsonConvert.DeserializeObject<Doctor>(Json);
                
            }
            return null;
        }

        public List<IDoctor> GetAll()
        {
            JArray Array = JArray.Parse(File.ReadAllText(pathForDoctors));
            List<IDoctor> doctors= new List<IDoctor>();
            foreach (JToken doctor in Array)
            {
                string Jokenn = JsonConvert.SerializeObject(doctor, Formatting.Indented);
                doctors.Add(JsonConvert.DeserializeObject<Doctor>(Jokenn));

            }
            return doctors;
        }

        public void Update(Guid item,int WorkTime)
        {
            if(Get(item) != null)
            {
                JArray array=JArray.FromObject(GetAll());
                JToken doctor=JToken.FromObject(Get(item));
                array.FirstOrDefault(x => (Guid)x["ID"] == item)["WorkTime"] = WorkTime;
                File.WriteAllText(pathForDoctors,JsonConvert.SerializeObject(array, Formatting.Indented)); 
           
            }
        }

    }
}
