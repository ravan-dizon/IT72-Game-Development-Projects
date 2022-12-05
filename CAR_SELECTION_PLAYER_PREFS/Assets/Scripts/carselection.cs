using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class carselection : MonoBehaviour
{
    public InputField textBox;
    public GameObject[] cars;
    public int currentCar;
    public bool inGamePlayScene = false;

    void Start()
    {
       int selectedCar = PlayerPrefs.GetInt("SelectedCarID");
        if (inGamePlayScene == true) {
            cars[selectedCar].SetActive(true);
            currentCar = selectedCar;
        } 
    }

    // Update is called once per frame
    void Update()
    {
       //transform.Rotate(0f, 2 * Time.deltaTime, 0f, Space.Self);
    }
    public void Right() {
        
        if (currentCar < cars.Length - 1) {
            currentCar += 1;
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].SetActive(false);
                cars[currentCar].SetActive(true);
            }
        }
    }
     public void Left()
    {

        if (currentCar > 0)
        {
            currentCar -= 1;
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].SetActive(false);
                cars[currentCar].SetActive(true);
            }
        }
    
}
    public void Select() 
    {
        PlayerPrefs.SetString("carname", textBox.text);
        //Debug.Log(PlayerPrefs.GetString("carname"));
        PlayerPrefs.SetInt("SelectedCarID", currentCar);
        SceneManager.LoadScene(1);
    }
   public void Play() 
    {
        PlayerPrefs.GetString("carname");
        //Debug.Log(PlayerPrefs.GetString("carname"));
        PlayerPrefs.SetInt("SelectedCarID", currentCar);
        SceneManager.LoadScene("newScene");
    }
     public void clickReset()
    {
        PlayerPrefs.DeleteKey("carname");
        PlayerPrefs.DeleteKey("SelectedCarID");
        SceneManager.LoadScene("Scene1");
    }
    void OnTriggerEnter(Collider other){
        if (other.name == "obstacles"){
           SceneManager.LoadScene("youLose");
           //Debug.Log("Game Over!!");
        }
    }
}
