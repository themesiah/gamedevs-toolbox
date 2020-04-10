using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamedevsToolbox.StateMachine;
using GamedevsToolbox.UISolution;

namespace GamedevsToolbox.Examples
{
    public class CoroutineStateMachineController : MonoBehaviour
    {
        private MenuStateMachineExample stateMachine = default;

        [SerializeField]
        private UIMenuData[] menuData = default;
        
        void Start()
        {
            stateMachine = new MenuStateMachineExample();
            Dictionary<string, ICoroutineState> states = new Dictionary<string, ICoroutineState>();
            foreach(UIMenuData data in menuData)
            {
                states.Add(data.menuName, new UIState(data));
            }
            stateMachine.SetStates(states);
            StartCoroutine(StateMachineCoroutine());
        }

        public void ReceiveSignal(string signal)
        {
            stateMachine.ReceiveSignal(signal);
        }

        IEnumerator StateMachineCoroutine()
        {
            while (true)
            {
                yield return stateMachine.Update(null);
            }
        }
    }
}