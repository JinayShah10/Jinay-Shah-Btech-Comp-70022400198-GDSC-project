using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class UI : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI _gameoverText;
    // Start is called before the first frame update
    void Start()
    {
        _gameoverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            _gameoverText.gameObject.SetActive(true);
        }
    }




}

