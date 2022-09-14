using MVCDemo.Models;

namespace MVCDemo.Servics
{
    public class FriendService
    {
        static List<Friend> Friends { get; }
        static int nextId = 4;
        static FriendService()
        {
            Friends = new List<Friend>
                {
                    new Friend { id = 1, FriendName = "Rakshith", Place="Hassan" },
                    new Friend { id = 2, FriendName = "Jeevan Gowda", Place="KGF" },
                    new Friend {id = 3, FriendName = "Nachi", Place="Tumkur" }
                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(f => f.id == id);

        public static void Add(Friend friend)
        {
            friend.id = nextId++;
            Friends.Add(friend);
        }

        public static void Delete(int id)
        {
            var friend = Get(id);
            if (friend is null)
                return;

            Friends.Remove(friend);
        }

        public static void Update(Friend friend)
        {
            var index = Friends.FindIndex(f => f.id == friend.id);
            if (index == -1)
                return;

            Friends[index] = friend;
        }
            
    }
}

