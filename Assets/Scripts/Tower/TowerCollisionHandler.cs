using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class TowerCollisionHandler : MonoBehaviour
{

    [SerializeField] private Projectile _projectile;
    [SerializeField] private GameObject _projectileLaunchSite;
    [SerializeField] private float _timeBeetwenAttack;
    
    private float _pastTime;
    private Enemy _enemyToAttack;
    
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
               Shoot(_enemyToAttack);
               _pastTime = 0;
           }
       }
   }

   private void Shoot(Enemy target)
   {
         Instantiate(_projectile,_projectileLaunchSite.transform).FlyToTarget(target);
   }
}
