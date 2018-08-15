using SimpleLV.Model;
using SimpleLV.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLV.Controller
{
    public class ItemListController : BaseController
    {
        public ObservableCollection<Patient> Patients { get; set; }

        public ItemListController()
        {
            this.Patients = new ObservableCollection<Patient>();
            //Just for tesing
            this.Patients.Add(new Patient
            {
                DisplayName = "Patient 1"
            });
            this.Patients.Add(new Patient
            {
                DisplayName = "Patient 2"
            });
        }

        public async Task UpdatePostsAsync()
        {
            var newPatients = await MyHTTP.GetPatientsAsync();
            //this.Patients.Clear();
            newPatients.ForEach((post) =>
            {
                this.Patients.Add(post);
            });
        }
    }
}
