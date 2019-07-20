namespace Rebar.API.Input
{
    /// <summary>
    /// An emulated mouse sends arbitrary click and movement data to the system.
    /// </summary>
    public interface IEmulatedMouse
    {
        /// <summary>
        /// Simulates a mouse press.
        /// </summary>
        /// <param name="button">Integer button ID to press.</param>
        void Click(int button);
        
        /// <summary>
        /// Moves the cursor to a given point on the desktop.
        /// </summary>
        /// <param name="x">X-coordinate to place the cursor at.</param>
        /// <param name="y">Y-coordinate to place the cursor at.</param>
        void MoveCursorTo(int x, int y);
    }
}