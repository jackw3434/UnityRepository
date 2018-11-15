using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LoadLevel : MonoBehaviour {

	public TileBase grassTile;
	public TileBase dirtTile;
	public TileBase underGroundTile;
	public TileBase[] floatingTiles;
	public TileBase[] rockTiles;
	public Tilemap tilemap;
	public Tilemap deathTileMap;
	public GameObject cherry;
	// Use this for initialization
	void Start ()
	{
		
		for (int i = 0; i < 64; i++)
		{
			tilemap.SetTile(new Vector3Int(Convert.ToInt32(i * 1.0f), 0, 0), grassTile);

			var firas = i;
			Debug.Log(firas);
			for (int j = 1; j < 4; j++)
			{
				if (UnityEngine.Random.Range(0, 100) > 90)
				{
					tilemap.SetTile(new Vector3Int(i, Convert.ToInt32(j * -1.0f), 0), rockTiles[UnityEngine.Random.Range(0, rockTiles.Length)]);
				}
				else
				{
					tilemap.SetTile(new Vector3Int(i, Convert.ToInt32(j * -1.0f), 0), underGroundTile);
				}
			}
		}

		for (int i = 10; i <= 50; i += UnityEngine.Random.Range(5, 10))
		{
			tilemap.SetTile(new Vector3Int(Convert.ToInt32(i * 1.0f), 3, 0), floatingTiles[0]);
			tilemap.SetTile(new Vector3Int(Convert.ToInt32(i+1 * 1.0f), 3, 0), floatingTiles[1]);
			tilemap.SetTile(new Vector3Int(Convert.ToInt32(i+2 * 1.0f), 3, 0), floatingTiles[2]);
			if (UnityEngine.Random.Range(0, 100) > 70)
			{
				Instantiate(cherry, new Vector3Int(Convert.ToInt32(i+1 * 1.0f), 4, 0), this.transform.rotation, this.transform);
			}
		}

	}
	
}
