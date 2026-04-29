using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STOPHAND : Scenario
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text = "" + _timer;

        if (Input.anyKeyDown)
        {
            this.gameObject.SetActive(false);
            _gameOverUI.SetActive(true);
        }

        if (_timer <= 0.0f)
        {
            this.gameObject.SetActive(false);
            _timer = 3.0f;
        }
    }
}
