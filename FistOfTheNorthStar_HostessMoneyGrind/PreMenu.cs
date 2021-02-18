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
            X = 279,
            Y = 227,
            Width = 62,
            Height = 46,
            Hash = 8354123282302074237
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(PreMenuMap) || script.MatchTemplate(PreMenu2Map);
        }

        public override void OnMatched(ScriptBase script)
        {
            var waitTime = 10;

            Logger.Writer("In the PreMenu, moving on...");
            // Just pressing X till it goes away
            MultiplePresses.Press("Cross", 1, waitTime, script);
        }
    }
}