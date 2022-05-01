using System;

namespace OpenClosed
{
    /// <summary>
    /// Has general properties of all control web
    /// </summary>
    public class ControlBase
    {
        /// <summary>
        /// Unique identifier of control web
        /// </summary>
        protected string _id = Guid.NewGuid().ToString();
    }
}
