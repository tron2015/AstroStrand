using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    private SceneManager manager;
    private Button retryButton, menuButton;

	// Use this for initialization
	void Start () {
        manager = GameObject.FindGameObjectWithTag("manager").GetComponent<SceneManager>();
        retryButton = GameObject.FindGameObjectWithTag("retryButton").GetComponent<Button>();
        menuButton= GameObject.FindGameObjectWithTag("menuButton").GetComponent<Button>();

        retryButton.onClick.AddListener(() => { manager.gotoLastGameScene(); });
        menuButton.onClick.AddListener(() => { manager.gotoMenuScene(); });
    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
