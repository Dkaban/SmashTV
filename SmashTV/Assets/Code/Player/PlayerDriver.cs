/*************************
 * 
 * PlayerDriver.cs
 * 
 * Author: Dustin Kaban
 * Date: July 29th, 2020
 * 
 * This class handles the Player and it's base functionality
 * 
 *************************/

using UnityEngine;

public class PlayerDriver : MonoBehaviour
{
    //Default Variables
    private const float PLAYER_CENTER_OF_MASS = 0.5f;

    //Prefabs
    public GameObject BulletObjectPrefab;

    public Player player = new Player(Vector3.zero, Character.CharacterType.Player, 5.0f);
    private Rigidbody rigidBody;

    //Variables for Mouse
    private Vector3 mouseScreenPosition;
    private Vector3 mouseWorldSpace;

    private void Awake()
    {
        player.SetTransform(this.transform);
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        player.Move(rigidBody);
        UpdateMousePosition();
        player.LookTowards(mouseWorldSpace);
    }

    private void Start()
    {
        UIHandler.Instance.InitializePlayerUI(player.GetHealth());
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletGO = GameObject.Instantiate(BulletObjectPrefab);
            bulletGO.GetComponent<PlayerBullet>().Initialize(mouseWorldSpace, transform);
        }
    }

    private void UpdateMousePosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit,250.0f))
        {
            //This is where we hit
            mouseWorldSpace = hit.point;
            mouseWorldSpace.y = PLAYER_CENTER_OF_MASS;
        }
    }
}
