using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : Scenario
{
    
    void Start()
    {
        
    }

    
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.P))
        {
            this.gameObject.SetActive(false);
            _timer = 2.0f;
        }
    }
}
