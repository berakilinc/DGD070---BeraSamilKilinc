using UnityEngine;
using Entitas;

public class PlayerHealthFeature : Feature
{
    public PlayerHealthFeature(Contexts contexts) 
    {
        Add(new CreatePlayerHealthSystem(contexts));
        Add(new CheckPlayerHealthSystem(contexts));
        Add(new ChangePlayerHealthSystem(contexts));
    }
}
