// using UnityEngine;
// using UnityEngine.UI;

// public class SwipeTest : MonoBehaviour 
// {
//     public SwipeManager swipeControls;
//     public Transform player;
//     private Vector3 desiredPosition;

//     void Update() 
//     {
//         if(swipeControls.SwipeLeft)
//         {
//             desiredPosition += Vector3.left;
//         }
//         if(swipeControls.SwipeRight)
//         {
//             desiredPosition += Vector3.right;
//         }
//         if(swipeControls.SwipeUp)
//         {
//             desiredPosition += Vector3.up;
//         }

//         player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);
//     }
// }