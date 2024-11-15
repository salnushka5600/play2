namespace ConsoleApp31
{
    class Room
        {
            public Creature Player { get; set; }
            public List<Creature> Enemies { get; set; }
            public Room (Creature player)
            {
                Player = player;
                Enemies = new List<Creature>();

            }
            public void RunBattle()
            {

            }
        }
            
    }
