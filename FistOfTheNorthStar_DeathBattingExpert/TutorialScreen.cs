using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace PS4MacroScripts
{
    class TutorialScreen : Scene
    {
        public override string Name => "Batting_TutorialScreen";

        public static RectMap TutorialMap = new RectMap()
        {
            X = 0,
            Y = 0,
            Width = 1008,
            Height = 729,
            Hash = 33256997075968
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(TutorialMap, 98);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
        }
    }
}
