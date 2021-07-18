using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject _levelFailedPanel;
    [SerializeField] private GameObject _levelPassedPanel;
    [SerializeField] private Menu _menu;

    public void LevelPassed()
    {
        _menu.OpenPanel(_levelPassedPanel);
    }

    public void LevelFailed()
    {
        _menu.OpenPanel(_levelFailedPanel);
    }
    
}
