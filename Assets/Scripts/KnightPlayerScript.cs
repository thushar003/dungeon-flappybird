using UnityEngine;

public class KnightPlayerScript : MonoBehaviour
{
    public float force = 500.1f;
    public Rigidbody2D playerRigidbody;
    public GameManager instance;
    private Vector2 forceVector;

    [SerializeField] private AudioSource jumpSFX;
    [SerializeField] private AudioSource impactSFX;

    // Start is called before the first frame update
    void Start()
    {
        forceVector = new Vector2(0.0f, force);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(forceVector);
            jumpSFX.Play();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerRigidbody.AddForce(forceVector);
            jumpSFX.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        impactSFX.Play();
        GameManager.instance.ResetTheGame();
    }

}
