using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   
    public  Text         levelCounterText   = default;

    public  GameObject   levelComplatedText = default;
    [SerializeField]
    private GameObject[] PullableObjects   = default;

    private int          levelCounter      = default;


    void Start()
    {

        InvokeRepeating("IsLevelComplated", 0, 2);//is lvel is complate
    }

    #region Level
    void IsLevelComplated()
    {
        PullableObjects = GameObject.FindGameObjectsWithTag("Pullable");

        //have ı any pullabl eobject
        if (PullableObjects.Length == 0)
        {
            LevelİsComplated();//ı have any pullabl eobject than complated
        }

    }

    void LevelİsComplated()
    {
        Debug.Log("levelcomplated");
        //levelcoplete
        UILevelComplated();
        //
        levelCounter++;
        levelCounterText.text = levelCounter.ToString();
        //
        StartCoroutine("WaitForLoadScene");

    }

    void UILevelComplated()
    {
        levelComplatedText.SetActive(true);
        
    }
    #endregion

    #region coroutine
    IEnumerator WaitForLoadScene()
    {

        yield return new WaitForSecondsRealtime(1.5f); //Wait 0.47 second

        SceneManager.LoadScene(1);

    }
    #endregion coroutine
}
