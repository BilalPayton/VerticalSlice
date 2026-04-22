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
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.gameObject.SetActive(false);
            _timer = 3.0f;
        }
    }
}
