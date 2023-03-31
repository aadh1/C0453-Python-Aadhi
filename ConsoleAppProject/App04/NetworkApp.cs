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

            switch(choice)
            {
                 case 1: PostMessage(); break;
                case 2: PostImage(); break;
                case 3: RemovePost(); break; 
                case 4: DisplayAll(); break;
                case 5: DisplayByAuthor(); break;
                case 6: DisplayByDate(); break;
                case 7: AddComment(); break;
                case 8: LikePosts(); break;
                case 9: wantToQuit(); break;
            }

        } while (!wantToQuit);

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter post if > ",
            1, Post.GetNumberOfPosts());

        }

    

        private void DisplayAll()
        {
    object news = null;
    news.Display();
        }

        private void PostImage();
        {
        ConsoleHelper.OutputTitle("Posting an image/Photo");

        string author = InputName();

        Console.Write(" Please enter image file name > ");
        string filename = Console.Readline();

        Console.Write(" Please enter image caption > ");
        string caption = Console.ReadLine();

        PhotoPost post = new PhotoPost(author, filename, caption);
        news.AddPhotoPost(post);

        ConsoleHelper.OutputTitle(" You've posted this image");
        post.Display();


        }

        private void PostMessage();
        {
         ConsoleHelper.OutputTitle("Posting an message");

        string author = InputName();


        Console.Write(" Please enter your message > ");
        string message = Console.ReadLine();

        MessagePost post = new MessagePost(author, message);
        news.AddMessagePost(post);

        ConsoleHelper.OutputTitle(" You've posted this message");
        post.Display();
        }

        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }

    }   
}