namespace ConsoleApp31
{
    abstract class CreatureAction
    {
        public string Title { get; set; }
        abstract class Run
        {
            public Creature creature {  get; set; }
            public Room room { get; set; }

        }
    }

}
