using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private GameObject _levelFailedPanel;
    [SerializeField] private GameObject _levelPassedPanel;
    [SerializeField] private Menu _menu;

    private void OnEnable()
    {
        _player.PlayerDied += OnPlayerDied;
        _spawner.AllEnemisDied += OnAllEnemisDied;
    }

    private void OnDisable()
    {
        _player.PlayerDied -= OnPlayerDied;
        _spawner.AllEnemisDied -= OnAllEnemisDied;
    }
    
    public void OnAllEnemisDied()
    {
        _menu.OpenPanel(_levelPassedPanel);
    }

    public void OnPlayerDied()
    {
        _menu.OpenPanel(_levelFailedPanel);
    }
    
}
