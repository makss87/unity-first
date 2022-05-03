using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text userDataText;


    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadScore();
        userDataText.text = "Best Score :"+DataManager.Instance.Score+" Name : " + DataManager.Instance.UserName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
