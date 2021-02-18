using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace PS4MacroScripts
{
    class PreMenu : Scene
    {
        public override string Name => "Hostess_PreMenu";

        private static RectMap PreMenuMap = new RectMap()
        {
            X = 597,
            Y = 560,
            Width = 100,
            Height = 82,
            Hash = 4431400743932294196
        };

        private static RectMap PreMenu2Map = new RectMap()
        {
            X = 840,
            Y = 596,
            Width = 12,
            Height = 12,
            Hash = 13935049962468303809
        };

        private static RectMap PreMenu3Map = new RectMap()
        {
            X = 397,
            Y = 303,
            Width = 207,
            Height = 24,
            Hash = 75314390597380
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(PreMenuMap) || script.MatchTemplate(PreMenu2Map) || script.MatchTemplate(PreMenu3Map);
        }

        public override void OnMatched(ScriptBase script)
        {
            var waitTime = 10;

            if(Logger.LastSceneName != Name)
                Logger.Writer("In the PreMenu, moving on...");
            Logger.LastScene(Name);

            // Just pressing X till it goes away
            MultiplePresses.Press("Cross", 1, waitTime, script);
        }
    }
}