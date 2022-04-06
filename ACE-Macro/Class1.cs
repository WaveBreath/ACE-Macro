using System;
using System.Collections.Generic;
using PS4MacroAPI;

namespace ACE_Macro
{
    public class Script:ScriptBase
    {
        public Script()
        {
            Config.Name = "Ace Combat 7 ";

        }
        public override void Start()
        {
            base.Start();
        }
        public override void Update()
        {
            base.Update();
            Press(new DualShockState() {Cross=true });
            Sleep(3*1000);
            flyHigh();
            loop();
            retry();
        }
        void retry()
        {
            int waitDeley = 10;
            Press(new DualShockState() { Options = true });
            Sleep(waitDeley);
            Press(new DualShockState() { DPad_Down = true });
            Sleep(waitDeley);
            Press(new DualShockState() { Cross = true });
            Sleep(waitDeley);
            Press(new DualShockState() { DPad_Up = true });
            Sleep(waitDeley);
        }
        void flyHigh()
        {
            PlayMacro("preprocess.xml");
        }
        void loop()
        {
            Press(new DualShockState() { R1=true, R2 = 0xff },29*60*1000);
        }
    }
}
