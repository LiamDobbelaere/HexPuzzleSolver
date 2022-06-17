using System.Collections.Generic;
using UnityEngine;

public enum Direction {
    TopRight,
    Right,
    BottomRight,
    BottomLeft,
    Left,
    TopLeft
}

public class PieceModel {
    public string name;
    public Color color;
    public Direction[][] orientations;
}

public class HexPuzzleSolver : MonoBehaviour {
    public PieceModel[] hexPieceModels = new PieceModel[] {
        new PieceModel {
            name = "Orange",
            color = new Color(0.5f, 0.25f, 0f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.Right, Direction.BottomRight
                },
                new Direction[] {
                    Direction.TopRight, Direction.Right
                },
                new Direction[] {
                    Direction.TopLeft, Direction.TopRight
                },
                new Direction[] {
                    Direction.Left, Direction.TopLeft
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.Left
                },
                new Direction[] {
                    Direction.BottomRight, Direction.BottomLeft
                }
            }
        },
        new PieceModel {
            name = "Green",
            color = new Color(0f, 0.5f, 0.15f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.Right, Direction.TopRight, Direction.BottomLeft, Direction.BottomRight
                },
                new Direction[] {
                    Direction.TopRight, Direction.TopLeft, Direction.BottomRight, Direction.Right
                },
                new Direction[] {
                    Direction.TopLeft, Direction.Left, Direction.Right, Direction.TopRight
                },
                new Direction[] {
                    Direction.Left, Direction.BottomLeft, Direction.TopRight, Direction.TopLeft
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.Left, Direction.Right, Direction.BottomRight
                },
                new Direction[] {
                    Direction.BottomRight, Direction.Right, Direction.Left, Direction.BottomLeft
                },
            }
        },
        new PieceModel {
            name = "Pink",
            color = new Color(1f, 0.5f, 0.5f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.Right, Direction.Right
                },
                new Direction[] {
                    Direction.TopRight, Direction.TopRight
                },
                new Direction[] {
                    Direction.TopLeft, Direction.TopLeft
                },
                new Direction[] {
                    Direction.Left, Direction.Left
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.BottomRight, Direction.BottomRight
                },
            }
        },
        new PieceModel {
            name = "Lightblue",
            color = new Color(0.5f, 0.75f, 1f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.Right, Direction.Right, Direction.Right
                },
                new Direction[] {
                    Direction.TopRight, Direction.TopRight, Direction.TopRight
                },
                new Direction[] {
                    Direction.TopLeft, Direction.TopLeft, Direction.TopLeft
                },
                new Direction[] {
                    Direction.Left, Direction.Left, Direction.Left
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.BottomLeft, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.BottomRight, Direction.BottomRight, Direction.BottomRight
                },
            }
        },
        new PieceModel {
            name = "Purple",
            color = new Color(0.75f, 0.5f, 0.75f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.TopRight, Direction.BottomRight
                },
                new Direction[] {
                    Direction.TopRight, Direction.Left
                },
                new Direction[] {
                    Direction.TopLeft, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.Left, Direction.BottomRight
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.Right
                },
                new Direction[] {
                    Direction.BottomRight, Direction.TopRight
                }
            }
        },
        new PieceModel {
            name = "Mint",
            color = new Color(0.75f, 1f, 0.75f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.Right, Direction.TopRight, Direction.Right
                },
                new Direction[] {
                    Direction.TopRight, Direction.TopLeft, Direction.TopRight
                },
                new Direction[] {
                    Direction.TopLeft, Direction.Left, Direction.TopLeft
                },
                new Direction[] {
                    Direction.Left, Direction.BottomLeft, Direction.Left
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.BottomRight, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.BottomRight, Direction.Right, Direction.BottomRight
                },

            }
        },
        new PieceModel {
            name = "White",
            color = new Color(1f, 1f, 1f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.TopRight, Direction.BottomRight, Direction.Right
                },
                new Direction[] {
                    Direction.TopLeft, Direction.Right, Direction.TopRight
                },
                new Direction[] {
                    Direction.Left, Direction.TopRight, Direction.TopLeft
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.TopLeft, Direction.Left
                },
                new Direction[] {
                    Direction.BottomRight, Direction.Left, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.Right, Direction.BottomLeft, Direction.BottomRight
                }
            }
        },
        new PieceModel {
            name = "Gray",
            color = new Color(0.5f, 0.5f, 0.5f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.BottomRight, Direction.Right, Direction.Right
                },
                new Direction[] {
                    Direction.Right, Direction.TopRight, Direction.TopRight
                },
                new Direction[] {
                    Direction.TopRight, Direction.TopLeft, Direction.TopLeft
                },
                new Direction[] {
                    Direction.TopLeft, Direction.Left, Direction.Left
                },
                new Direction[] {
                    Direction.Left, Direction.BottomLeft, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.BottomRight, Direction.BottomRight
                }
            }
        },
        new PieceModel {
            name = "Yellow",
            color = new Color(1f, 1f, 0f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.BottomRight, Direction.Right, Direction.TopRight
                },
                new Direction[] {
                    Direction.Right, Direction.TopRight, Direction.TopLeft
                },
                new Direction[] {
                    Direction.TopRight, Direction.TopLeft, Direction.Left
                },
                new Direction[] {
                    Direction.TopLeft, Direction.Left, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.Left, Direction.BottomLeft, Direction.BottomRight
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.BottomRight, Direction.Right
                }
            }
        },
        new PieceModel {
            name = "Purple",
            color = new Color(0.75f, 0.75f, 0.25f),
            orientations = new Direction[][] {
                new Direction[] {
                    Direction.Right, Direction.BottomLeft, Direction.Right
                },
                new Direction[] {
                    Direction.TopRight, Direction.Right, Direction.BottomLeft
                },
                new Direction[] {
                    Direction.TopLeft, Direction.Right, Direction.TopLeft
                },
                new Direction[] {
                    Direction.TopLeft, Direction.Left, Direction.BottomRight
                },
                new Direction[] {
                    Direction.Left, Direction.BottomLeft, Direction.Right
                },
                new Direction[] {
                    Direction.BottomLeft, Direction.Right, Direction.BottomLeft
                }
            }
        }
    };

    public Transform pieces;
    private HexTile[] tiles;

    // Start is called before the first frame update
    void Start() {
        float size = 1.797f;
        tiles = new HexTile[pieces.childCount];

        for (int i = 0; i < pieces.childCount; i++) {
            Transform child = pieces.GetChild(i).transform;
            HexTile childTile = child.GetComponent<HexTile>();

            RaycastHit hit;

            // Debug.DrawRay(child.position + new Vector3(-size, 0.5f, 0f), Vector3.down, Color.blue, 1000f);

            // Right
            if (Physics.Raycast(child.position + new Vector3(-size, 0.5f, 0f), Vector3.down, out hit, 100f)) {
                childTile.neighbours[Direction.Right] = hit.collider.GetComponent<HexTile>();
            }

            // Bottom right
            if (Physics.Raycast(child.position + new Vector3(-size * 0.5f, 0.5f, size), Vector3.down, out hit, 100f)) {
                childTile.neighbours[Direction.BottomRight] = hit.collider.GetComponent<HexTile>();
            }

            // Bottom left
            if (Physics.Raycast(child.position + new Vector3(size * 0.5f, 0.5f, size), Vector3.down, out hit, 100f)) {
                childTile.neighbours[Direction.BottomLeft] = hit.collider.GetComponent<HexTile>();
            }

            // Left
            if (Physics.Raycast(child.position + new Vector3(size, 0.5f, 0f), Vector3.down, out hit, 100f)) {
                childTile.neighbours[Direction.Left] = hit.collider.GetComponent<HexTile>();
            }

            // Top left
            if (Physics.Raycast(child.position + new Vector3(size * 0.5f, 0.5f, -size), Vector3.down, out hit, 100f)) {
                childTile.neighbours[Direction.TopLeft] = hit.collider.GetComponent<HexTile>();
            }

            // Top right
            if (Physics.Raycast(child.position + new Vector3(-size * 0.5f, 0.5f, -size), Vector3.down, out hit, 100f)) {
                childTile.neighbours[Direction.TopRight] = hit.collider.GetComponent<HexTile>();
            }

            tiles[i] = childTile;
        }

        Regenerate();
    }

    bool CanFit(HexTile tile, Direction[] pieceOrientation) {
        HexTile current = tile;
        if (tile.occupied) {
            return false;
        }
        foreach (Direction dir in pieceOrientation) {
            current = current.neighbours[dir];
            if (current == null || current.occupied) {
                return false;
            }
        }

        return true;
    }

    void Paint(HexTile tile, PieceModel piece, Direction[] pieceOrientation) {
        HexTile current = tile;
        current.GetComponent<Renderer>().material.color = piece.color;
        current.occupied = true;
        foreach (Direction dir in pieceOrientation) {
            current = current.neighbours[dir];
            current.GetComponent<Renderer>().material.color = piece.color;
            current.occupied = true;
        }
    }

    void Shuffle<T>(T[] array) {
        int n = array.Length;
        while (n > 1) {
            int k = Random.Range(0, n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }

    void Regenerate() {
        foreach (HexTile t in tiles) {
            t.GetComponent<Renderer>().material.color = Color.black;
            t.occupied = false;
        }

        Shuffle(hexPieceModels);
        List<PieceModel> unusedPieces = new List<PieceModel>(hexPieceModels);

        for (int i = 0; i < tiles.Length; i++) {
            PieceModel foundPieceModel = null;

            foreach (PieceModel p in unusedPieces) {
                Shuffle(p.orientations);
                foreach (Direction[] o in p.orientations) {
                    if (CanFit(tiles[i], o)) {
                        foundPieceModel = p;

                        Paint(tiles[i], p, o);

                        break;
                    }
                }
            }

            if (foundPieceModel != null) {
                unusedPieces.Remove(foundPieceModel);
            }
        }

        foreach (HexTile t in tiles) {
            if (!t.occupied) {
                Regenerate();
            }
        }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            Regenerate();
        }
    }
}
