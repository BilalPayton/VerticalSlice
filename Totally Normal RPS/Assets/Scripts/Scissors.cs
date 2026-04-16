using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : Scenario
{
    
    void Start()
    {
        
    }

    
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.gameObject.SetActive(false);
            _timer = 2.0f;
        }
    }
}
