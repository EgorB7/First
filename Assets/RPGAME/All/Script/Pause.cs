using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject bg;
    public GameObject con;
    public GameObject men;
    // Start is called before the first frame update
    void Start()
    {
        con.SetActive(false);
        men.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        Time.timeScale = 0;
        bg.SetActive(true);
        men.SetActive(true);
        con.SetActive(true);
    }
   
    public void Continue()
    {
        Time.timeScale = 1;
        bg.SetActive(false);
        con.SetActive(false);
        men.SetActive(false);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
