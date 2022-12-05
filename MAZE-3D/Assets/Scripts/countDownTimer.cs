using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDownTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float currentTime = 0f;
    public float startingTime = 60f;

    [SerializeField] Text countimer;

    void Start()
    {
        currentTime = startingTime;
    }



// Update is called once per frame
void Update()
    {
    currentTime -= 1 * Time.deltaTime;
    countimer.text = currentTime.ToString("0");

    if (currentTime <= 0f)
    {
        SceneManager.LoadScene("Gameover");
    }

}
}
