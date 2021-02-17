using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace PS4MacroScripts
{
    class EndScreen : Scene
    {
        public override string Name => "Batting_TutorialScreen";

        public static RectMap EndSkiesMap = new RectMap()
        {
            X = 440,
            Y = 120,
            Width = 156,
            Height = 50,
            Hash = 35887507618889599
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(EndSkiesMap, 98);
        }

        public override void OnMatched(ScriptBase script)
        {
            var sleepTime = 1000;
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(sleepTime);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(sleepTime);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(sleepTime);
        }
    }
}
