using System;
using Entitas;
using UnityEngine;

public class CreatePlayerHealthSystem : IInitializeSystem
{
    private Contexts _contexts;

    public CreatePlayerHealthSystem(Contexts contexts) 
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        GameEntity playerEntity = _contexts.game.CreateEntity();
        playerEntity.AddPlayerHealth(100f);
    }
}