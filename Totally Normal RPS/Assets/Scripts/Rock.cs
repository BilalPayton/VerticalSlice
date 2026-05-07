using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Scenario
{
    
    void Start()
    {
        _requiredKey = KeyCode.P;
    }

    
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(_requiredKey))
        {
            this.gameObject.SetActive(false);
            _timer = 3.0f;
        }
    }
}
