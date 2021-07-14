using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyBar : Bar
{
    [SerializeField] private Player _player;
    
    private void OnEnable()
    {
        _player.MoneyChangedChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.MoneyChangedChanged -= OnValueChanged;
    }
    
}
