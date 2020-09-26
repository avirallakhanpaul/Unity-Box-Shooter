using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TriggerLevelLoad : MonoBehaviour {

	public string nameOfLevelToLoad  = "";

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Projectile" )
		{
			SceneManager.LoadScene(nameOfLevelToLoad);
		}
	}
}
