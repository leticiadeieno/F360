using System.Linq;
using Klingon.Domain.Core.Contracts;

namespace Klingon.Domain.Core.Services
{
    public class KlingonService : IKlingonService
    {
        private char[] lettersTypeFoo = { 's', 'l', 'f', 'w', 'k' };

        public bool CheckIfIsFooOrBar(char character)
        {
            bool characterIsFoo = lettersTypeFoo.Any(x => x == character);

            if (characterIsFoo)
                return true;
            else
                return false;
        }

        public bool CheckIfIsPreposition(char lastCharacter)
        {
            bool isPreposition = false;
            
            if (!CheckIfIsFooOrBar(lastCharacter))
                isPreposition = true;

            return isPreposition;
        }

        public int CountPrepositions(string[] list)
        {
            int countKlingonPreposition = 0;

            foreach (var word in list)
            {
                if (word.Length == 3 && (!word.Contains("d")))
                {
                    var lastCharacter = word.Last();
                    bool isPreposition = CheckIfIsPreposition(lastCharacter);

                    if (isPreposition)
                        countKlingonPreposition++;
                }
            }

            return countKlingonPreposition;
        }

        public int CountVerbs(string[] list)
        {
            int countKlingonVerb = 0;

            foreach (var word in list)
            {
                if (word.Length >= 8 && CheckIfIsFooOrBar(word.Last()))
                    countKlingonVerb++;
            }

            return countKlingonVerb;
        }

        public int CountVerbsInFirstPerson(string[] list)
        {
            int countKlingonVerbInFirstPerson = 0;

            foreach (var word in list)
            {
                if (word.Length >= 8 && CheckIfIsFooOrBar(word.Last()) && !CheckIfIsFooOrBar(word.First()))
                    countKlingonVerbInFirstPerson++;
            }

            return countKlingonVerbInFirstPerson;
        }
    }
}
