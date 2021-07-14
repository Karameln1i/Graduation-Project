using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;


public class OpenSelectLevelButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private SelectTowerPanel _panel;
    [SerializeField] private TowerInstallationSite _installationSite;

    private void OnEnable()
    {
        _button.onClick.AddListener(Open);
    }

    private void OnDisable()
    {
        _button.onClick.AddListener(Open);
    }

    private void Open()
    {
        if (_panel.gameObject.activeSelf==true)
        {
            _panel.Close();
        }
        
        _panel.transform.position = _installationSite.Center.transform.position;
        Debug.Log(_installationSite.name);
        _panel.Open(_installationSite); ;
    }
}
