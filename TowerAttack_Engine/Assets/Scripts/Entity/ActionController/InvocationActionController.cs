using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvocationActionController : ActionController
{
    public InvocationActionData actionData;
    public EntityManager entity;

    public Transform[] spawnPoints;

    public override ActionData GetData()
    {
        return actionData;
    }
    protected override void DoAction()
    {
        Vector3 entityPos = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        //EntityManager.CreateEntity(entityPos, );
    }
}
