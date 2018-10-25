using System;
using PubSubPattern.Logic.Interfaces;

namespace PubSubPattern.Logic
{
    public class SportGameCompletedEventArgs : EventArgs
    {
        public IMatch Match { get; set; }
    }
}
