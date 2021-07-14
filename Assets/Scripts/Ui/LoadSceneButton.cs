using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public  class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private SceneReference _scene;
    [SerializeField] private Button _button;
    
    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }
    
    protected void OnButtonClick()
    {
        SceneManager.LoadScene(_scene);
    }
}
