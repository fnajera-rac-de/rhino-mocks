namespace Rhino.Mocks
{
    /// <summary>
    /// Defines the behavior of unexpected calls.
    /// </summary>
    public enum UnexpectedCallBehaviors
    {
        /// <summary>
        /// Always throw
        /// </summary>
        Throw,
        /// <summary>
        /// If there is a callable base method, invoke it.
        /// Otherwise, throw.
        /// </summary>
        BaseOrThrow,
        /// <summary>
        /// If there is a callable base method, invoke it.
        /// Otherwise, get/set a ficticious property or return the default value of the expected type, if any.
        /// </summary>
        BaseOrDefault,
    }
}