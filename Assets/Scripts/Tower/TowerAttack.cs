using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Tower))]
public class TowerAttack : MonoBehaviour
{
    private Projectile _projectile;
    private GameObject _projectileLaunchSite;

    private void Start()
    {
        _projectile = GetComponent<Tower>().Projectile;
        _projectileLaunchSite = GetComponent<Tower>().ProjectileLaunchSite;
    }
    
    
    public void Shoot(Enemy target)
    {
        Instantiate(_projectile,_projectileLaunchSite.transform).FlyToTarget(target);
    }
}
