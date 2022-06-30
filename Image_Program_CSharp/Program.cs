using System;
namespace Image_Program_CSharp;
class Program
{

    static void Main(string[] args)
    {
        List<Image> images = new List<Image>();
        bool menu = true;
        while (menu == true) {

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add Image\n2. Remove Image\n3. Edit Image\n4. Display Images\n5. Quit");
            int userSelection = Convert.ToInt32(Console.ReadLine());

            switch (userSelection) {
                case 1:
                    Console.WriteLine("What is the image name?: ");
                    string imageNameAdd = Console.ReadLine();
                    Console.WriteLine("When was the image taken?(MM/DD/YY): ");
                    string imageDateAdd = Console.ReadLine();
                    Console.WriteLine("What is the image URL?: ");
                    string imageURLAdd = Console.ReadLine();

                    Image newImage = new Image();
                    newImage.add_info(imageNameAdd, imageDateAdd, imageURLAdd);
                    images.Add(newImage);
                    Console.WriteLine($"Image {imageNameAdd} added!");

                    break;
                case 2:
                    Console.WriteLine("What is the name of the image to remove?: ");
                    string imageNameRemove = Console.ReadLine();

                    foreach (Image image in images)
                    {
                        if (image.get_name() == imageNameRemove) { 
                            images.Remove(image);
                            break;
                        }
                    }

                    Console.WriteLine($"Image ({imageNameRemove}) removed!");
                    break;

                case 3:
                    Console.WriteLine("What is the name of the image to edit?: ");
                    string imageNameEdit = Console.ReadLine();
                    Console.WriteLine("What would you like to edit?\n   1. Name\n   2. Date\n   3. URL");
                    int imageEditSelection = Convert.ToInt32(Console.ReadLine());
                    switch (imageEditSelection) {
                        case 1:
                            Console.WriteLine("What is the new name?:");
                            string imageEditNewName = Console.ReadLine();

                            foreach (Image image in images) {
                                if (image.get_name() == imageNameEdit) {
                                    image.edit_name(imageEditNewName);
                                    break;
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine("What is the new Date?: ");
                            string imageEditNewDate = Console.ReadLine();

                            foreach (Image image in images)
                            {
                                if (image.get_name() == imageNameEdit)
                                {
                                    image.edit_date(imageEditNewDate);
                                    break;
                                }
                            }
                            break;

                        case 3:
                            Console.WriteLine("What is the new URL?: ");
                            string imageEditNewURL = Console.ReadLine();

                            foreach (Image image in images)
                            {
                                if (image.get_name() == imageNameEdit)
                                {
                                    image.edit_URL(imageEditNewURL);
                                    break;
                                }
                            }
                            break;

                    }
                    break;

                case 4:
                    foreach (Image image in images) {
                        image.display_image();
                    }

                    break;

                case 5:
                    menu = false;
                    break;

             }
        }
    }
}