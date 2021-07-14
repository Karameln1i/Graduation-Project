using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealtBar : Bar
{
   [SerializeField] private Player _player;
   [SerializeField] private int _startHealth;

   private int _healths;

   private void OnEnable()
   {
      _player.HealthChanged += OnValueChanged;
   }

   private void OnDisable()
   {
      _player.HealthChanged += OnValueChanged;
   }
}
