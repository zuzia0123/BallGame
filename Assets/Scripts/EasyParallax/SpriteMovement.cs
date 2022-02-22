using UnityEngine;

namespace EasyParallax
{
    /**
 * Moves a sprite along the X axes using a predefined speed
 */
    public class SpriteMovement : MonoBehaviour
    {
        public MovementSpeedType movementSpeedType;

        [Tooltip("Used only if no movement speed type is specified")]
        public float speed = 1f;
        public float lastx;
        public SpriteMovement()
        {
            lastx = Camera.main.transform.position.x;
        }


        private void Awake()
        {
            if (movementSpeedType)
                speed = movementSpeedType.speed;

        }

        private void Update()
        {
            var currentx = Camera.main.transform.position.x;
            var deltax = currentx - lastx;
            Debug.Log("delta " + deltax);
            //Save the current position, so we can edit it
            var newPosition = transform.position;
            //Move the position along the x axis by an amount that depends on the
            //defined speed and the deltaTime, so we can get a framerate independent movement
            newPosition.x -= speed * deltax;
           
            //Update our position
            transform.position = newPosition;
            lastx = currentx;
        }
    }
}