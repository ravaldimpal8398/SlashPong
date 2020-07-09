using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour
{

    public enum SceneName
    {

        None,
       
        Play,
        hook,
     
        
        GameOver
    }
    // Start is called before the first frame update
    public static UIManager Instance;
    public List<ScreenData> ScreenDataList;
    ScreenView currentScreen;
    public SceneName DefaultScreen;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        foreach (var item in ScreenDataList)
        {
            item.screen.Disable();
        }
        ChangeScreen(DefaultScreen);
    }
    public void ChangeScreen(SceneName sceneName)
    {

        ScreenData temp = ScreenDataList.Find(x => x.screenName == sceneName);

        if (currentScreen != null)
        {

            currentScreen.Hide();

        }
        currentScreen = temp.screen;
        currentScreen.Show();
    }



}
[System.Serializable]
public class ScreenData
{

    public UIManager.SceneName screenName;
    public ScreenView screen;
}
