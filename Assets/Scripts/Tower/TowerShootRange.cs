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
    private float _pastTime;
    private Enemy _enemyToAttack;

    private void Start()
    {
        _timeBeetwenAttack = GetComponent<Tower>().TimeBeetwenAttack;
    }
    
    
    private void Update()
    {
        _pastTime += Time.deltaTime;
    }
    
   private void OnTriggerStay2D(Collider2D collision)
   {
       if (collision.TryGetComponent<Enemy>(out Enemy enemy))
       {
           _enemyToAttack = enemy;

           if (_pastTime >= _timeBeetwenAttack)
           {
               _towerAttack.Shoot(_enemyToAttack);
               _pastTime = 0;
           }
       }
   }

  
}
