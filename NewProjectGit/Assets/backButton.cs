using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{
    public Button back;
    
    public string Scene1;
    
    // Start is called before the first frame update
    public void Start()
    {
        back.onClick.AddListener(OnClickBackButton);
        
    }
    private void OnClickBackButton()
    {
        
        SceneManager.LoadScene(Scene1);
    }
  

}
