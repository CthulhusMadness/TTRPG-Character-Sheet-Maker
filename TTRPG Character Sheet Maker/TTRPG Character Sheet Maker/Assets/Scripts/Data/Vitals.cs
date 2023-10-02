namespace TTRPG.Data
{
    public class Vitals
    {
        public int current_hp;
        public int max_hp;

        public Vitals(int currentHp, int maxHp)
        {
            current_hp = currentHp;
            max_hp = maxHp;
        }
    }
}