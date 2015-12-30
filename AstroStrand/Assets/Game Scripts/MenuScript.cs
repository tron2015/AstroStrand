using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public Button playGameButton;
    public Button playTutorialButton;
    public Button settingsButton;
    public Button exitButton;
    private SceneManager manager;


	// Use this for initialization
	void Start () {
        playGameButton = playGameButton.GetComponent<Button>();
        playTutorialButton = playTutorialButton.GetComponent<Button>();
        settingsButton = settingsButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
        manager = manager.GetComponent<SceneManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void exit() {
        Application.Quit();
    }

    void loadTutorial() {
        manager.gotoTutorialScene();
    }

    void loadGame() {
        manager.gotoGameScene();
    }

    void loadSettings() {

    }
}
