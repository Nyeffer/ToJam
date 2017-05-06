using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isSelected : MonoBehaviour {
    public Vector2 tiles;
    public GameObject Tile;
    public Material whenSelected;
    public bool selected = false; 
    private Transform target;
    Vector2 getPosition;

	// Use this for initialization
	void Start () {
        tiles = new Vector2(Tile.transform.position.x, Tile.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
        getPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            if (Input.GetMouseButtonDown(0))
            {
                getSelected(tiles);
                selected = true;
            if(getSelected(tiles).x <= getPosition.x 
                || getSelected(tiles).y <= getPosition.y)
            {
                gameObject.GetComponent<Renderer>().material = whenSelected;
            }
       } 
		
	}
    
    public Vector2 getSelected(Vector2 self)
    {
        Vector2 transformRecieved = self;
        return transformRecieved;
    }

}
