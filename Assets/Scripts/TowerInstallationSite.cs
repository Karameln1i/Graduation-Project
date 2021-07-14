using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInstallationSite : MonoBehaviour
{
    [SerializeField] private SelectTowerPanel _panel;
    [SerializeField] private GameObject _center;
    
    private bool _isEmpety=true;

    public bool IsEmpty => _isEmpety;
    public GameObject Center => _center;

    public void TowerInstaled()
    {
        _isEmpety = false;
    }
    
}
