using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField] private List<Transition> _transitions;

    protected Player Target { get; set; }

    public void Enter(Player target)
    {
        if (enabled == false)
        {
            Target = target;
            enabled = true;
            foreach (var transiton in _transitions)
            {
                transiton.enabled = true;
                transiton.Init(Target);
            }
        }
    }

    public void Exit()
    {
        if(enabled == true)
        {
            foreach (var transiton in _transitions)
                transiton.enabled = false;

            enabled = false;
        }
    }

    public State GetNextState()
    {
        foreach (var transiton in _transitions)
        {
            if (transiton.NeedTransit)
                return transiton.TargetState;
        }

        return null;
    }
}
