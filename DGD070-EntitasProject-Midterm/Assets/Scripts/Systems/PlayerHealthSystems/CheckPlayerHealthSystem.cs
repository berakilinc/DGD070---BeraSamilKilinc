using Entitas;
using UnityEngine;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    public Contexts _contexts;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        GameEntity[] entities = _contexts.game.GetEntities(GameMatcher.PlayerHealth);

        foreach (GameEntity entity in entities)
        {
            if (entity.isPlayerDamaged) 
            {
                float newHealthValue = Mathf.Max(entity.playerHealth.Value - 10f, 0f);

                entity.ReplacePlayerHealth(newHealthValue);
                
                entity.isPlayerDamaged = false;
            }
            if (entity.isPlayerHealed) 
            {
                float newHealthValue = Mathf.Min(entity.playerHealth.Value + 10f, 100f);
                entity.ReplacePlayerHealth(newHealthValue);
                entity.isPlayerHealed = false;
            }
        }
    }
}