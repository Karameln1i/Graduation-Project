using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveState : State
{
    [SerializeField] private float _speed;
    private Transform _path;

    private Transform[] _points;
    private int _currentPoint;

    public event UnityAction WayPassed;
    
    private void Start()
    {
        _path = GetComponent<Enemy>().Path;

        _points=new Transform [_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = Path.GetChild(i);
        }

        _currentPoint = 0;
    }
    
    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (target.position.x<transform.position.x)
        {
            transform.rotation = new Quaternion(0,180,0,0);
        }

        if (transform.position==target.position)
        {
            _currentPoint++;
        }

        if (_currentPoint>=_points.Length)
        {
            WayPassed?.Invoke();
        }
    }
}