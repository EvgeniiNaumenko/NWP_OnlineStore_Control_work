using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public static class Global
    {
        public static readonly HttpClient httpClient = new HttpClient();
        public static int userId = 0;

        public static readonly string serverUrl = "https://localhost:7284/";
    }
}
