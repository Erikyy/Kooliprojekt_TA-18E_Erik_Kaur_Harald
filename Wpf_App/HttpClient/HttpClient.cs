﻿using Newtonsoft.Json;
using SimpleImageGallery.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Wpf_App.HttpClient
{
    public class HttpClient
    {
        private const string BaseUrl = "http://localhost:59852/api/";



        public async Task<IList<ImageController>> List(int page)

        {

            using (HttpClient client = new HttpClient())

            {

                var json = await client.GetStringAsync(BaseUrl + "List?page=" + page);



                return JsonConvert.DeserializeObject<List<ImageController>>(json);

            }

        }
    }
}
