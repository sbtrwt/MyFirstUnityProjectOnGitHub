using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public Button sceneButton;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = sceneButton.GetComponent<Button>();
        if (btn) {
            btn.onClick.AddListener(OnClick);
        }
    }

    void OnClick() {
        //Load scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
   
}
