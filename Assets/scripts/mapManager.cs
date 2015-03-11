using UnityEngine;
using System.Collections;

public class mapManager : MonoBehaviour {
	public Transform tileOne;
	public int mapSize;
	public Texture ONE;
	public Texture TWO;
	public Texture THREE;
	public Texture FOUR;
	public Texture FIVE;
	public Texture BLUE;
	public Texture RED;

	// Use this for initialization
	void Start () {		
		GameObject camera = GameObject.Find("Main Camera");
		camera.transform.localPosition = new Vector3((float)mapSize / 2, (float)mapSize, (float)mapSize / 2);
		camera.transform.localRotation = Quaternion.Euler (90, 180, 0);
		
		for (int x = 0; x < mapSize; x++) {
			for (int z = 0; z < mapSize; z++) {
				Transform tile = (Transform)Instantiate(tileOne);
				tile.localPosition = new Vector3((float)x, 0f, (float)z);
				Renderer rend = tile.GetComponent<Renderer>();
				rend.enabled = true;
				SetTexture(rend);
				if(x == 0 && z == 0) {
					rend.material.mainTexture = BLUE;
				}

				if(x == (mapSize-1) && z == (mapSize-1)) {
					rend.material.mainTexture = RED;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SetTexture(Renderer rend) {
		switch (Random.Range (1, 5)) {
		case 1:
			rend.material.mainTexture = ONE;
			break;
		case 2:
			rend.material.mainTexture = TWO;
			break;
		case 3:
			rend.material.mainTexture = THREE;
			break;
		case 4:
			rend.material.mainTexture = FOUR;
			break;
		case 5:
			rend.material.mainTexture = FIVE;
			break;
		default:
			rend.material.mainTexture = ONE;
			break;
		}
	}
}
