using UnityEngine;
using System.Collections;

public class WinnerResolver : MonoBehaviour {

    public Transform player;
    public Transform target;
    public GameObject winningText;
	
	// Update is called once per frame
	void Update () {
	    if (player.position == target.position)
        {
            winningText.SetActive(true);
        }
	}
}
