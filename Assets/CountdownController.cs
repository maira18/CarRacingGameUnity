using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownController : MonoBehaviour
{
    [SerializeField] public Text countdownTextField;
    public float timeLeft = 3.0f;
    void Start()
    {
        //StartCoroutine(Countdown(4));
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        countdownTextField.text = (timeLeft).ToString();
        if (timeLeft < 1)
        {
            countdownTextField.text = "GO!";
        }
        if (timeLeft < 0)
        {
            countdownTextField.text = "";
        }
    }
}
