using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    public void click()
    {
        Debug.Log("クリック");
        Initiate.Fade(loadScene, fadeColor, fadeSpeedMultiplier);
    }
}
