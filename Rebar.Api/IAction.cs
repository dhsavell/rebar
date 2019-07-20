namespace Rebar.API.Action
{
    /// <summary>
    /// An action is a named data structure that represents an action (i.e. key press, mouse click) invokable by a user.
    /// </summary>
    /// <typeparam name="T">
    /// Data type modeling the method and circumstances of activation. Not all actions are created equal: some may be
    /// buttons that only care if they've been pressed, while others may be dials that depend on the turn amount and
    /// direction.
    /// </typeparam>
    public interface IAction<in T>
    {
        /// <summary>
        /// The user-friendly name of this action.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Invokes this action.
        /// </summary>
        /// <param name="ctx">Context describing how the action was invoked.</param>
        void Invoke(T ctx);
    }
}
