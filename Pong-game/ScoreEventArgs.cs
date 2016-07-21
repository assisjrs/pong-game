using System;

namespace Assisjrs.Ponggame
{
    public class ScoreEventArgs : EventArgs
    {
        public bool IsPlayerA { get; set; }
        public int Value { get; set; }
    }
}
