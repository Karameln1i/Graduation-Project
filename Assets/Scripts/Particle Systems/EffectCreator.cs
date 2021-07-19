using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectCreator : MonoBehaviour
{
    [SerializeField] private ParticleSystem _effect;
    
    public void CreateEffect(Transform transform)
    {
        var effect = Instantiate(_effect.transform);
        effect.transform.position = new Vector3(transform.position.x, transform.position.y, 0);;
    }
}
