using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPop : MonoBehaviour
{
    public TextMeshProUGUI text;

    public GameObject TimeAddUI;
    public GameObject ScoreAddUI;
    public GameObject ScoreSubtractUI;


    public IEnumerator addedTimeUI()
    {
        TimeAddUI.SetActive(true);
        

       yield return new WaitForSeconds(1);


        TimeAddUI.SetActive(false);

        yield return null;
    }


    public IEnumerator AddScore()
    {
        ScoreAddUI.SetActive(true);

        yield return new WaitForSeconds(1);


        ScoreAddUI.SetActive(false);

        yield return null;
    }




    public IEnumerator SubtractScore()
    {
        ScoreSubtractUI.SetActive(true);

        yield return new WaitForSeconds(1);


        ScoreSubtractUI.SetActive(false);

        yield return null;
    }
}
