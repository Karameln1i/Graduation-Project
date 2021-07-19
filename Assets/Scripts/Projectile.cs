using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.Mathematics;
using Random = UnityEngine.Random;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _duration;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _lifeTime;
    [SerializeField] private EffectCreator _effectCreator;

    private float _ealepseadTime;

    private void Start()
    {
        _audioSource.Play();
    }

    private void Update()
    {
        _ealepseadTime += Time.deltaTime;

        if (_ealepseadTime>=_lifeTime)
        {
            Destroy(gameObject);
            _ealepseadTime = 0;
        }
    }
    
    public void FlyToTarget(Enemy target)
    {
        transform.DOMove(target.transform.position, _duration);
        Vector3 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
            _effectCreator.CreateEffect(collision.transform);
            Destroy(gameObject);
        }
    }
}
