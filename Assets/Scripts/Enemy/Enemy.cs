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
    private bool _isAlive = true;

    public int Reward => _reward;
    public bool IsAlive => _isAlive;
    
   public Transform Path => _path;
   
   public Player Target => _target;
   
    public event UnityAction Die;
    public event UnityAction<Enemy> Dying;
    
    public void TakeDamage(int damage)
    {
        _health -= damage;
        _audioSource.Play();
            
        if (_health<=0)
        {
            Dying?.Invoke(this);
            Die?.Invoke();
            _isAlive = false;
        }
    }

    public void Init(Transform path,Player target)
    {
        _path = path;
        _target = target;
    }
}
