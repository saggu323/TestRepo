using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal static class Tournament
    {
        enum teams
        {
            celtics,
            raptors,
            nets,
            knicks,
            Seventy6ers,
            Heat,
            Hawks,
            Hornets,
            Magic,
            Wizards,
            Cavaliers,
            bucks,
            pistons,
            bulls,
            spurs,
            pacers
        }

        public static void GenerateTournament()
        {
            int teamCount = Enum.GetNames(typeof(teams)).Length;
            if (teamCount % 2 == 0)
            {
                //even teams. Keep first static.
                int staticTeam = 0;

                int[] teams = new int[teamCount];


                teams[0] = staticTeam;
                for (int i = 0; i < teamCount - 1; i++)
                {
                    for (int j = 1; j < teamCount; j++)
                    {
                        //teams[j] = (j + i) >=teamCount? (j+i)%(teamCount-1) : (j+i);
                        if ((j + i) >= teamCount) { teams[(j + i) % (teamCount - 1)] = j; }
                        else { teams[j + i] = j; }
                    }

                    Console.WriteLine("===============================");
                    Console.WriteLine("WEEK : " + (i + 1));
                    Console.WriteLine("===============================");
                    for (int k = 0; k < teamCount / 2; k++)
                    {
                        Console.WriteLine((teams)teams[k] + "  VS  " + (teams)teams[k + teamCount / 2]);
                    }
                }
                Console.WriteLine("===============================");
            }
        }
    }
}
