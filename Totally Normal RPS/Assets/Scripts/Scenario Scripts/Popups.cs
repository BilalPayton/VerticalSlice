using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Popups : Scenario
{
    private int _numPopups;
    [SerializeField] private GameObject _popup;

    private int _popupsDestroyed = 0;

    private bool _spawnPopup;
    private void Start()
    {
        _timer = 5.0f;
        _spawnPopup = true;
    }

    protected override void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text = "" + _timer;

        if (_spawnPopup == true)
        {
            SpawnPopups();
            _spawnPopup = false;
        }


        if (_timer <= 0.0f && _popupsDestroyed != _numPopups)
        {
            this.gameObject.SetActive(false);
            _gameOverUI.SetActive(true);
        }

        if (_popupsDestroyed == _numPopups)
        {
            _popupsDestroyed = 0;
            this.gameObject.SetActive(false);
            _timer = 5.0f;
            _spawnPopup = true;
        }
    }

    public void PopupDestroyed()
    {
        _popupsDestroyed++;
    }

    private void SpawnPopups()
    {
        _numPopups = Random.Range(4, 8);

        for (int i = 0; i < _numPopups; i++)
        {
            float x = Random.Range(-6.0f, 8.0f);
            float y = Random.Range(-4.0f, 4.0f);

            Vector3 spawn = new Vector3(x, y, 0);

            Instantiate(_popup, spawn, Quaternion.identity);
        }
    }

}
