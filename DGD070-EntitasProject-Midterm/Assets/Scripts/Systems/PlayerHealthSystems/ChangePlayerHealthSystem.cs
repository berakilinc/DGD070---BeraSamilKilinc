using Entitas;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    private Contexts _contexts;

    private bool _dPressed;
    private bool _hPressed;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        _dPressed = Input.GetKeyDown(KeyCode.D);
        _hPressed = Input.GetKeyDown(KeyCode.H);

        GameEntity[] entities = _contexts.game.GetEntities(GameMatcher.PlayerHealth);

        foreach (GameEntity entity in entities) 
        {
          if (_dPressed == true)
            {
                entity.isPlayerDamaged = true;
                Debug.Log("'D' Pressed, Damage Activated. Player Took 10 Damage! Player Old Health Was: " + entity.playerHealth.Value);
            }

          if (_hPressed == true)
            {
                entity.isPlayerHealed = true;
                Debug.Log("'H' Pressed, Heal Activated. Player Took 10 Health! Player Old Health Was: " + entity.playerHealth.Value);
            }
        }

        
    }
}
