using System;
using LifeSimilator.Models.ReusableMethods;

namespace LifeSimilator.Events.Generic
{
    public static class SocialEvents
    {
        public static void AdoptPet(Character character)
        {
            int petCost = 30;
            if (character.Money >= petCost)
            {
                character.Money -= petCost;
                character.Health += 20;
                Console.WriteLine($" You adopted a pet! -${petCost}, +20 Health.");
            }
            else
                Console.WriteLine(" You wanted a pet but couldn't afford it.");
        }


        public static void FoundNewFriend(Character character)
        {
            character.Health += 10;
            Console.WriteLine(" You met a new friend! They helped you improve your health. +10 Health.");
        }

        public static void  DateGirl(Character character)
        {
            var Godate = " You met someone special! Go on a date? (y/n)";
            if (Response.GetYesNoResponse(Godate) && character.Money >= 15)
            {
                character.Health += 15;
                character.Money -= 15;
                Console.WriteLine(" The date was amazing! +15 Health, -$15.");
            }
            else
            {
                Console.WriteLine(" You missed the opportunity for love.");
            }
        }
    }
}
