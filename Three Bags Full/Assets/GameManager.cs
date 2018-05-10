using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public List<GameObject> actors;
    // Use this for initialization
    void Awake () {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }

        actors = new List<GameObject>(GameObject.FindGameObjectsWithTag("Actor"));

	}
	
	// Update is called once per frame
	void Update () {
        ActorScaling();

    }

    void ActorScaling()
    {
        foreach (GameObject actor in actors)
        {

            Vector3 screenLoc = Camera.main.WorldToScreenPoint(new Vector3(actor.transform.position.x, actor.transform.position.y, 0f));
            actor.transform.localScale = new Vector2(Mathf.Clamp(screenLoc.y/100f, 1f, 5f), Mathf.Clamp(screenLoc.y/100f,1f, 5f));
        }
    }
}
