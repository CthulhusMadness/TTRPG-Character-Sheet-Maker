namespace TTRPG.Data
{
    public class VitalsDnD : Vitals
    {
        public int temporary_hp;
        public string hit_dice;

        public VitalsDnD(int currentHp, int maxHp, int tempHp = 0, string hitDice = "") : base(currentHp, maxHp)
        {
            temporary_hp = tempHp;
            hit_dice = hitDice;
        }
    }
}