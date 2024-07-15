using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour
{
    [SerializeField] private Button _button;

    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(BackToMasterScene);    
    }
    
    private void BackToMasterScene()
    {
        SceneManager.LoadScene("MasterScene");
    }
}
