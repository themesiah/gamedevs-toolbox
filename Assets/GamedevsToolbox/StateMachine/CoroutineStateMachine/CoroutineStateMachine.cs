using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamedevsToolbox.StateMachine {
    public class CoroutineStateMachine : ICoroutineState
    {
        protected ICoroutineState currentState = null;
        protected Dictionary<string, ICoroutineState> states;
        
        public void SetStates(Dictionary<string, ICoroutineState> states)
        {
            this.states = states;
        }

        public virtual IEnumerator EnterState()
        {
            yield return null;
        }

        public virtual IEnumerator ExitState()
        {
            yield return null;
        }

        public virtual void ReceiveSignal(string signal) {}

        public virtual IEnumerator Update(Action<string> resolve)
        {
            if (currentState == null)
            {
                currentState = states.Values.First();
                yield return currentState.EnterState();
            }

            string newState = null;
            yield return currentState?.Update(t => newState = t);

            if (newState != null)
            {
                if (states.ContainsKey(newState))
                {
                    yield return currentState.ExitState();
                    currentState = states[newState];
                    yield return currentState.EnterState();
                }
                else
                {
                    Debug.LogError("Your state machine of type " + this.GetType().Name + " is trying to switch to the state " + newState + " which is not in the State Machine dictionary");
                    yield return null;
                }
            }
            else
            {
                yield return null;
            }
        }
    }
}