using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : Scenario
{
    
    void Start()
    {
        _requiredKey = KeyCode.R;
        _timer = 3.0f;
    }

}
