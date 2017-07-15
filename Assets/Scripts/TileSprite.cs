using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileSprite {
    public string Name;
    public Sprite TileImage;
    public Tile TileType;

    public TileSprite()
    {
        Name = "Unset";
        TileImage = new Sprite();
        TileType = Tile.Unset;
    }

    public TileSprite(string name, Sprite image, Tile tile)
    {
        Name = name;
        TileImage = image;
        TileType = tile;
    }
	
}
