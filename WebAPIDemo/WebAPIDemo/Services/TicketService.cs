using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public class TicketService
    {
        static List<Ticket>Tickets { get; set; }
         
        static TicketService()
        {
            Tickets = new List<Ticket>
            {
                new Ticket{ ID=1,BookedBy="Bharath", BookedFor="Trip", Qty=5, Price=4000 }
                
            };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x => x.ID == id);
            return ticket;
        }
    }
}
