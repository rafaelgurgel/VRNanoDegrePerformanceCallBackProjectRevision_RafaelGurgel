using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour {

    private int _Lifetime;
    private float _Timer;
    private Vector3 _Startposition;
    private bool _PositionReset;

    private void Start()
    {
        _Lifetime = 20;
        _Startposition = new Vector3(0, 6, 0);
        _Timer = 0;
        _PositionReset = false;
        InvokeRepeating("ResetBallPosition", 0, 10);
    }
    

    private void ResetBallPosition()
    {
        this.gameObject.transform.position = _Startposition;
    }
}
