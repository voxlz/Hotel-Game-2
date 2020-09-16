namespace HotelGame
{
    public static class Dialog
    {
        // Actions
        public static readonly string[] buildRoom = {
            "Auch! Building a new room was more expensive than you thought it would be.",
            "Room construction done. What a relief!",
            "Those room builders sure took their time! Should ask for compensation?"
        };
        public static readonly string[] buildRoomTut = {
            "You now have a proper room for your first guest! This is going well! Now you just have to wait for your first guest to arrive..."
        };
        public static readonly string[] guestLeft = {
            "Thanks for your visit!",
            "It was a pleasure having you here at " + Hotel.name + ".",
            "Please, come again!",
            "Untill next time!",
            "I hope you had a plesant stay."
        };
        public static readonly string[] guestLeftTut = {
            "'My first income!' you think while you recive money from the leaving guest. They look at you guiltily before telling you the toilet is clogged." +
            " 'Right. I should clean that before my next guest arrives'."
        };
        public static readonly string[] guestArrived = {
            "A new guest just arrived. Welcome!",
            "Welcome to " + Hotel.name + ", please enjoy your stay!",
            "Yes? How may I help you?"
        };
        public static readonly string[] guestArrivedTut = {
           "Oh, there's your first guest! It seems like they will simply show up during daytime if you have free rooms. Now, let's wait untill they leaves."
        };
        public static readonly string[] cleanRoom = {
           "The room is now clean.",
           "I should hire someone to clean for me. This is tedious.",
           "Another room cleaned. Phew.",
        };
        public static readonly string[] cleanRoomTut = {
            "You just gained a new found hate for toilets. Anyways, it feels like you're starting to get the grip of this hotel buisness. Let's make it awesome."
        };
        public static readonly string[] doNothing = {
           "Nothing happened. What did you expect?",
           "That was a refreshing nap. Wait, I have guests to attend to!",
           "That feelt just as one would suspect. Boring and meaningless.",
           "I promise. This button does nothing.",
           "It's pretty sad that you just wasted a few seconds of your life.",
           "Don't you have anything better to do?",
           "I bet your mom would be proud.",
           "Hey, it's time to stop clicking.",
           "What was I doing again?",
           "Error! Exception: String not found. Nah, just kidding. ;)",
           "You start thinking about the meaning of life. I would be best if you stop.",
           "What if the whole world is just a videogame, and you are the protaganist?",
           "AhsdgGSldpleaDheasdhkevpcaSHdjeaope",
           "Please stop.",
           "Pressing just to see how many different prompts there are, aren't we?",
           "That was fun! But now I have to get back to playing Animal Crossing: New Leaf on my Nintendo DS"
        };

        // Status updates
        public static readonly string nightBegins = "The sun dissapears beyond the horizon as nightime falls.";
        public static readonly string dayBegins = "The sun rises and yet another day begins!";
        public static readonly string gameStarts = "As you close the door behind you, happiness spreads throughout your body. You can finally start building your own hotel, just like you always dreamed! Better get moving!";

        // Help
        public static readonly string noRooms = "Hum. Without any rooms you won't get any guests... Time to start buildning one!";
        public static readonly string allDirty = "What's that smell? I think all the rooms are dirty! No one will come and stay here if we don't start cleaning!";

    }
}
