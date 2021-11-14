public class Planet
{
	public int size;
	public Block[,] surfaceMap;
	public Block[,] map;

	public Planet(int size)
	{
		this.size = size;
		surfaceMap = new Block[size, size];
		map = new Block[size, size];

		Genetare();
	}

	public void Genetare()
	{
		for (int x = 0; x < size; x++)
		{
			for (int y = 0; y < size; y++)
			{
				surfaceMap[x, y] = new Grass();
				map[x, y] = new Air();
			}
		}
	}
}
