## ProgY2P1

# Opdracht 1
deze opdracht was een herhaling van vorig jaar

![Screenshot 2026](./Screenshot%202026-09-10%20130946.png)

# Opdracht 2
![GIF](./bossfightcut.gif)

# Opdracht 3
![Debug](./debug.png)


# opdracht 4
public variables changed:
    [Header("Spawn Point")]
    public Transform start;

    public int singular = 1;
    public int small = 4;
    public int medium = 8;
    public int large = 12;
    public int big = 20;

    public float xSlow = 2f;
    public float slow = 1f;
    public float basic = 0.5f;
    public float quick = 0.25f;
    public float rush = 0.1f;

    [SerializeField] public GameObject triangleEnemy;
    [SerializeField] public GameObject fastTriangleEnemy;
    [SerializeField] public GameObject squareEnemy;
    [SerializeField] public GameObject hexagonEnemy;
    [SerializeField] public GameObject circleBoss;

    public int CurrentRound = 1;
    public int MaxRounds = 10;
    public float timeBetweenRounds = 2f;  
