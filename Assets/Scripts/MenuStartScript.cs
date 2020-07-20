using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuStartScript : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject joinMenuUI;
    public GameObject hostMenuUI;
    public GameObject optionsMenuUI;

    List<GameObject> listGameObject;

    public Button bJoin;
    public Button bHost;
    public Button bOptions;
    public Button bExit;
    public Button bBackJoin;
    public Button bBackHost;
    public Button bBackOptions;
    public Button bFind;

    void Start()
    {
        bJoin.onClick.AddListener(OnClickJoinButton);
        bHost.onClick.AddListener(OnClickHostButton);
        bOptions.onClick.AddListener(OnClickOptionsButton);
        bExit.onClick.AddListener(OnClickExitButton);
        bFind.onClick.AddListener(OnClickFindButton);

        bBackJoin.onClick.AddListener(delegate { OnClickBack(joinMenuUI); });
        bBackHost.onClick.AddListener(delegate { OnClickBack(hostMenuUI); });
        bBackOptions.onClick.AddListener(delegate { OnClickBack(optionsMenuUI); });

        listGameObject = new List<GameObject>();

        listGameObject.Add(mainMenuUI);
        listGameObject.Add(joinMenuUI);
        listGameObject.Add(hostMenuUI);
        listGameObject.Add(optionsMenuUI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickJoinButton()
    {
        mainMenuUI.SetActive(false);
        joinMenuUI.SetActive(true);
    }

    public void OnClickHostButton()
    {
        mainMenuUI.SetActive(false);
        hostMenuUI.SetActive(true);
    }

    public void OnClickOptionsButton()
    {
        mainMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
    }

    public void OnClickFindButton()
    {
        joinMenuUI.SetActive(false);
        Debug.Log("sceneName to load: " + "FirstMap");
        SceneManager.LoadScene("FirstMap");
    }

    public void OnClickExitButton()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void OnClickBack(GameObject activeLayout)
    {
        activeLayout.SetActive(false);
        mainMenuUI.SetActive(true);
    }
}
