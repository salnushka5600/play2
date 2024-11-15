namespace ConsoleApp31
{
    abstract class CreatureClass
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Armor { get; set; }
            public int CurrentHP { get; set; }
            public int MaxHP { get; set; }
            public int Speed { get; set; }
            public CreatureClass(string name, int damage, int armor, int currenthp, int maxhp, int speed)
            {
                Name = name;
                Damage = damage;
                Armor = armor;
                CurrentHP = currenthp;
                MaxHP = maxhp;
                Speed = speed;
            }
        public List<Creature> Actions { get; set; }
        public void PrintActions()
        {
            for (int i = 0; i < Actions.Count; i++)
            {
                Console.WriteLine($"{i +  1} {Actions[i].Title}");
            }
        }

    }
            
    }
