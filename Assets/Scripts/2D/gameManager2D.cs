using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class gameManager2D : MonoBehaviour {

    public static gameManager2D Instance;

    public GameObject playerObject; //Load player2D prefab here
    [SerializeField] public GameObject[] level;
    public int activeLevel = 0; //Current Level that we are testing. Default = 0;
    public Vector3 levelPos; //input level position
    public Vector3 playerPos; //input player position
    public Vector3 playerScale = new Vector3(10f, 10f, 10f); //input player position
    public int ActiveLevel //Set active level as a property
    {
        get { return activeLevel; }
        set
        {
            activeLevel = value;
            changeLevel();
        }
    }

    void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start () {
        //Define monitor game object
        GameObject monitorDraw = GameObject.Find("monitorDraw");

        //Instantiate initial screen
        GameObject title = Instantiate(level[activeLevel]) as GameObject;
        title.transform.parent = monitorDraw.transform;
        title.transform.SetSiblingIndex(0);
        title.GetComponent<RectTransform>().localPosition = levelPos; ;
        title.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);

        //Instantiate player avatar if not debugging title
        if (activeLevel != 0)
        {
            GameObject player = Instantiate(playerObject) as GameObject;
            player.transform.parent = monitorDraw.transform; //Nest player avatar in monitor object 
            player.transform.SetSiblingIndex(1);
            player.GetComponent<RectTransform>().localPosition = playerPos;
            player.GetComponent<RectTransform>().localScale = playerScale;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //
    public void changeLevel()
    {
        //Define monitor game object
        GameObject monitorDraw = GameObject.Find("monitorDraw");

        //Replace previous level with new level
        GameObject previousLevel = GameObject.FindGameObjectWithTag("Level");
        Destroy(previousLevel);

        //Instantiate new level
        GameObject title = Instantiate(level[activeLevel]) as GameObject;
        title.transform.parent = monitorDraw.transform;
        title.transform.SetSiblingIndex(0);
        title.GetComponent<RectTransform>().localPosition = levelPos;
        title.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);

        //Destroy previous avatar
        GameObject previousAvatar = GameObject.FindGameObjectWithTag("Player");
        Destroy(previousAvatar);

        //Instantiate player avatar
        GameObject player = Instantiate(playerObject) as GameObject;
        player.transform.parent = monitorDraw.transform; //Nest player avatar in monitor object 
        player.transform.SetSiblingIndex(1);
        player.GetComponent<RectTransform>().localPosition = playerPos;
        player.GetComponent<RectTransform>().localScale = new Vector3(10, 10, 0);
    }
}
