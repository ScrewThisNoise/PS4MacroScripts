using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace PS4MacroScripts
{
    class MissionResults : Scene
    {
        public override string Name => "Hostess_MissionResults";

        private static RectMap missionResultsMap = new RectMap()
        {
            X = 221,
            Y = 155,
            Width = 163,
            Height = 57,
            Hash = 106100716175152
        };

        private static RectMap checkstatusMap = new RectMap()
        {
            X = 251,
            Y = 136,
            Width = 108,
            Height = 25,
            Hash = 35886403812262976
        };

        public override bool Match(ScriptBase script)
        {
            Logger.Writer("In the endscreen, moving on...");
            return script.MatchTemplate(missionResultsMap) || script.MatchTemplate(checkstatusMap);
        }

        public override void OnMatched(ScriptBase script)
        {
            var waitTime = 10;

            // Just pressing X till it goes away
            MultiplePresses.Press("Cross", 1, waitTime, script);
        }
    }
}
