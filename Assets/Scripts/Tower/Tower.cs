using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
   [SerializeField] private int _price;
   [SerializeField] private float _timeBeetwenAttack;
   
   public float TimeBeetwenAttack => _timeBeetwenAttack;

   public int Price => _price;
}
