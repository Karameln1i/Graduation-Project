using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAliveTransition : Transition
{
    private Enemy _enemy;

    private void OnEnable()
    {
        _enemy = GetComponent<Enemy>();
        _enemy.Die += OnEnemyDied;
    }

    private void OnDisable()
    {
        _enemy.Die -= OnEnemyDied;
    }

    private void OnEnemyDied()
    {
        NeedTransit = true;
    }
}
