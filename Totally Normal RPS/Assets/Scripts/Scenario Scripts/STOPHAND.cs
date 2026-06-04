using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STOPHAND : Scenario
{
    private void Start()
    {
        _timer = 2.0f;
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


            if (_gameController.GetRound() == GameController.Round.R3)
            {
                _timer = 2.0f;
            }

            else if (_gameController.GetRound() == GameController.Round.R4)
            {
                _timer = 1.7f;
            }

            else if (_gameController.GetRound() == GameController.Round.R5)
            {
                _timer = 1.4f;
            }
        }
    }
}
