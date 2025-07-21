using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Finish : MonoBehaviour
{
    public GameObject NextLevelUI;
    [SerializeField] AudioSource winsound;
    public GameObject BgSound;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "player")
        {   
            winsound.Play();
            Invoke("LevelComplete", 2f);
            
        }
       
    }

    void LevelComplete()
    {   
        BgSound.SetActive(false);
        NextLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void NextScene()
    {   
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
    }
}

