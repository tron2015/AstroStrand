using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {
    GameObject oxygenCase;
  
    
    void Awake() {
        
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void createOxygenCase() {
        GameObject case1 = new GameObject();
        case1.AddComponent<CaseScript>();

    }

}
