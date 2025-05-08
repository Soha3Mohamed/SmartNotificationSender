namespace SmartNotificationSender
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //the idea of the project is about the send function that is shared across many senders(classes)
            //and each has a message to send to a recipient(detected at the creation of an instance of the sender itself

            
            Console.WriteLine("Welcome you beautiful one , please choose the way you want to send your message");
            
            string message;

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("1.Email");
                Console.WriteLine("2.Phone Number");
                Console.WriteLine("3.Push");

                int click = int.Parse(Console.ReadLine());
                //what if i made a generic class creator where if a user chooses another way, he inters it and with some validation, the sender is created
                //remember the compiler ????promise me you would try it
                switch (click)
                {
                    case 1:
                        Console.WriteLine("Enter the recipient you want to send the message to: ");
                        string email = Console.ReadLine();
                        EmailSender emailSender = new EmailSender(email);
                        HandleMessage(emailSender);
                        break;

                    case 2:
                        Console.WriteLine("Enter the phone number you want to send the message to: ");
                        string phoneNumber = Console.ReadLine();
                        PhoneNumberSender phoneNumberSender = new PhoneNumberSender(phoneNumber);
                        HandleMessage(phoneNumberSender);
                        break;
                    case 3:

                        Console.WriteLine("Enter the push you want to send the message to: ");
                        string push = Console.ReadLine();
                        PushSender pushSender = new PushSender(push);
                        HandleMessage(pushSender);
                        break;

                    default:
                        Console.WriteLine("not valid number");
                        break;

                }
            }
        }

        public static void HandleMessage( INotificationSender sender)
        {
           
            Console.WriteLine("Enter the message: ");
            string message = Console.ReadLine();
            sender.Send(message);
        }
    }
}
