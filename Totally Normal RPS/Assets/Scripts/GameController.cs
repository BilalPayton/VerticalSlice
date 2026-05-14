using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] private List<GameObject> _scenarioList;
    [SerializeField] private List<GameObject> _scenariosToBeAdded;
    [SerializeField] private List<GameObject> _newScenarioRules;
    [SerializeField] private GameObject _timerText;
    [SerializeField] private GameObject _gameOverUI;
    [SerializeField] private GameObject _retryButton;
    private float _timeTillNextScenario;

    private int scenarioIndex;
    private int _playerScore;
    private int _points;
    private bool _addPoints;

    void Start()
    {
        _timeTillNextScenario = 0.0f;
    }


    void Update()
    {
        if (_gameOverUI.activeSelf == false)
        {
            _retryButton.SetActive(false);

            if (_timeTillNextScenario <= 0.0f)
            {
                scenarioIndex = Random.Range(0, _scenarioList.Count);

                _scenarioList.ElementAt(scenarioIndex).gameObject.SetActive(true);
                _timerText.SetActive(true);

                _timeTillNextScenario = 2.0f;
                _addPoints = false;

            }

            if (_scenarioList.ElementAt(scenarioIndex).gameObject.activeSelf == false)
            {
                _timerText.SetActive(false);
                _timeTillNextScenario -= Time.deltaTime;

                if (!_addPoints)
                {
                    _points++;
                    _addPoints = true;
                }
            }

            if (_points == 6 && _scenariosToBeAdded.Count != 0)
            {
                _scenarioList.Add(_scenariosToBeAdded.ElementAt(0));
                _scenariosToBeAdded.RemoveAt(0);
                _points = 0;
                _timeTillNextScenario = 7.0f;
                _timeTillNextScenario -= Time.deltaTime;
                _timerText.SetActive(true);

                if (_newScenarioRules.Count != 0)
                {
                    _newScenarioRules.ElementAt(0).gameObject.SetActive(true);
                    _newScenarioRules.RemoveAt(0);
                }
            }
        }

        else
        {
            _retryButton.SetActive(true);
        }

            Debug.Log(_points);
    }

}
