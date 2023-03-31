using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{

    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

    
        /// DisplayMenu///
        public void DisplayMenu();

        ConsoleHelper.OutputHeading (" Aadhi's News Feed");

        string[] choices = new string[]
        (
            "Post Message", "Post Image", ""+
            "DisplayMenu All Posts", "Quit"
        );

        bool wantToQuit = false;
        do
        {
            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            (

                case 1: PostMessage(); break;
                case 2: PostImage(); break;
                case 3: DisplayAll(); break;
                case 4: wantToQuit(); break;

            )

        } while (!wantToQuit);

    }

    private void DisplayAll();
    {
        news.Display();
    }

    private void PostImage();
    {
        ();
    }

    private void PostMessage();
    {
        ();
    }
    

} 

    


