using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Commanders
{
    public class HomeController : Controller
    {
        [Route("/h")]
        public string Hello() { return "Hello World!"; }
        [Route("/g")]
        public string Goodbye() { return "Goodbye World!"; }
        [Route("/n")]
        public string DontGo() { return "Nooooooo! Don't leave the world!!!"; }

        [Produces("text/html")]
        [Route("/l")]
        public string Letter()
        {
          return
          "<!DOCTYPE html>" +
          "<html>" +
          "<head>" +
            "<title>Hello World!</title>" +
            "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" + "<link rel='stylesheet' href=/css/styles.css'>" +
          "</head>" +
          "<body>" +
            "<h1>Hello From Me</h1>" +
            "<p>Dear World,</p>" +
            "<p>How are you? I hope that you are having a nice weekend. I'm learning programming while in Iceland! </p>" +
            "<p>World, you would not believe how cold it is here. I should have gone to Hawaii instead.</p>" +
            "<p>But I like programming a lot, so I've got that going for me. </p>" +
            "<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>" +
            "<p>Cheers,</p>" +
            "<p>Travel Enthusiast Me √ß</p>" +
          "</body>" +
          "</html>";
        }

        [Produces("text/html")]
        [Route("/favorite_photos")]
        public string FavoritePhotos()
        {
        return
          "<!DOCTYPE html>" +
          "<html>" +
            "<head>" +
              "<title>Hello World!</title>" +
              "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
              "<link rel='stylesheet' href='css/styles.css' type='text/css'>" +
            "</head>" +
            "<body>" +
              "<h1>Favorite Traveling Photos</h1>" +
              "<ul>" +
                "<li><img src='/img/photo1.jpg'/></li>" +
                "<li><img src='/img/photo2.jpg'/></li>" +
                "<li><img src='/img/photo3.jpg'/></li>" +
                "<li><img src='/img/photo4.jpg'/></li>" +
              "</ul>" +
            "</body>" +
          "</html>";
        }
    }
}
