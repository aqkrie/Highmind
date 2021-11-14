using UnityEngine;

public class Grass : Block
{
	public Color color;

	public Grass()
	{
		name = "grass";
		onlySurface = true;

		tile = LoadResources();
		color = Color.green;
	}
}
