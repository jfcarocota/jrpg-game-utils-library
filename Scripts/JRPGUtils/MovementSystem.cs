
using UnityEngine;


namespace JRPGUtils.MovementSystem
{
    public static class MovementSystem
    {

        /// <summary>
        /// Move a sprite in XY direction using the axis of keyboard or gamepad.
        /// </summary>
        /// <param name="t">Transform component of the sprite.</param>
        /// <param name="moveSpeed">Speed of the movement.</param>
        /// <param name="axis">Direction of the movement based on keyboard or gamepad axis.</param>
        public static void Move2DTopdown(Transform t, float moveSpeed, Vector2 axis)
        {
            t.Translate(axis * moveSpeed * axis);
        }
    }
}