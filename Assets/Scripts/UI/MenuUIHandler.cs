using System.Collections;
using System.Collections.Generic;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField userInput; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        userInput.onValueChanged.AddListener(delegate(string str) { SaveName(str); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveName(string name)
    {
        DataManager.Instance.UserName = name;
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit()
#endif
    }
}
