using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace PS4MacroScripts
{
    class StartScreen : Scene
    {
        public override string Name => "Hostess_TitleScreen";

        private static RectMap selectMissionMap = new RectMap()
        {
            X = 120,
            Y = 184,
            Width = 89,
            Height = 14,
            Hash = 13741739442038
        };

        private static RectMap MenuMap = new RectMap()
        {
            X = 103,
            Y = 132,
            Width = 125,
            Height = 26,
            Hash = 543304941312
        };

        private static RectMap N1StatusMap = new RectMap()
        {
            X = 646,
            Y = 318,
            Width = 17,
            Height = 17,
            Hash = 35887421719012223
        };

        private static RectMap N2StatusMap = new RectMap()
        {
            X = 768,
            Y = 318,
            Width = 17,
            Height = 17,
            Hash = 35887421719012223
        };

        private static RectMap N3StatusMap = new RectMap()
        {
            X = 889,
            Y = 318,
            Width = 17,
            Height = 17,
            Hash = 35887421719012223
        };

        private static RectMap N4StatusMap = new RectMap()
        {
            X = 646,
            Y = 447,
            Width = 17,
            Height = 17,
            Hash = 35887421719012223
        };

        private static RectMap N5StatusMap = new RectMap()
        {
            X = 768,
            Y = 318,
            Width = 17,
            Height = 17,
            Hash = 35887421719012223
        };

        private static RectMap N6StatusMap = new RectMap()
        {
            X = 889,
            Y = 318,
            Width = 17,
            Height = 17,
            Hash = 35887421719012223
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(MenuMap, 98);
        }

        public override void OnMatched(ScriptBase script)
        {
            var waitTime = 500;

            // Checking if hosts need a break

            if (script.MatchTemplate(N1StatusMap, 98) || script.MatchTemplate(N2StatusMap, 98) ||
                script.MatchTemplate(N3StatusMap, 98) || script.MatchTemplate(N4StatusMap, 98) ||
                script.MatchTemplate(N5StatusMap, 98) || script.MatchTemplate(N6StatusMap, 98))
            {
                if (script.MatchTemplate(selectMissionMap, 98))
                    MultiplePresses.Press("DPad_Down", 1, waitTime, script);
                MultiplePresses.Press("Cross", 2, waitTime, script); // Entered Assign Floor Crew
            }
            else
            {
                if (!script.MatchTemplate(selectMissionMap, 98))
                {
                    MultiplePresses.Press("DPad_Up", 1, waitTime, script);
                    MultiplePresses.Press("Cross", 1, waitTime, script);
                    MultiplePresses.Press("DPad_Up", 1, waitTime, script);
                    MultiplePresses.Press("Cross", 2, waitTime, script);
                }
            }
        }
    }
}
