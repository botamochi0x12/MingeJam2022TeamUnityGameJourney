using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonAction : MonoBehaviour
{
    public void Exit() 
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
        UnityEngine.Application.Quit();
        #endif
    }

    public void OnClick() 
    {
        Exit();
    }
}
