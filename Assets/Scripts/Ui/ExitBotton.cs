using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ExitBotton : MonoBehaviour
{
   [SerializeField]private Button _exitButton;
   
   private void OnEnable()
   {
      _exitButton.onClick.AddListener(OnExitButtonClick);
   }

   private void OnDisable()
   {
      _exitButton.onClick.RemoveListener(OnExitButtonClick);
   }

   private void OnExitButtonClick()
   {
      Application.Quit();
   }
   
}
