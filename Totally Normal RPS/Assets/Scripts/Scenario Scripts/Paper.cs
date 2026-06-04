using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : Scenario
{
    
    void Start()
    {
        _requiredKey = KeyCode.S;
        _timer = 3.0f;
    }

}
