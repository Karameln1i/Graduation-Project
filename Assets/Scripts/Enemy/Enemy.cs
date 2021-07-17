using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _reward;
    [SerializeField] private AudioSource _audioSource;
    
    private Player _target;
    private Transform _path;

    public int Reward => _reward;
    
   public Transform Path => _path;
   
   public Player Target => _target;
    
    public event UnityAction<Enemy> Dying;

    private void Die()
    {
        Dying?.Invoke(this);
        Destroy(gameObject);
    }
    
    public void TakeDamage(int damage)
    {
        _health -= damage;
        _audioSource.Play();
            
        if (_health<=0)
        {
            Die();
        }
    }

    public void SetPath(Transform path)
    {
        _path = path;
    }

    public void SetTarget(Player target)
    {
        _target = target;
    }
}
