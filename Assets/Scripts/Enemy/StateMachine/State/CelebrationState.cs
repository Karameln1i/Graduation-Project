using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelebrationState : State
{
    private Animator _animator;

    private void OnEnable()
    {
        _animator.Play(EnemyAnomationController.States.Hurt);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
