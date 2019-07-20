using WindowsInput;
using Rebar.API.Input;

namespace Rebar.Impl.Windows
{
    /// <summary>
    /// A Win32EmulatedMouse sends mouse events through an IMouseSimulator, which uses the Win32 SendInput method.
    /// </summary>
    public class Win32EmulatedMouse : IEmulatedMouse
    {
        private readonly IMouseSimulator _mouseSimulator;

        private Win32EmulatedMouse(IMouseSimulator mouseSimulator)
        {
            _mouseSimulator = mouseSimulator;
        }

        public void Click(int button)
        {
            _mouseSimulator.XButtonClick(button);
        }

        public void MoveCursorTo(int x, int y)
        {
            _mouseSimulator.MoveMouseTo(x, y);
        }
        
        public static Win32EmulatedMouse New()
        {
            return new Win32EmulatedMouse(new InputSimulator().Mouse);
        }

        public static Win32EmulatedMouse FromMouseSimulator(IMouseSimulator simulator)
        {
            return new Win32EmulatedMouse(simulator);
        } 
    }
}