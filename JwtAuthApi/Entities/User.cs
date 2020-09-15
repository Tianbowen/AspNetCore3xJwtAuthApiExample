using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JwtAuthApi.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
