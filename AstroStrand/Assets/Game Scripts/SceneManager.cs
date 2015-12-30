using UnityEngine;
using System.Collections;

public class SceneManager: MonoBehaviour{
    private string lastGameScene="Tutorial";

    void Awake() {
        DontDestroyOnLoad(this);
    }

    public void gotoWinScene() {
        Application.LoadLevel("Win");
    }

    public void gotoDeathScene() {
        Application.LoadLevel("Die");
    }

    public void gotoMenuScene() {
        Application.LoadLevel("Menu");
    }

    public void gotoTutorialScene() {
        this.chargeGameScene("Tutorial");
    }

    public void gotoGameScene() {
        this.chargeGameScene("Game");
    }

    public void gotoGameOverScene() {
        Application.LoadLevel("Die");
    }

    public void chargeGameScene(string sceneName) {
        this.lastGameScene = sceneName;
        Application.LoadLevel(sceneName);
    }

    public void gotoLastGameScene() {
        Application.LoadLevel(lastGameScene);
    }


}
