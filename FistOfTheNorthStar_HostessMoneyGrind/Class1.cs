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
            Config.Name = "Fist of the North Star - Paradise Lost (Hostess Minigame Money Grinding)";
            Logger.Initiate(Config.Name);
            Logger.Writer($"Log for {Config.Name} is running.");
            Config.Scenes = new List<Scene>()
            {
                new WorkScene(),
                new StartScreen(),
                new ChooseCast()
            };
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
            HandleScenes(scene =>
            {
                Console.WriteLine(scene.Name);
            });

        }
    }
}
