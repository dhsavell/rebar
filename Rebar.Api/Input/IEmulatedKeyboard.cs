namespace Rebar.API.Input
{
    public interface IEmulatedKeyboard
    {
        void Press(int key, params int[] modifiers);
    }
}
