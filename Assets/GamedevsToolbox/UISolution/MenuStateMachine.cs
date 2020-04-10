using GamedevsToolbox.StateMachine;

namespace GamedevsToolbox.UISolution
{
    public class MenuStateMachine : CoroutineStateMachine
    {
        public override void ReceiveSignal(string signal)
        {
            currentState.ReceiveSignal(signal);
        }
    }
}