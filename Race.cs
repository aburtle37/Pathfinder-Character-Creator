namespace ChartacterCreator
{
    internal class Race
    {
        public string raceName;
        public string raceDes;
        public int baseHeightMale;
        public int baseHeightFemale;
        public int baseWeightMale;
        public int baseWeightFemale;
        public int heightMaleDice;
        public int heightMaleDiceNum;
        public int heightMaleMul;
        public int heightFemaleDice;
        public int heightFemaleDiceNum;
        public int heightFemaleMul;
        public int weightMaleDice;
        public int weightMaleDiceNum;
        public int weightMaleMul;
        public int weightFemaleDice;
        public int weightFemaleDiceNum;
        public int weightFemaleMul;
        public int strMod;
        public int dexMod;
        public int conMod;
        public int intMod;
        public int wisMod;
        public int chaMod;

        public Race(string inputRaceName, string inputRaceDes, int inputBaseHeightMale, int inputBaseHeightFemale, int inputBaseWeightMale, int inputBaseWeightFemale, int inputHeightMaleDice, int inputHeightMaleDiceNum, int inputHeightMaleMul, int inputHeightFemaleDice, int inputHeightFemaleDiceNum, int inputHeightFemaleMul, int inputWeightMaleDice, int inputWeightMaleDiceNum, int inputWeightMaleMul, int inputWeightFemaleDice, int inputWeightFemaleDiceNum, int inputWeightFemaleMul, int inputStrMod, int inputDexMod, int inputConMod, int inputIntMod, int inputWisMod, int inputChaMod)
        {
            raceName = inputRaceName;
            raceDes = inputRaceDes;
            baseHeightMale = inputBaseHeightMale;
            baseHeightFemale = inputBaseHeightFemale;
            baseWeightMale = inputBaseWeightMale;
            baseWeightFemale = inputBaseWeightFemale;
            heightMaleDice = inputHeightMaleDice;
            heightMaleDiceNum = inputHeightMaleDiceNum;
            heightMaleMul = inputHeightMaleMul;
            heightFemaleDice = inputHeightFemaleDice;
            heightFemaleDiceNum = inputHeightFemaleDiceNum;
            heightFemaleMul = inputHeightFemaleMul;
            weightMaleDice = inputWeightMaleDice;
            weightMaleDiceNum = inputWeightMaleDiceNum;
            weightMaleMul = inputWeightMaleMul;
            weightFemaleDice = inputWeightFemaleDice;
            weightFemaleDiceNum = inputWeightFemaleDiceNum;
            weightFemaleMul = inputWeightFemaleMul;
            strMod = inputStrMod;
            dexMod = inputDexMod;
            conMod = inputConMod;
            intMod = inputIntMod;
            wisMod = inputWisMod;
            chaMod = inputChaMod;
        }

    }

}