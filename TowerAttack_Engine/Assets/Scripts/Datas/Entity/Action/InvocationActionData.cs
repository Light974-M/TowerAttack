using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Invocation", menuName = "TowerAttack/Action/New Invocation")]

public class InvocationActionData : ActionData
{
    [SerializeField]
    private int _timeBeforeNextInstantiate;
    public EntityData entityCreated;
    private int _numberOfEntityCreated;

}
