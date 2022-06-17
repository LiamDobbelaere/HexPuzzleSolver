using System.Collections.Generic;
using UnityEngine;

public class HexTile : MonoBehaviour {
    public Dictionary<Direction, HexTile> neighbours = new Dictionary<Direction, HexTile>() {
        [Direction.TopRight] = null,
        [Direction.Right] = null,
        [Direction.BottomRight] = null,
        [Direction.BottomLeft] = null,
        [Direction.Left] = null,
        [Direction.TopLeft] = null
    };
    public bool occupied = false;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
