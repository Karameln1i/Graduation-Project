using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private float _timeBeetwenSpawn;
    [SerializeField] private List<Enemy> _enemys=new List<Enemy>();
    [SerializeField] private int _maxCount;
    [SerializeField] private Transform _path;
    [SerializeField] private Player _target;
    
    private float _ealepseadTime;
    private int _spawnedCount;
    private int _numberOfDeathEnemis;
    
    
    private void Update()
    {
        _ealepseadTime += Time.deltaTime;

        if (_ealepseadTime >= _timeBeetwenSpawn&&_spawnedCount<_maxCount)
        {
            _ealepseadTime = 0;
            _spawnedCount++;
            Enemy enemy = Instantiate(_enemys[Random.Range(0, _enemys.Count)], transform.position, quaternion.identity);
           enemy.SetPath(_path);
           enemy.SetTarget(_target);
            enemy.Dying += OnEnemyDying;
        }
    }
    
    private void OnEnemyDying(Enemy enemy)
    {
        _numberOfDeathEnemis++;
        enemy.Dying -= OnEnemyDying;
        _target.AddMoney(enemy.Reward);

        if (_numberOfDeathEnemis==_maxCount)
        {
            _game.LevelPassed();
        }
    }
}
