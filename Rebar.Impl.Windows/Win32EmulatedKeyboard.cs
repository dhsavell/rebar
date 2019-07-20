using System.Linq;
using WindowsInput;
using WindowsInput.Native;
using Rebar.API.Input;

namespace Rebar.Impl.Windows
{
    /// <summary>
    /// A Win32EmulatedKeyboard sends keystrokes through a wrapped IKeyboardSimulator, which uses the Win32 SendInput
    /// method.
    /// </summary>
    public class Win32EmulatedKeyboard : IEmulatedKeyboard
    {
        private readonly IKeyboardSimulator _keyboardSimulator;

        private Win32EmulatedKeyboard(IKeyboardSimulator keyboardSimulator)
        {
            _keyboardSimulator = keyboardSimulator;
        }

        public void Press(int key, params int[] modifiers)
        {
            _keyboardSimulator.ModifiedKeyStroke(modifiers.Cast<VirtualKeyCode>(), (VirtualKeyCode) key);
        }
        
        public static Win32EmulatedKeyboard New()
        {
            return new Win32EmulatedKeyboard(new InputSimulator().Keyboard);
        }

        public static Win32EmulatedKeyboard FromMouseSimulator(IKeyboardSimulator simulator)
        {
            return new Win32EmulatedKeyboard(simulator);
        } 
    }
}