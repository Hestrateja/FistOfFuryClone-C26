using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneIndex { MainMenu, Game }
public class SceneHandler : MonoBehaviour
{
    public void LoadGame()
    {
        Debug.Log("Botón presionado");
        SceneManager.LoadSceneAsync((int)SceneIndex.Game);
    }
}
