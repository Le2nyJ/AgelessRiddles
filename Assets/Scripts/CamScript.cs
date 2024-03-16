using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform WallMinX;
    [SerializeField] private Transform WallMaxX;
    [SerializeField] private Transform WallMinZ;
    [SerializeField] private Transform WallMaxZ;
    [SerializeField] private Transform CameraCenter;
    [SerializeField] private float cameraOffset = 3;
    
    

    private float playerminx;
    private float playermaxx;
    private float playerminz;
    private float playermaxz;



    void Start()
    {
        playerminx = WallMinX.position.x;
        playermaxx = WallMaxX.position.x;
        playerminz = WallMinZ.position.z;
        playermaxz = WallMaxZ.position.z;

    }
    void Update()
    {
        float wallLengthx = playermaxx - playerminx;
        float wallLengthz = playermaxz - playerminz;
        float playerDistX = player.position.x - playerminx;
        float playerDistZ = player.position.z - playerminz;
        float x = (playerDistX / wallLengthx);
        float z = (playerDistZ / wallLengthz);
        //lerp position from camera min to camera max based on x and z
        transform.position = new Vector3(Mathf.Lerp(CameraCenter.position.x - cameraOffset, CameraCenter.position.x + cameraOffset , x), transform.position.y, Mathf.Lerp(CameraCenter.position.z - cameraOffset, CameraCenter.position.z + cameraOffset, z));
    }
}
