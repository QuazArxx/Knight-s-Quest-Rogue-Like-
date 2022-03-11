using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuButtonScript : MonoBehaviour
{
    public void OnMouseup ()
    {
        switch(gameObject.tag)
        {
            case "StartButton":
                SceneManager.LoadScene("GameArea", LoadSceneMode.Single);
                break;
            case "ExitButton":
                Application.Quit();
                break;
            default:
                Debug.Log("Something went wrong!");
                break;
        }
    }
}
