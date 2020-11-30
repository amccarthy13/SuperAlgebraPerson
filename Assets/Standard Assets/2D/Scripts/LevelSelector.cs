using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1()
    {
    	SceneManager.LoadScene("GameScene");
    }

    public void LoadLevelSelect()
    {
    	SceneManager.LoadScene("LevelSelect");
    }

    public void LoadBossLevel()
    {
        SceneManager.LoadScene("Boss");
    }

    public static void LoadDeathLevel()
    {
        SceneManager.LoadScene("DeathLevel");
    }

    public static void LoadVictoryLevel()
    {
        SceneManager.LoadScene("VictoryLevel");
    }
}
