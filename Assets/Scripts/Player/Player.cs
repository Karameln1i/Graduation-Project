using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private int _health;
    [SerializeField] private int _startMoney;
    
    private int _money;

    public int Money => _money;
    
    public event UnityAction<int> HealthChanged;
    public event UnityAction<int> MoneyChanged;

    private void Start()
    {
        _money = _startMoney;
        MoneyChanged?.Invoke(_money);
        HealthChanged?.Invoke(_health);
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);
        
        if (_health <= 0)
        {
            Dead();
        }
    }

    public void AddMoney(int reward)
    {
        _money += reward;
        MoneyChanged?.Invoke(_money);
    }

    public void TakeAwayMoney(int money)
    {
        _money -= money;
        MoneyChanged?.Invoke(_money);
    }

    private void Dead()
    {
        _game.LevelFailed();
    }
}
