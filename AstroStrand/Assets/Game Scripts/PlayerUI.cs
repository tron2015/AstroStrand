using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {
    private Player player;
    private Image oxygenBar, propellantBar;
    private float propellantLevels;

    void Awake() {
        Canvas canvas = GetComponent<Canvas>();
        Image[] bars = canvas.GetComponentsInChildren<Image>();
        if (bars[0].tag=="OxygenBar") {
            oxygenBar = bars[0];
            propellantBar = bars[2];
        } else {
            oxygenBar = bars[1];
            propellantBar = bars[2];
        }
        //oxygenBar = canvas.Find("oxygen");
        //propellantBar = canvas.Find("propellant");
        
    }


	// Use this for initialization
	void Start () {
        player=GameObject.FindGameObjectWithTag("astronaut").GetComponent<Player>();
        Debug.Log(player);
        Update();
    }
	
	// Update is called once per frame
	void Update () {
        updateOxygen();
        updatePropellant();
	}

    void updateOxygen() {
        float oxygenLevels = player.oxygen / player.maxOxygen;
        oxygenBar.rectTransform.anchoredPosition=new Vector2(-80,580-(1-oxygenLevels)*150);
        oxygenBar.rectTransform.sizeDelta = new Vector2(64, (300 * oxygenLevels));
        if (oxygenLevels<0.5) {
            if (oxygenLevels<0.25) {
                Color32 c = new Color32(0xFF, 0x00, 0x00,0x6E);
                oxygenBar.color = c;
            } else {
                Color32 c = new Color32(0xFF, 0xFF, 0x00,0x6E);
                oxygenBar.color = c;
            }
        } else {
            Color32 c= new Color32(0x00, 0xFF, 0x00,0x6E);
            oxygenBar.color = c;
        }
    }

    void updatePropellant() {
        float propellantLevels = player.propellant / player.maxPropellant;
        propellantBar.rectTransform.anchoredPosition = new Vector2(-160, 580 - (1 - propellantLevels) * 150);
        propellantBar.rectTransform.sizeDelta = new Vector2(64, (300 * propellantLevels));
        if (propellantLevels < 0.5) {
            if (propellantLevels < 0.25) {
                Color32 c = new Color32(0xFF, 0x00, 0x00, 0x6E);
                propellantBar.color = c;
            }
            else {
                Color32 c = new Color32(0xFF, 0x00, 0xFF, 0x6E);
                propellantBar.color = c;
            }
        }
        else {
            Color32 c = new Color32(0x00, 0x00, 0xFF, 0x6E);
            propellantBar.color = c;
        }
    }

    
}
