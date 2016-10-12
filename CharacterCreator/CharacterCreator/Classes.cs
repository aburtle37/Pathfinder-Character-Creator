namespace CharacterCreator
{
    internal class Classes
    {

        public string className;
        public string classDes;
        public int hitDie;
        public int wealthDice;
        public int wealthDiceNum;
        public int wealthMul;

        public Classes(string inputClassName, string inputClassDes, int inputHitDie, int inputWealthDice, int inputWealthDiceNum, int inputWealthMul)
        {

            className = inputClassName;
            classDes = inputClassDes;
            hitDie = inputHitDie;
            wealthDice = inputWealthDice;
            wealthDiceNum = inputWealthDiceNum;
            wealthMul = inputWealthMul;

        }
    }
}