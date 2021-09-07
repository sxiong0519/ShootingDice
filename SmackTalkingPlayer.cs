using System; 

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public static void TauntingLose(Player player)
        {
            Console.WriteLine($"Okay... What of it? I got you next round....");
        }

        
        public static void TauntingWin(Player player)
        {
            Console.WriteLine($"OH YEAH! WHAT NOW, LOSER!");
        }
    }
}