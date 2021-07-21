using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Tower))]
public class TowerShootRange : MonoBehaviour
{
    [SerializeField] private TowerAttack _towerAttack;

    private float _timeBeetwenAttack;
    private float _elapsedTime;
    private Enemy _enemyToAttack;

    private void Start()
    {
        _timeBeetwenAttack = GetComponent<Tower>().TimeBeetwenAttack;
    }
    
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
    }
    
    private void OnTriggerStay2D(Collider2D collision)
   {
       if (collision.TryGetComponent<Enemy>(out Enemy enemy))
       {
           if (enemy.IsAlive)
           {
               _enemyToAttack = enemy;
               
               if (_elapsedTime >= _timeBeetwenAttack&&_enemyToAttack!=null)
               {
                   _towerAttack.Shoot(_enemyToAttack);
                   _elapsedTime = 0;
               }
           }
       }
   }
}
