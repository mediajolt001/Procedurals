using Microsoft.CSharp;
using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class ECSGraph : ComponentSystem
{
    private Unity.Entities.EntityQuery Quad_Query;
    private Unity.Entities.EntityQuery myQuery;
    protected override void OnCreate()
    {
        Quad_Query = GetEntityQuery(
            ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            ComponentType.ReadWrite<MoveDirection>(),
            ComponentType.ReadOnly<MoveSpeed>());
        myQuery = EntityManager.UniversalQuery;
    }

    protected override void OnUpdate()
    {
        {
            Entities.With(Quad_Query).ForEach((
                Unity.Entities.Entity Quad_QueryEntity,
                ref Unity.Transforms.Translation Quad_QueryTranslation,
                ref MoveDirection Quad_QueryMoveDirection,
                ref MoveSpeed Quad_QueryMoveSpeed) =>
            {
                Quad_QueryTranslation.Value.x += math.mul(
                    Time.deltaTime,
                    (Quad_QueryMoveDirection.Value * Quad_QueryMoveSpeed.Value));
                Quad_QueryTranslation.Value.y += 0F;
                Quad_QueryTranslation.Value.z += 0F;
                if ((Quad_QueryTranslation.Value.x > 9F))
                {
                    Quad_QueryMoveDirection.Value = -1F;
                }
                else
                {
                    if ((Quad_QueryTranslation.Value.x < -9F))
                    {
                        Quad_QueryMoveDirection.Value = 1F;
                    }
                }
            }

            );
        }
    }
}