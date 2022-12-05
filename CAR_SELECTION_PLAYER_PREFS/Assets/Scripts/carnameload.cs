using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class carnameload : MonoBehaviour
{
    public Text CarnameBox;
    // Start is called before the first frame update
    void Start()
    {
        CarnameBox.text = PlayerPrefs.GetString("carname");
    }

    public void clickReset()
    {
        PlayerPrefs.DeleteKey("carname");
        PlayerPrefs.DeleteKey("SelectedCarID");
        SceneManager.LoadScene("Scene1");
    }
}
