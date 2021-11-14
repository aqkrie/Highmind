using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapDrawer : MonoBehaviour
{
	public Tilemap surfaceMap;
	public Tilemap map;

	private void Update()
	{
		for (int x = 0; x < Game.activePlanet.size; x++)
		{
			for (int y = 0; y < Game.activePlanet.size; y++)
			{
				surfaceMap.SetTile(new Vector3Int(x, y, 0), Game.activePlanet.surfaceMap[x, y].tile);
				map.SetTile(new Vector3Int(x, y, 0), Game.activePlanet.map[x, y].tile);
			}
		}
	}
}
