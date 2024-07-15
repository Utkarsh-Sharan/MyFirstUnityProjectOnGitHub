using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MasterScene : MonoBehaviour
{
    [SerializeField] private Button _scene1Button;
    [SerializeField] private Button _scene2Button;
    [SerializeField] private Button _scene3Button;

    // Start is called before the first frame update
    void Start()
    {
        _scene1Button.onClick.AddListener(LoadSceneOne);
        _scene2Button.onClick.AddListener(LoadSceneTwo);
        _scene3Button.onClick.AddListener(LoadSceneThree);
    }

    private void LoadSceneOne()
    {
        SceneManager.LoadScene("Scene1");
    }

    private void LoadSceneTwo()
    {
        SceneManager.LoadScene("Scene2");
    }

    private void LoadSceneThree()
    {
        SceneManager.LoadScene("Scene3");
    }
}
