using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using dandd.Models;
using dandd.Services;

namespace dandd.ViewModels
{
    internal class RaceViewModel
    {
        private readonly RaceService raceService;

        public string index;

        public string name;

        public string full_name;

        public string desc;

        public int skills;

        private readonly RaceModel Race;

        public RaceViewModel() 
        {
           Race = new RaceModel();
            raceService = new RaceService();

        }
        public ICommand GetPhotoCommand => new Command(async () => await GetName());

        private async Task RenderName()
        {
            name = await GetName();
        }
        public string GetName(RaceModel Name)
        {
            name = full_name.Trim();
            return name;
        }
    }
}
