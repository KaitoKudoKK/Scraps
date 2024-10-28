using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Chat
    {
        public int ChatID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        private static List<Chat> chatHistory = new List<Chat>();

        // Konstruktor
        public Chat(int chatID, int senderID, int receiverID, string content)
        {
            ChatID = chatID;
            SenderID = senderID;
            ReceiverID = receiverID;
            Content = content;
            Timestamp = DateTime.Now;
        }

        // MMethod untuk mengirim chat
        public void SendMessage()
        {
            chatHistory.Add(this);
            Console.WriteLine($"Message sent from User {SenderID} to User {ReceiverID} at {Timestamp}: {Content}");
        }

        // Method untuk menghapus chat berdasar chatID
        public void DeleteMessage()
        {
            var messageToDelete = chatHistory.Find(chat => chat.ChatID == this.ChatID);
            if (messageToDelete != null)
            {
                chatHistory.Remove(messageToDelete);
                Console.WriteLine($"Message with ID {ChatID} deleted.");
            }
            else
            {
                Console.WriteLine("Message not found.");
            }
        }

        // Static method untuk retrieve riwayat chat 
        public static List<Chat> GetChatHistory(int userId1, int userId2)
        {
            return chatHistory.FindAll(chat => 
                (chat.SenderID == userId1 && chat.ReceiverID == userId2) || 
                (chat.SenderID == userId2 && chat.ReceiverID == userId1));
        }
    }
}
