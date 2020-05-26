using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ApiService;
using ServiceReference1;
using App.Models;

namespace Proiect3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IList<string> _photoNames;
        public IList<string> isDeleted;
        public IList<string> Path;
        public IList<string> EventsId;
        public IList<string> NamePhoto;
        public IList<string> Date;
        public IList<string> PeopleGroupsId;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            _photoNames = new List<string>();

            var api = new ApiService.APIClient();
            List<string> v =  api.ReadAsync("Medias");
            IList<string> photos = v;
            foreach(var photo in photos)
            {
                _photoNames.Add(photo);
                isDeleted.Add(photo);
                Path.Add(photo);
                EventsId.Add(photo);
                NamePhoto.Add(photo);
                Date.Add(photo);
                PeopleGroupsId.Add(photo);

            }
            
        }
    }
}
