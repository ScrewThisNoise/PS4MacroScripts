using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS4MacroScripts
{
    public class Script : ScriptBase
    {
        public Script()
        {
            Config.Name = "Fist of the North Star: Paradise Lost (DeathBatting Expert)";
            Config.Scenes = new List<Scene>()
            {
                new TutorialScreen(),
            };
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
            var logFile = "DeathBattingExpert.log";
            HandleScenes(scene =>
            {
                Console.WriteLine(scene.Name);
            });

        }
    }
}
