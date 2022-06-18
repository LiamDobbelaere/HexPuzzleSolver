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
    public Color targetColor;

    private Renderer rend;

    // Start is called before the first frame update
    void Start() {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update() {
        rend.material.color = Color.Lerp(rend.material.color, targetColor, 8f * Time.deltaTime);
    }
}
