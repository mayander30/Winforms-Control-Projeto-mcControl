using System;

namespace mcdev_controls.c_Headers
{
    public class ExpandCollapseEventArgs : EventArgs
    {
        public bool IsExpanded { get; private set; }

        public ExpandCollapseEventArgs(bool isExpanded)
        {
            IsExpanded = isExpanded;
        }
    }
}
