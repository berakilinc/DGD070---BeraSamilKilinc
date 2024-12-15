using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour
{
    private Contexts _contexts;
    private PlayerHealthFeature _playerHealthFeature;

    private void Start()
    {
        Debug.Log("\n-Player Health System Accessibility : (Get Damage With 'D') - (Get Heal With 'H')");
        Debug.Log("Thanks For Playing.");
        _contexts = Contexts.sharedInstance;


        _playerHealthFeature = new PlayerHealthFeature(_contexts);
        _playerHealthFeature.Initialize();

    }

    private void Update()
    {
        _playerHealthFeature.Execute();
    }
}
