using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class DieState : State
{
   [SerializeField] private Animator _animator;

 [SerializeField]  private SpriteRenderer _spriteRenderer;
   
   private void OnEnable()
    {
        _animator.Play(EnemyAnomationController.States.Duing);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
   
    private void OnDisable()
    {
        _animator.StopPlayback();
    }

    public IEnumerator Disappearance()
    {
       var color = _spriteRenderer.color;
       
        while (_spriteRenderer.color.a!=0)
        {
            color.a -= 0.003f;
            _spriteRenderer.color = color;
            
            if (_spriteRenderer.color.a<=0)
            {
                Destroy(gameObject);
            }
            
            yield return null;
        }
    }
}
