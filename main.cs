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
        public HttpClient socket = new HttpClient()
        {
            socket.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            socket.DefaultRequestHeaders.Add("Content-Type", content);
            socket.DefaultRequestHeaders.Add("Content-Length", content);
            socket.MaxResponseContentBufferSize = 256000;
            socket.BaseAddress = "https://www.facebook.com/";
        }
        
        
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
                {}
                }
            }
            mdp = args[2];
            action = args[3];
            if (action.Length <= 0)
            {
                Console.WriteLine(@"Action must be 'connect', 'chat', 'poke', 'pokewar', 'add_friend' or 'upload' / Il faut donner le paramètre action comme ")
            }
            else
            {if action = }
        }
        
        public static void envoyer(string[] content)
        {
            socket.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            socket.DefaultRequestHeaders.Add("Content-Type", content);
            socket.DefaultRequestHeaders.Add("Content-Length", content);
            socket.MaxResponseContentBufferSize = 256000;
            socket.BaseAddress = "https://www.facebook.com/";
        }
        
        /*public static void envoyer_msg(string[] psuedo, string[] msg)
        {
            
        }*/
        
        /*public static void connecte()
        {
            
        }*/
    } 
}
