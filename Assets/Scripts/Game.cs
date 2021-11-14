using UnityEngine;

public class Game : MonoBehaviour
{
	public static Planet activePlanet;

	private void Start()
	{
		activePlanet = new Planet(4);
	}
}
