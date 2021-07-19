using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DieState : State
{
   [SerializeField] private Animator _animator;

   private void OnEnable()
    {
        _animator.Play(EnemyAnomationController.States.Duing);
    }
   
    private void OnDisable()
    {
        _animator.StopPlayback();
    }

    public void Destroy()
   {
       Destroy(gameObject);
   }
}
