using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Tower))]
public class TowerAttack : MonoBehaviour
{
   [SerializeField] private Projectile _projectile;
   [SerializeField] private GameObject _projectileLaunchSite;
   
    public void Shoot(Enemy target)
    {
        Instantiate(_projectile,_projectileLaunchSite.transform).FlyToTarget(target);
    }
}
