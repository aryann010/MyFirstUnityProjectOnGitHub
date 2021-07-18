using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public Button creed;
    public Button trinity;
    public Button kylo;
    public string creedScene;
    public string trinityScene;
    public string kyloScene;
    // Start is called before the first frame update
    public void Start()
    {
        creed.onClick.AddListener(creedWorld);
        trinity.onClick.AddListener(trinityWorld);
        kylo.onClick.AddListener(kyloWorld);
    }
    private void creedWorld()
    {
        //Debug.Log("creed");
        SceneManager.LoadScene(creedScene);
    }
    private void trinityWorld()
    {
       // Debug.Log("trinity");
        SceneManager.LoadScene(trinityScene);
    }
    private void kyloWorld()
    {
        //Debug.Log("kylo");
        SceneManager.LoadScene(kyloScene);
    }
    
}
