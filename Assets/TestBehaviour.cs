using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
			StartCoroutine(Routine());
    }

	IEnumerator Routine()
	{
		while (true)
		{
			yield return new WaitForSeconds(0.3f);
			Siren.Audio.SendEvent(new Siren.AudioEvent(this, Siren.AudioCommands.PLAY, "debug"));
		}
	}
}
