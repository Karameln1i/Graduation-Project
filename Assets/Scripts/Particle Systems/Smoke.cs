using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
   [SerializeField] private ParticleSystem _smoke;

   public void CreateSmoke(Transform transform)
   {
     var smoke= Instantiate(_smoke.transform);
     smoke.transform.position = new Vector3(transform.position.x, transform.position.y, 0);;

   }
}
