using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustData.Model
{
    public class PersonModel
    {
        //initial data
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }


        public void HelloDisplay(string message)
        {
            Console.WriteLine($"this message from reference class: {message}");
        }

    }

}
