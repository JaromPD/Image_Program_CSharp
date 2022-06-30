using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Program_CSharp
{
    internal class Image
    {
        private string? name = null;
        private string? date = null;
        private string? URL = null;

        //private Image() { }

        public void add_info(string userImageName, string userImageDate, string userImageURL)
        {
            name = userImageName;
            date = userImageDate;
            URL = userImageURL;
        }

        public void display_image() {
            Console.WriteLine($"Name: {name} Image: {date} Date: {URL}");
        }

        public string get_name() {
            if (name != null)
            {
                return name;
            }
            else
            {
                return "None";
            }
        }

        public string get_date() {
             if (date != null)
            {
                return date;
            }
            else
            {
                return "None";
            }
        }
        public string get_url() {
            if (URL != null)
            {
                return URL;
            }
            else
            {
                return "None";
            }
        }

        public void edit_name(string newName) {
            name = newName;
        }

        public void edit_date(string newDate)
        {
            date = newDate;
        }

        public void edit_URL(string newURL)
        {
            URL = newURL;
        }

    }
}
