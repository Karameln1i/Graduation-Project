using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
   [SerializeField] private int _price;
   [SerializeField] private Projectile _projectile;
   [SerializeField] private GameObject _projectileLaunchSite;
   [SerializeField] private float _timeBeetwenAttack;

   public Projectile Projectile => _projectile;
   public GameObject ProjectileLaunchSite => _projectileLaunchSite;
   public float TimeBeetwenAttack => _timeBeetwenAttack;

   public int Price => _price;
}
