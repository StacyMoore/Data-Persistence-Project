using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public GameObject playerName;
    // Start is called before the first frame update

    private void Start()
    {
        playerName.GetComponent<Text>().text = DataManager.Instance.playerName;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void PlayerNameChanged()
    {
        DataManager.Instance.playerName = playerName.GetComponent<Text>().text;
    }
}
