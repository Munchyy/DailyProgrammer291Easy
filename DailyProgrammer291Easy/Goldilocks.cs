using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DailyProgrammer291Easy
{
    class Goldilocks
    {
        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
        }
        private int maxTemp;
        public int MaxTemp
        {
            get
            {
                return maxTemp;
            }
        }
        private List<string[]> goldilocksData;
        public Goldilocks(string inputStr)
        {
            goldilocksData = SplitInputString(inputStr);
            bool success = int.TryParse(goldilocksData[0][0],out weight);
            success = int.TryParse(goldilocksData[0][1],out maxTemp);

        }

        public List<int> FindDinnerPlaces()
        {
            List<int> validTablePlaces = new List<int>();
            foreach(string[] place in goldilocksData)
            {
                if(int.Parse(place[0]) > weight && int.Parse(place[1]) < maxTemp)
                {
                    validTablePlaces.Add(goldilocksData.IndexOf(place));
                }
            }

            return validTablePlaces;
        }

        private List<string[]> SplitInputString(string inputString)
        {
            List<string> splitInput = new List<string>();
            List<string[]> splitInput2 = new List<string[]>();
            splitInput.AddRange(Regex.Split(inputString, @"\r\n|\r|\n"));
            
            foreach(string s in splitInput)
            {
                splitInput2.Add(Regex.Split(s, @"\s+"));
            }

            return splitInput2;
        }

    }
}
