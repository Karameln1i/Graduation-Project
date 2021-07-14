using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DistanceTransition : Transition
{
    [SerializeField] private float _transitionRange;
    [SerializeField] private float _rangeSpread;
    [SerializeField] private MoveState _moveState;

    private void OnEnable()
    {
        _moveState.WayPassed += OnWayPassed;
    }

    private void OnDisable()
    {
        _moveState.WayPassed -= OnWayPassed;
    }

    private void Start()
    {
        _transitionRange+=Random.Range(-_rangeSpread, _rangeSpread);
    }

    private void OnWayPassed()
    {
        NeedTransit = true;
    }
}
