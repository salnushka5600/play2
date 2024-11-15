namespace ConsoleApp31
{
    abstract class Creature
        {
            public CreatureClass Stats { get; set; }
            public bool IsDead { get; set; }
            public void TakeDamage(int damage)
            {
                Stats.CurrentHP -= damage;
                Console.WriteLine($"{Stats.Name} получил урон, текущее HP {Stats.CurrentHP}");
                if (Stats.CurrentHP < 0) Death();

            }
            private void Death()
            {
                Console.WriteLine($"{Stats.Name} погиб");
                IsDead = true;
            }
        }
            
    }
