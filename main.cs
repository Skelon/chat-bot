using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web;

namespace ChatBot
{
    //public static bool langage;
    // 0 français
    // 1 english
    struct Bot 
    {
        public byte[] psuedo;
        public byte[] mdp;
        public HttpClient socket = new HttpClient(); 
    }
    
    public class FacebookSocket 
    {   
        public static void Main(string[] args)
        { 
            switch args[0]
            {
                case "login"
                {
                    Console.WriteLine("Connexion...")
                    if args[1].Length <= 0
                    {
                        Console.WriteLine("Username must be more than 5 characters. / Pseudo doit etre plus que 5 caractres.");
                    }
                case "chat"
                {
                    Console.Write("Enter the name of a person you want to chat with / Donnez le nom d\'une person vous voulez parler avec:");
                    nom = Console.Read();
                }
                }
            }
            mdp = args[2];

            if (action.Length <= 0)
            {
                Console.WriteLine(@"Action must be 'connect', 'chat', 'poke', 'pokewar', 'add_friend' or 'upload' / Il faut donner le paramètre action comme ")
            }
            else
            {
                switch action
                {
                    case ("add_friend" || "ajouter_ami")
                    {
                        Console.Write("Enter the name of the friend you want to add / Donnez le nom de votre ami vous voulez ajouter:");
                        ami = Console.Read();
                    }
                }
        }
        
        public static void envoyer(string[] args)
        {
            socket.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            socket.DefaultRequestHeaders.Add("Content-Type", content);
            socket.DefaultRequestHeaders.Add("Content-Length", content);
            socket.MaxResponseContentBufferSize = 256000;
            socket.BaseAddress = "https://www.facebook.com/";
        }
    } 
}
