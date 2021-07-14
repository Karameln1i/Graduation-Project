using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerPriceView : MonoBehaviour
{
   [SerializeField] private Tower _tower;
   [SerializeField] private TMP_Text _text;

   private void Start()
   {
      _text.text = _tower.Price.ToString();
   }
}
