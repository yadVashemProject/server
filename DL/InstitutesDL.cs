using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace DL
{
    public class InstitutesDL : IinstitutesDL
    {
        string jListPath = ConfigurationManager.AppSettings[@"C:\Users\user\Desktop\YadVashemProject\מוסדות.json"];//@"D:\list.txt";
        public async Task<List<Institutes>> getAllInstitutes()
        {
            List<Institutes> institutes;
            try
            {
                string path = @"C:\Users\user\Desktop\YadVashemProject\server\DL\מוסדות.json";
                FileStream fs = new FileStream(path, FileMode.Open);
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<Institutes>));
                institutes = js.ReadObject(fs) as List<Institutes>;
                Console.WriteLine(institutes);
                fs.Close();
            }
            catch (Exception ex)
            {
                institutes = new List<Institutes>();
                Console.WriteLine(ex.Message);
            }
            return institutes;
        }
    }
}
