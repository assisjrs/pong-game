using System;

namespace Assisjrs.Ponggame
{
    public class ScoreEventArgs : EventArgs
    {
        public bool IsPlayer { get; set; }
        public int Value { get; set; }
    }
}
