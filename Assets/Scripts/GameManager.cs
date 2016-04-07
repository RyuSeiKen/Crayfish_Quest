using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject prefab;
    public Slider spawnSlider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Spawn() {

        GameObject instance = Instantiate(prefab) as GameObject;
        instance.transform.localPosition = new Vector3(spawnSlider.value, 0.0f, 0.0f);

    }
}
