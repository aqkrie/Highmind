using UnityEngine;
using UnityEngine.Tilemaps;

public class Block
{
	public string name;
	public bool onlySurface;

	public TileBase tile;

	public TileBase LoadResources()
	{
		return Resources.Load<TileBase>($"Tile/{name}");
	}
}
