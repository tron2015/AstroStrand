using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float oxygen=3.5f;//litres
    public float maxOxygen = 3.5f;//litres
    public float consumedOxygenPerBreath = 0.1167f;//litres
    public float timeBetweenBreath=3.5f;
    public float propellant=15;//litres   
    public float maxPropellant = 15;
    public float consumedPropellantPerTime=1.5f;//litres
    public float consumeTime = 0.5f;//seconds

    public AudioClip alarm;

    private bool levelFinished = false;
    private bool alive = true;
    private float timer;
    private AudioSource source;

    private SceneManager manager;

    void Awake() {
        source = GetComponent<AudioSource>();
        manager = GameObject.FindGameObjectWithTag("manager").GetComponent<SceneManager>();
    }

    // Use this for initialization
    void Start () {
        timer = timeBetweenBreath;
        Debug.Log(manager);
        Debug.Log("<Timer="+timeBetweenBreath+'>');
        Debug.Log("<Oxygen=" + oxygen + '>');
    }
	
	// Update is called once per frame
	void Update () {
        if (alive) {
            if (levelFinished) {
                manager.gotoWinScene();
            } else {
                updateOxygenLevel();
            }
        } else {
            Debug.Log("Calling for Game Over...");
            manager.gotoGameOverScene();
        }
	}

    void updateOxygenLevel() {
        Debug.Log("Player is alive: "+alive+" Oxygen: "+oxygen);
        if (oxygen>0) {
            if (timer>0) {
               timer -= Time.deltaTime;
            } else {
                Debug.Log("<Oxygen="+oxygen+'>');
                timer = timeBetweenBreath;
                oxygen -= consumedOxygenPerBreath;
            }
        } else {
            alive = false;
            Debug.Log("Player is Dead!");
        }
    }

    public void updatePropellantLevel() {
        if (alive) {
            propellant -= consumedPropellantPerTime;
        }
    }

    public void loadOxygen(float loadedOxygen) {
        oxygen += loadedOxygen;
        if (oxygen>maxOxygen) {
            oxygen = maxOxygen;
        }
    }

    public void loadPropellant(float loadedPropellant) {
        propellant += loadedPropellant;
        if (propellant>maxPropellant) {
            propellant = maxPropellant;
        }
    }

    public bool canJump() {
        return propellant >0;
    }

    public void reachEnd() {
        this.levelFinished = true;
    }

    public bool levelFinisehd() {
        return this.levelFinished;
    }
}
