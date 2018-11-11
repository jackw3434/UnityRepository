using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LoadLevel : MonoBehaviour {

	public TileBase grassTile;
	public TileBase dirtTile;
	public TileBase underGroundTile;
	public TileBase[] rockTiles;
	public Tilemap tilemap;
	public Tilemap deathTileMap;
	// Use this for initialization
	void Start ()
	{
		
		for (int i = 0; i < 64; i++)
		{
			tilemap.SetTile(new Vector3Int(Convert.ToInt32(i * 1.0f), 0, 0), grassTile);

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

	}
	
}
